using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using 宝塔管理工具.entity;
using 宝塔管理工具.entity.requestEntity;

namespace 宝塔管理工具
{
    public class SiteManager
    {
        private readonly string _btAddress;
        private readonly string _btToken;
        private readonly ToolStripStatusLabel _status;
        private readonly Form form;
        private readonly DataGridView _dataGridView;
        private readonly ComboBox _comboBox;
        internal int SiteId { get; set; }
        internal string SiteName { get; set; }
        internal bool DeletePath { get; set; }
        internal int TypeId { get; set; }
        internal int SelectNum { get; set; }

        internal DataGridViewSelectedRowCollection Rows { get; set; }

        /// <summary>
        /// 主构造方法
        /// </summary>
        /// <param name="btToken"></param>
        /// <param name="btAddress"></param>
        /// <param name="dataGridView"></param>
        /// <param name="status"></param>
        /// <param name="from"></param>
        /// <param name="comboBox"></param>
        public SiteManager(string btAddress, string btToken, DataGridView dataGridView, ToolStripStatusLabel status,
            Form from,ComboBox comboBox)
        {
            _btToken = btToken;
            _btAddress = btAddress.StartsWith("http://")? btAddress:"http://" + btAddress;;
            _dataGridView = dataGridView;
            _status = status;
            form = from;
            _comboBox = comboBox;
        }

        public void BatchAddSite()
        {
            var batchAddSite = new BatchAddSite();
            batchAddSite.ShowDialog();
            
        }
        
        /// <summary>
        /// 获取分类列表
        /// </summary>
        public void GetAndShowTypes()
        {
            
            if(SetInvoke(_comboBox, GetAndShowTypes)) return;
            _status.Text = @"正在登录";
            _status.Text = @"正在获取分类列表";
            var body = new TypesRequestEntity(_btToken);
            var client = new RestClient(_btAddress+"/site?action=get_site_types");
            var request = new RestRequest(Method.POST);
            SetTokenParam(request, body);
            _comboBox.Items.Clear();
            var jsonResult = client.Execute(request).Content;
            jsonResult = CheckJsonResultIsNull(jsonResult, client, request);
            var list = JsonConvert.DeserializeObject<List<Types>>(Regex.Unescape(jsonResult));
            foreach (var data in list)
            {
                _comboBox.Items.Add(data.name);
            }
            _comboBox.SelectedIndex = 0;
            _status.Text = @"登录成功";
            _status.Text = @"分类获取完毕";
        }

        /// <summary>
        /// 展示网站列表
        /// </summary>
        public void ShowSiteList()
        {
            if (SetInvoke(_dataGridView,ShowSiteList)) return;
            _dataGridView.Rows.Clear();
            _status.Text = @"正在展示网站列表";
            var list = GetSiteList();
            var dataItems = list.data;
            for (var i = 0; i < dataItems.Count; i++)
            {
                var dataItem = dataItems[i];
                var index = _dataGridView.Rows.Add();
                _dataGridView.Rows[index].Cells[0].Value = (i + 1);
                _dataGridView.Rows[index].Cells[1].Value = dataItem.name;
                _dataGridView.Rows[index].Cells[2].Value = dataItem.domain;
                _dataGridView.Rows[index].Cells[3].Value = "1".Equals(dataItem.status) ? "运行中" : "暂停中";
                _dataGridView.Rows[index].Cells[4].Value =
                    dataItem.backup_count >= 1 ? dataItem.backup_count + "份备份" : "无备份";
                _dataGridView.Rows[index].Cells[5].Value = dataItem.path;
                _dataGridView.Rows[index].Cells[6].Value = false;
                _dataGridView.Rows[index].Cells[7].Value = dataItem.id;
            }

            _status.Text = @"网站列表显示完毕";
        }
        
        /// <summary>
        /// 获取网站列表
        /// </summary>
        /// <returns></returns>
        private SiteEntity GetSiteList()
        {
            _status.Text = @"正在登录中";
            var body = new SiteListRequestEntity(_btToken)
            {
                Tojs = "site.get_list",
                Table = "sites",
                Limit = SelectNum.ToString(),
                P = "1",
                Search = "",
                Order = "id desc",
                Type = TypeId.ToString()
            };
            var client = new RestClient(_btAddress + "/data?action=getData");
            var request = new RestRequest(Method.POST);
            request.AddParameter("tojs", body.Tojs);
            request.AddParameter("table", body.Table);
            request.AddParameter("limit", body.Limit);
            request.AddParameter("p", body.P);
            request.AddParameter("search", body.Search);
            request.AddParameter("order", body.Order);
            request.AddParameter("type", body.Type);
            SetTokenParam(request, body);
            Console.WriteLine(body);
            var jsonResult = client.Execute(request).Content;
            jsonResult = CheckJsonResultIsNull(jsonResult, client, request);
            var siteEntity = JsonConvert.DeserializeObject<SiteEntity>(jsonResult);
            return siteEntity;
        }

        /// <summary>
        /// 单个网站删除
        /// </summary>
        public void DeleteSite()
        {
            var body = new DeleteSiteRequestEntity(_btToken) { Id = SiteId, Webname = SiteName };
            _status.Text = @"正在删除"+SiteName;
            if (DeletePath) body.Path = 1;
            var client = new RestClient(_btAddress + "/site?action=DeleteSite");
            var request = new RestRequest(Method.POST);
            request.AddParameter("id", SiteId);
            request.AddParameter("webname", SiteName);
            request.AddParameter("request_time", body.RequestTime);
            request.AddParameter("request_token", body.RequestToken);
            request.AddParameter("path", body.Path);
            var jsonResult = client.Execute(request).Content;
            jsonResult = CheckJsonResultIsNull(jsonResult, client, request);
            var jsonStr = (JContainer)JsonConvert.DeserializeObject(jsonResult);
            _status.Text = jsonStr["msg"].ToString();
            Thread.Sleep(1000);
            ShowSiteList();
        }

        /// <summary>
        /// 检查返回信息是否未NULL
        /// </summary>
        /// <param name="jsonResult"></param>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        private static string CheckJsonResultIsNull(string jsonResult, RestClient client, RestRequest request)
        {
            var count = 0;
            while (jsonResult == null)
            {
                jsonResult = client.Execute(request).Content;
                count++;
                if (count > 3 && jsonResult == null)
                {
                    MessageBox.Show(@"网络异常或不稳定，请重试！");
                    Thread.CurrentThread.Abort();
                }
            }
            return jsonResult;
        }

        /// <summary>
        /// 设置API必要参数
        /// </summary>
        /// <param name="request"></param>
        /// <param name="body"></param>
        private static void SetTokenParam(IRestRequest request, BaseRequestEntity body)
        {
            request.AddParameter("request_time", body.RequestTime);
            request.AddParameter("request_token", body.RequestToken);
        }
        
        /// <summary>
        /// 设置委托控件及委托方法
        /// </summary>
        /// <param name="control"></param>
        /// <param name="method"></param>
        /// <returns></returns>
        private bool SetInvoke(Control control,Action method)
        {
            if (!form.InvokeRequired) return false;
            while (!control.IsHandleCreated)
            {
                ;
            }
            form.Invoke(new MethodInvoker(method));
            return true;
        }

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="deletePath"></param>
        public void BatchDeleteSite(Object deletePath)
        {
            foreach (DataGridViewRow row in Rows)
            {
                SiteId = int.Parse(row.Cells[7].Value.ToString());
                SiteName = row.Cells[1].Value.ToString();
                DeletePath = (bool) deletePath;
                DeleteSite();
            }
            Thread.Sleep(1000);
            ExitThread();
        }

        private static void ExitThread()
        {
            Thread.Sleep(1000);
            Thread.CurrentThread.Abort();
        }
    }
}
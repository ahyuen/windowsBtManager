using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using 宝塔管理工具;
using 宝塔管理工具.entity;

namespace 宝塔管理工具
{
    public partial class MainWindows : Form
    {
        private SiteManager _manager;

        public MainWindows()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 登录点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginBT_Click(object sender, EventArgs e)
        {
            if ("登出".Equals(loginBT.Text))
            {
                BT_address.ReadOnly = false;
                BT_token.ReadOnly = false;
                selectSite.Enabled = false;
                DeleteSelected2.Enabled = false;
                DeleteSelected.Enabled = false;
                BatchAddSite.Enabled = false;
                loginBT.Text = @"登录";
                _manager = null;
                BT_address.Text = null;
                BT_token.Text = null;
                types.Items.Clear();
                loginProperties.Enabled = true;
                savaProperties.Enabled = false;
            }
            else
            {
                if (!SetManagerObject()) return;
                var thread = new Thread(_manager.GetAndShowTypes);
                thread.Start();
                BT_address.ReadOnly = true;
                BT_token.ReadOnly = true;
                selectSite.Enabled = true;
                DeleteSelected2.Enabled = true;
                DeleteSelected.Enabled = true;
                BatchAddSite.Enabled = true;
                loginBT.Text = @"登出";
                loginProperties.Enabled = false;
                savaProperties.Enabled = true;
            }
        }

        /// <summary>
        /// 创建网站对象
        /// </summary>
        private bool SetManagerObject()
        {
            if (!CheckTextBox()) return false;
            var btAddress = BT_address.Text;
            var token = BT_token.Text;
            _manager = new SiteManager(btAddress, token, dataView, statusLabel, this, types);
            return true;
        }

        /// <summary>
        /// 检测比表单
        /// </summary>
        /// <returns></returns>
        private bool CheckTextBox()
        {
            if (string.IsNullOrEmpty(BT_address.Text.Trim()) && loginProperties.SelectedIndex == -1)
            {
                MessageBox.Show(@"宝塔地址不能为空");
                return false;
            }

            if (string.IsNullOrEmpty(BT_token.Text.Trim()) && loginProperties.SelectedIndex == -1)
            {
                MessageBox.Show(@"宝塔密钥不能为空");
                return false;
            }

            return true;
        }

        /// <summary>
        /// 数据表点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var cIndex = e.ColumnIndex;
            var rIndex = e.RowIndex;
            if (cIndex == 8)
            {
                var id = int.Parse(dataView.Rows[rIndex].Cells[cIndex - 1].Value.ToString());
                _manager.SiteId = id;
                var webname = dataView.Rows[rIndex].Cells[1].Value.ToString();
                _manager.SiteName = webname;
                var path = (bool) dataView.Rows[rIndex].Cells[6].Value;
                _manager.DeletePath = path;
                if (MessageBox.Show(@"确认删除" + webname + (path ? "及其运行目录" : ""), @"确认删除？", MessageBoxButtons.OKCancel) !=
                    DialogResult.OK) return;
                var thread = new Thread(_manager.DeleteSite);
                thread.Start();
            }
        }

        /// <summary>
        /// 查询点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Select_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectNub.Text))
            {
                MessageBox.Show(@"查询数量不能为空");
                return;
            }

            var typeId = types.Items.IndexOf(types.Text);
            _manager.TypeId = typeId;
            _manager.SelectNum = int.Parse(selectNub.Text);
            var thread = new Thread(_manager.ShowSiteList);
            thread.Start();
        }

        /// <summary>
        /// keypress事件，显示textbox只能输入数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectNub_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char) 0; //禁止空格键
            if ((e.KeyChar == 0x2D) && (((TextBox) sender).Text.Length == 0)) return; //处理负数
            if (e.KeyChar <= 0x20) return;
            try
            {
                double.Parse(((TextBox) sender).Text + e.KeyChar.ToString());
            }
            catch
            {
                e.KeyChar = (char) 0; //处理非法字符
            }
        }

        /// <summary>
        /// 批量删除，同时删除目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteSelect_Click(object sender, EventArgs e)
        {
            var rows = dataView.SelectedRows;
            _manager.Rows = rows;
            if (MessageBox.Show(@"删除" + rows.Count + @"个网站及其根目录？", @"确认删除？", MessageBoxButtons.OKCancel) !=
                DialogResult.OK) return;
            var thread = new Thread(_manager.BatchDeleteSite);
            thread.Start(true);
        }

        /// <summary>
        /// 批量删除。不删目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteSelected2_Click(object sender, EventArgs e)
        {
            var rows = dataView.SelectedRows;
            _manager.Rows = rows;
            if (MessageBox.Show(@"删除" + rows.Count + @"个网站？", @"确认删除？", MessageBoxButtons.OKCancel) !=
                DialogResult.OK) return;
            var thread = new Thread(_manager.BatchDeleteSite);
            thread.Start(false);
        }

        /// <summary>
        /// 批量添加网站点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BatchAddSite_Click(object sender, EventArgs e)
        {
            var thread = new Thread(_manager.BatchAddSite);
            thread.Start();
        }

        private void MainWindows_Load(object sender, EventArgs e)
        {
            var entities = JsonProperties.ReaderJsonFile();
            if (entities == null)
            {
                return;
            }
            foreach (var entity in entities)
            {
                loginProperties.Items.Add(entity.ServerName);
            }

            loginProperties.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckTextBox()) return;
            var btAddress = BT_address.Text;
            var btToken = BT_token.Text;
            var searchTxtText = searchTxt.Text;
            var textBox = selectNub.Text;
            var form = new SavaPropertiesForm(btAddress,btToken,types,searchTxtText,textBox);
            form.ShowDialog();
        }
    }
}
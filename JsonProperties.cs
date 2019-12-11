using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using 宝塔管理工具.entity;

namespace 宝塔管理工具
{
    public class JsonProperties
    {
        private string _btAddress;
        private string _btToken;
        private string _servername;
        private ComboBox _comboBox;
        private string _search;
        private string _selectNum;

        public JsonProperties(string btAddress, string btToken, ComboBox comboBox, string search, string selectNum,string servername)
        {
            _btAddress = btAddress;
            _btToken = btToken;
            _comboBox = comboBox;
            _search = search;
            _selectNum = selectNum;
            _servername = servername;
        }

        /// <summary>
        /// 保存配置主方法
        /// </summary>
        public void SaveProperties()
        {
            var entities = ReaderJsonFile();
            if (entities == null || entities.Count()==0)
            {
                entities = new List<PropertiesEntity>();
            }
            var id = GetId(entities);
            if (CheckServerNameIsExist(entities)) return;
            
            var entity = new PropertiesEntity
            {
                Id = id,
                BtAddress = _btAddress,
                BtToken = _btToken,
                SearchText = _search,
                SelectNum = _selectNum,
                ServerName = _servername
            };
            var list = new List<Types>();
            for (var i = 0; i < _comboBox.Items.Count; i++)
            {
                var item = _comboBox.Items[i];
                var types = new Types {id = i, name = (string) item};
                Console.WriteLine(types.name);
                list.Add(types);
            }
            entity.Types = list;
            entities.Add(entity);
            var json = JsonConvert.SerializeObject(entities);
            WriteJsonToFile(json);
        }
        
        /// <summary>
        /// 检查服务器名是否存在
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        private bool CheckServerNameIsExist(List<PropertiesEntity> entities)
        {
            var servernames = entities.Select(data => data.ServerName).ToList();
            if (servernames.Contains(_servername))
            {
                MessageBox.Show(@"改服务器名已存在，请更换");
                return true;
            }

            return false;
        }

        /// <summary>
        /// 获取ID
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        private static int GetId(List<PropertiesEntity> entities)
        {
            var id = 0;
            if (entities.Count == 0)
            {
                id = 1;
            }
            else
            {
                id = entities[entities.Count-1].Id + 1;
            }

            return id;
        }

        /// <summary>
        /// 读Json数据
        /// </summary>
        /// <returns></returns>
        public static List<PropertiesEntity> ReaderJsonFile()
        {
            var entities = new List<PropertiesEntity>();
            var file = new FileStream("properties.json",FileMode.Open,FileAccess.Read);
            if (File.Exists(@"properties.json"))
            {
                File.Create(@"properties.json");
                return entities;
            }
            var sr = new StreamReader(file);
            var end = sr.ReadToEnd();
            entities = JsonConvert.DeserializeObject<List<PropertiesEntity>>(end);
            sr.Close();
            
            return entities;
        }

        /// <summary>
        /// 写出Json数据
        /// </summary>
        /// <param name="json"></param>
        private void WriteJsonToFile(string json)
        {
            json = ConvertJsonString(json);
            var file = new FileStream("properties.json",FileMode.Create, FileAccess.Write);
            var sw = new StreamWriter(file);
            sw.Write(json);
            sw.Dispose();
        }
        
        /// <summary>
        /// 格式化Json串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string ConvertJsonString(string str)
        {
            //格式化json字符串
            var serializer = new JsonSerializer();
            TextReader tr = new StringReader(str);
            var jtr = new JsonTextReader(tr);
            var obj = serializer.Deserialize(jtr);
            if (obj != null)
            {
                var textWriter = new StringWriter();
                var jsonWriter = new JsonTextWriter(textWriter)
                {
                    Formatting = Formatting.Indented,
                    Indentation = 4,
                    IndentChar = ' '
                };
                serializer.Serialize(jsonWriter, obj);
                return textWriter.ToString();
            }
            else
            {
                return str;
            }
        }
    }
}
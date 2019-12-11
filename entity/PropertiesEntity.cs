using System.Collections.Generic;

namespace 宝塔管理工具.entity
{
    public class PropertiesEntity
    {
        public int Id { get; set; }
        public string ServerName { get; set; }
        public string BtAddress { get; set; }
        public string BtToken { get; set; }
        public List<Types> Types { get; set; }
        public string SearchText { get; set; }
        public string SelectNum { get; set; }
    }
}
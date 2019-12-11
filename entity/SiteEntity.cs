using System.Collections.Generic;

namespace 宝塔管理工具.entity
{
    public class DataItem : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public string status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ps { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int domain { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string addtime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string path { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int backup_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string edate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
    }

    public class SiteEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public List <DataItem> data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string where { get; set; }
        /// <summary>
        
        /// </summary>
        public string page { get; set; }
    }
}
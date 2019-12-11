namespace 宝塔管理工具.entity.requestEntity
{
    public class SiteListRequestEntity : BaseRequestEntity
    {
        
        // 获取内容
        private string tojs;
        // 列表内容
        private string table;
        // 显示数量
        private string limit;
        // 页码
        private string p;
        // 搜索内容
        private string search;
        // 排序方式
        private string order;
        // 网站分类
        private string type;
        
        public string Tojs
        {
            get => tojs;
            set => tojs = value;
        }

        public string Table
        {
            get => table;
            set => table = value;
        }

        public string Limit
        {
            get => limit;
            set => limit = value;
        }

        public string P
        {
            get => p;
            set => p = value;
        }

        public string Search
        {
            get => search;
            set => search = value;
        }

        public string Order
        {
            get => order;
            set => order = value;
        }

        public string Type
        {
            get => type;
            set => type = value;
        }

        public SiteListRequestEntity(string token)
        {
            RequestTime = Utils.GetTimeStamp();
            RequestToken = GetToken(token,RequestTime);
        }        

        public override string ToString()
        {
            return "tojs:"+tojs+",table:"+table+",limit:"+limit+",p:"+p+",Search:"+search+",Order:"+order+",Type:"+type+"token:"+RequestToken+"time:"+RequestTime;
        }
    }
}
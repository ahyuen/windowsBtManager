namespace 宝塔管理工具.entity.requestEntity
{
    public class DeleteSiteRequestEntity:BaseRequestEntity
    {
        private int id;
        private string webname;
        private int path;
        
        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Webname
        {
            get => webname;
            set => webname = value;
        }

        public int Path
        {
            get => path;
            set => path = value;
        }
        
        public DeleteSiteRequestEntity(string token)
        {
            RequestTime = Utils.GetTimeStamp();
            RequestToken = GetToken(token,RequestTime);
        }   
    }
}
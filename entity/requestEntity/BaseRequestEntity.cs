namespace 宝塔管理工具.entity.requestEntity
{
    public class BaseRequestEntity
    {
        private string request_time;
        private string request_token;

        public string RequestTime
        {
            get => request_time;
            set => request_time = value;
        }
        public string RequestToken
        {
            get => request_token;
            set => request_token = value;
        }

        protected static string GetToken(string token,string requestTime)
        {
            return Utils.GetMd5Str(requestTime + Utils.GetMd5Str(token));
        }
    }
}
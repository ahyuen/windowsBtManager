namespace 宝塔管理工具.entity.requestEntity
{
    public class TypesRequestEntity:BaseRequestEntity
    {    
        
        public TypesRequestEntity(string token)
        {
            RequestTime = Utils.GetTimeStamp();
            RequestToken = GetToken(token,RequestTime);
        }   
    }
}
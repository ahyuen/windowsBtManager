using System;
using System.Security.Cryptography;
using System.Text;

namespace 宝塔管理工具
{
    public static class Utils
    {
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetMd5Str(string str)
        {
            MD5 md5 = MD5.Create();
            // 将字符串转换成字节数组
            var byteOld = Encoding.UTF8.GetBytes(str);
            // 调用加密方法
            var byteNew =  md5.ComputeHash(byteOld);
            // 将加密结果转换为字符串
            var sb = new StringBuilder();
            foreach (var b in byteNew)
            {
                // 将字节转换成16进制表示的字符串，
                sb.Append(b.ToString("x2"));
            }
            // 返回加密的字符串
            return sb.ToString();
        }
        
        /// <summary>
        /// 获取时间戳
        /// </summary>
        /// <returns></returns>
        public static string GetTimeStamp()
        {
            var ts = DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }
    }
}
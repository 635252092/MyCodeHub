using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace AddressBook.Component
{
   public class HttpRequestHelper
    {
        public static string GetIP(HttpRequestBase request)
        {
            string ip = string.Empty;
            if (request.ServerVariables["HTTP_VIA"] != null)
            {
                ip = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
            }
            else
            {
                ip = request.ServerVariables["REMOTE_ADDR"].ToString();
            }
            return ip;
        }

        /// <summary>
        /// 获得浏览器信息
        /// </summary>
        /// <returns></returns>
        public static string GetBrowser(HttpRequestBase request)
        {
            return request.Browser.Version.ToString();
        }
    }
}

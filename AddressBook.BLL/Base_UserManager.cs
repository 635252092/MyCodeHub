using AddressBook.Dto;
using AddressBook.IBLL;
using System;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Linq;
using AddressBook.Dto.PubEnum;

namespace AddressBook.BLL
{
    public class Base_UserManager : IBase_UserManager
    {
        public object GetBrowser()
        {
            throw new NotImplementedException();
        }

        public object GetIP()
        {
            string ip = string.Empty;
            if (HttpContext.Current.Request.ServerVariables["HTTP_VIA"] != null)
            {
                ip = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
            }
            else
            {
                ip = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"].ToString();
            }
            return ip;
        }

        public LoginEnum Login(LoginInputDto input, out EcdrpSite ecdrpSite)
        {
            throw new NotImplementedException();
        }
    }
}

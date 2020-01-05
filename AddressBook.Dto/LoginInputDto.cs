using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Dto
{
    public class LoginInputDto
    {
        public string UserName { get;  set; }
        public string UserPwd { get;  set; }
        public object IP { get;  set; }
        public object Browser { get;  set; }
    }
}

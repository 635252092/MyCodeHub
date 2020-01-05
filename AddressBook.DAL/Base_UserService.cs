using AddressBook.IDAL;
using AddressBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AddressBook.Model.DB;

namespace AddressBook.DAL
{
    public class Base_UserService : BaseService<Base_User>, IBase_UserService
    {
        public Base_UserService() : base(new AddressBookContext())
        {
        }
    }
}

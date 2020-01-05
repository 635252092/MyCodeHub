using AddressBook.IDAL;
using AddressBook.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AddressBook.Model.DB;
using AddressBook.Model;

namespace AddressBook.DAL
{
    public class Con_GroupService : BaseService<Con_Group>, ICon_GroupService
    {
        public Con_GroupService() : base(new AddressBookContext())
        {
        }
    }
}

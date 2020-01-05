using AddressBook.IDAL;
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
    public class Con_ContactService : BaseService<Con_Contact>, ICon_ContactService
    {
        public Con_ContactService() : base(new AddressBookContext())
        {
        }
    }
}

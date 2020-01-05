using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Model.DB
{
    public class Base_User : Base.BaseEntity
    {
        public string Name { get; set; }
        public virtual List<Con_Contact> Contacts { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Component
{
    public static class EnumExtendMethods
    {
        public static string EnumDesc(this object enumField)
        {
            FieldInfo field = enumField.GetType().GetField(enumField.ToString());
            DescriptionAttribute[] array = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (array.Length > 0)
            {
                return array[0].Description;
            }
            return enumField.ToString();
        }
        public static string EnumCategory(this object enumField)
        {
            FieldInfo field = enumField.GetType().GetField(enumField.ToString());
            CategoryAttribute[] array = (CategoryAttribute[])field.GetCustomAttributes(typeof(CategoryAttribute), false);
            if (array.Length > 0)
            {
                return array[0].Category;
            }
            return enumField.ToString();
        }
    }
}

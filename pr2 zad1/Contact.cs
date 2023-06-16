using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace pr2_zad1
{
    public class Contact
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string numberPhone { get; set; }
        public Contact(string fstn, string lstn, string numbph)
        {
            firstName = fstn;
            lastName = lstn;
            numberPhone = numbph;
        }
        public string GetContact ()
        {
            return $"{firstName} {lastName} {numberPhone}";
        }
    }
}

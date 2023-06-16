using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2_zad1
{
    public class PhoneBook
    {
        List<Contact> contacts = new List<Contact>();

        public PhoneBook ()
        {
            contacts = new List<Contact>();
        }

        public void Add (Contact contact)
        {
            contacts.Add(contact);
        }

        public void Remove (string name, string lastname)
        {
            for(int i = 0; i < contacts.Count; i++)
            {
                if(contacts[i].firstName == name && contacts[i].lastName == lastname)
                {
                    contacts.RemoveAt(i);
                    break;
                }
            }
        }

        public List<Contact> Get ()
        {
            return contacts;
        }
        public int GetCount ()
        {
            return contacts.Count;
        }
        public Contact GetContact (int i)
        {
            return contacts[i];
        }
        public string GetContact(int i, string g)
        {
            return $"{contacts[i].firstName} {contacts[i].lastName} {contacts[i].numberPhone}";
        }
        public List<Contact> SearchContacts (string name, string lastName)
        {
            List<Contact> contact2 = new List<Contact>();
            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].firstName == name && contacts[i].lastName == lastName)
                {
                    contact2.Add(contacts[i]);
                }
            }
            return contact2;
        }
        public List<Contact> SearchContacts (string numberphone)
        {
            List<Contact> contact2 = new List<Contact>();
            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].numberPhone == numberphone)
                {
                    contact2.Add(contacts[i]);
                }
            }
            return contact2;
        }
    }
}

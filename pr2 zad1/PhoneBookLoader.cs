using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pr2_zad1
{
    public static class PhoneBookLoader
    {
        public static void Load(PhoneBook phonebook, string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                while (!sr.EndOfStream)
                {
                    string[] contactDetails = sr.ReadLine().Split(' ');
                        string Firstname = contactDetails[0].Trim();
                        string Lastname = contactDetails[1].Trim();
                        string Phone = contactDetails[2].Trim();
                        phonebook.Add(new Contact(Firstname, Lastname, Phone));
                }
            }
        }
        public static void Save(PhoneBook phonebook, string fileName)
        {
            using (StreamWriter sw = File.CreateText(fileName))
            {
                for(int i = 0; i < phonebook.GetCount()-1; i++)
                {
                    sw.WriteLine(phonebook.GetContact(i, "s"));
                }
                sw.Write(phonebook.GetContact(phonebook.GetCount()-1, "s"));
            }
        }
    }
}

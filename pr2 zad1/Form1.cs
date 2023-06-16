using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pr2_zad1
{
    public partial class Form1 :Form
    {
        private string filename = "numberphoneBook.txt";
        private PhoneBook phoneBook;
        private Contact cont;
        public Form1 ()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("sticker.png");
        }

        private void tabPage1_Click (object sender, EventArgs e)
        {

        }

        private void loadList_btn_Click (object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(filename))
                {
                    PhoneBookLoader.Load(phoneBook, filename);
                    UpadateList(phoneBook);
                } else
                {
                    MessageBox.Show("файл с телефонной книгой не найден");
                }
            }
            catch
            {
                MessageBox.Show("произошла ошибка при выгрузке телефонной книги");
            }
            
        }

        private void savelist_btn_Click (object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(filename))
                {
                    PhoneBookLoader.Save(phoneBook, filename);
                } 
                else
                {
                    MessageBox.Show("файл для телефонной книгой не найден");
                }
            } 
            catch
            {
                MessageBox.Show("произошла ошибка при сохранении телефонной книги");
            }
        }

        private void Form1_Load (object sender, EventArgs e)
        {
            phoneBook = new PhoneBook();
        }
        private void UpdateList (List<Contact> ct)
        {
            listBox1.Items.Clear();
            for(int i = 0; i < ct.Count(); i++)
            {
                listBox1.Items.Add(ct[i].GetContact());
            }
        }
        private void UpadateList(PhoneBook pb)
        {
            listBox1.Items.Clear();
            for(int i = 0; i < pb.GetCount(); i++)
            {
                listBox1.Items.Add(pb.GetContact(i, "s"));
            }
        }

        private void button3_Click (object sender, EventArgs e)
        {
            try
            { 
                char[] numbercheck = nph_txt.Text.ToCharArray();
                bool check = true;
                if (numbercheck.Length == 14)
                {
                    foreach(char i in numbercheck)
                    {
                        if (i >= '0' && i <= '9' || i == '(' || i == ')' || i == '-')
                        {

                        } else
                        {
                            MessageBox.Show("в номере телефона есть недопустимые символы!");
                            check = false;
                            break;
                        }
                    }
                    if (check)
                    {
                        List<Contact> ct = phoneBook.SearchContacts(nph_txt.Text);
                        if (ct.Count == 0)
                        {
                            cont = new Contact(name1_txt.Text, lastname1_txt.Text, nph_txt.Text);
                            phoneBook.Add(cont);
                            UpadateList(phoneBook);
                        } else
                        {
                            MessageBox.Show("такой телефон уже есть в списке!");
                        }
                    }
                } else
                {
                    MessageBox.Show("в номере неправильное количество символов");
                }
            } catch
            {
                MessageBox.Show("не удалось выполнить добавление");
            }
        }

        private void remove_btn_Click (object sender, EventArgs e)
        {
            try
            {
                phoneBook.Remove(name_txt.Text, lastname_txt.Text);
                UpadateList(phoneBook);
            } catch
            {
                MessageBox.Show("не удалось выполнить удаление");
            }
        }

        private void find_btn_Click (object sender, EventArgs e)
        {
            try
            {
                List<Contact> ct = phoneBook.SearchContacts(name_txt.Text, lastname_txt.Text);
                UpdateList(ct);
            } catch
            {
                MessageBox.Show("не удалось выполнить нахождение");
            }
        }

        private void button1_Click (object sender, EventArgs e)
        {
            UpadateList(phoneBook);
        }
    }
}

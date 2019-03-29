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
using System.Text.RegularExpressions;

namespace wf4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        List<Book> _Lib = new List<Book>();
        public struct Book
        {
            public string invNum;
            public string title;
            public string author;
            public string genre;
            public string price;
            public string numOfReaders;
            public string publishingYear;
            public string lastDateGiven;

            public Book(string num, string title, string author, string genre, string price, string readers, string year, string lastDate)
            {
                this.invNum = num;
                this.title = title;
                this.author = author;
                this.genre = genre;
                this.price = price;
                this.numOfReaders = readers;
                this.publishingYear = year;
                this.lastDateGiven = lastDate;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Book> lib = new List<Book>();
            FileStream fs = File.OpenRead(@"C:\Users\Soft\Desktop\wf4\booklibEdit.txt");
            byte[] array = new byte[fs.Length];
            fs.Read(array, 0, array.Length);
            string textFromFile = System.Text.Encoding.Default.GetString(array);

            var structArray = textFromFile.Split('#');
            for (int i = 0; i < structArray.Length; i++)
            {
                var bookFields = structArray[i].Split('|');
                if (bookFields.Length == 8)
                {
                    for (int j = 0; j < bookFields.Length; j++)
                    {
                        var pattern = @"\s";
                        //bookFields[j] = Regex.Replace(bookFields[j], pattern, "");
                    }
                    Book newbie = new Book(bookFields[0], bookFields[1], bookFields[2], bookFields[3], bookFields[4], bookFields[5], bookFields[6], bookFields[7]);
                    lib.Add(newbie);
                }
            }
            
            dataGridView1.DataSource = lib;
            for (int j = 0; j < dataGridView1.ColumnCount; j++)
            {
                for (int i = 0; i < lib.Count; i++)
                {
                    if (j == 0)
                    {
                        dataGridView1[j, i].Value = lib[i].invNum;
                    }
                    if (j == 1)
                    {
                        dataGridView1[j, i].Value = lib[i].title;
                    }
                    if (j == 2)
                    {
                        dataGridView1[j, i].Value = lib[i].author;
                    }
                    if (j == 3)
                    {
                        dataGridView1[j, i].Value = lib[i].genre;
                    }
                    if (j == 4)
                    {
                        dataGridView1[j, i].Value = lib[i].price;
                    }
                    if (j == 5)
                    {
                        dataGridView1[j, i].Value = lib[i].numOfReaders;
                    }
                    if (j == 6)
                    {
                        dataGridView1[j, i].Value = lib[i].publishingYear;
                    }
                    if (j == 7)
                    {
                        dataGridView1[j, i].Value = lib[i].lastDateGiven;
                    }
                }
            }

            _Lib = lib;
            fs.Close();
        }
    }
}

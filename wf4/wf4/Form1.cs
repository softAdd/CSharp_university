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
            public int price;
            public string numOfReaders;
            public string publishingYear;
            public string lastDateGiven;
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


            /* LINQ */
            var text = richTextBox1.Text;
            var sel = from book in _Lib
                      where book.author.Contains(text)
                      select book;
            /* LINQ */
            dataGridView1.Rows.Clear();
            foreach (var elem in sel)
            {
                dataGridView1.Rows.Add(elem.invNum, elem.title, elem.author, elem.genre, elem.price, elem.numOfReaders, elem.publishingYear, elem.lastDateGiven);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /* LINQ */
            var text = comboBox1.Text;
            var sel = from book in _Lib
                      where book.lastDateGiven.Contains(text)
                      select book;
            /* LINQ */

            dataGridView1.Rows.Clear();
            foreach (var elem in sel)
            {
                dataGridView1.Rows.Add(elem.invNum, elem.title, elem.author, elem.genre, elem.price, elem.numOfReaders, elem.publishingYear, elem.lastDateGiven);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Book t;
            string[] mas = File.ReadAllLines(@"C:\Users\Soft\Desktop\wf4\booklib.txt");
            for (var i = 0; i < mas.Length; i++)
            {
                string[] s = mas[i].Split('|');
                t.invNum = s[0];
                t.title = s[1];
                t.author = s[2];
                t.genre = s[3];
                t.price = int.Parse(s[4]);
                t.numOfReaders = s[5];
                t.publishingYear = s[6];
                t.lastDateGiven = s[7];
                _Lib.Add(t);
            }
            dataGridView1.Rows.Clear();
            foreach (var book in _Lib)
            {
                dataGridView1.Rows.Add(book.invNum, book.title, book.author, book.genre, book.price.ToString(), book.numOfReaders, book.publishingYear, book.lastDateGiven);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            StreamWriter go = new StreamWriter(@"C:\Users\Soft\Desktop\wf4\booklibEdit.txt");

            for (var row = 0; row < dataGridView1.Rows.Count; row++)
            {
                go.WriteLine(dataGridView1[0, row].Value);
                go.WriteLine(" | " + dataGridView1[1, row].Value);
                go.WriteLine(" | " + dataGridView1[2, row].Value);
                go.WriteLine(" | " + dataGridView1[3, row].Value);
                go.WriteLine(" | " + dataGridView1[4, row].Value);
                go.WriteLine(" | " + dataGridView1[5, row].Value);
                go.WriteLine(" | " + dataGridView1[6, row].Value);
                go.WriteLine(" | " + dataGridView1[7, row].Value);
            }

            var date = DateTime.Now;
            go.Write("\nПоследняя дата поиска: " + date.ToString());
            go.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

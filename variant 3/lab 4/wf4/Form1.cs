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
        /* Для использования заменить userName в обработчиках кнопок на имя своего пользователя и скопировать на рабочий стол файлы file и fileEdit */
        public Form1()
        {
            InitializeComponent();
            
        }
        List<Section> _Lib = new List<Section>();
        public struct Section
        {
            public string phoneNumber;
            public string bossFamily;
            public string sectionTitle;
            public string location;
            public int peopleCount;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            Section t;
            string userName = "Soft";
            string[] mas = File.ReadAllLines(@"C:\Users\" + userName + @"\Desktop\file.txt");
            for (var i = 0; i < mas.Length; i++)
            {
                string[] s = mas[i].Split('|');
                t.phoneNumber = s[0];
                t.bossFamily = s[1];
                t.sectionTitle = s[2];
                t.peopleCount = int.Parse(s[3]);
                t.location = s[4];
                _Lib.Add(t);
            }

            comboBox1.Items.Add("Все");
            comboBox1.Items.Add("Сортировать по количеству сотрудников");
            comboBox1.Items.Add("Сортировать по фамилиям");
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* LINQ */
            var text = richTextBox1.Text;
            var sel = from section in _Lib
                      where section.sectionTitle.Contains(text)
                      select section;
            /* LINQ */
            dataGridView1.Rows.Clear();
            foreach (var elem in sel)
            {
                dataGridView1.Rows.Add(elem.phoneNumber, elem.bossFamily, elem.sectionTitle, elem.location, elem.peopleCount);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string userName = "Soft";
            StreamWriter go = new StreamWriter(@"C:\Users\" + userName + @"\Desktop\fileEdit.txt");
            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                go.WriteLine("Номер телефона:           " + dataGridView1[0, row].Value);
                go.WriteLine("Фамилия начальника:      " + dataGridView1[1, row].Value);
                go.WriteLine("Отдел:                   " + dataGridView1[2, row].Value);
                go.WriteLine("Местоположение (корпус): " + dataGridView1[3, row].Value);
                go.WriteLine("Количество сотрудников:   " + dataGridView1[4, row].Value);
                go.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            }
            string date = DateTime.Now.ToString();
            go.Write("\nПоследняя дата поиска: " + date);
            go.Close();
        }

        private void getDefaultList()
        {
            dataGridView1.Rows.Clear();
            foreach (var section in _Lib)
            {
                dataGridView1.Rows.Add(section.phoneNumber, section.bossFamily, section.sectionTitle, section.location, section.peopleCount);
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    getDefaultList();
                    break;
                case 1:
                    dataGridView1.Rows.Clear();
                    /* LINQ */
                    var sel = from section in _Lib
                              orderby section.peopleCount
                              select section;
                    /* LINQ */
                    dataGridView1.Rows.Clear();
                    foreach (var elem in sel)
                    {
                        dataGridView1.Rows.Add(elem.phoneNumber, elem.bossFamily, elem.sectionTitle, elem.location, elem.peopleCount);
                    }
                    break;
                case 2:
                    dataGridView1.Rows.Clear();
                    /* LINQ */
                    var sel2 = from section in _Lib
                               orderby section.bossFamily
                               select section;
                    /* LINQ */
                    dataGridView1.Rows.Clear();
                    foreach (var elem in sel2)
                    {
                        dataGridView1.Rows.Add(elem.phoneNumber, elem.bossFamily, elem.sectionTitle, elem.location, elem.peopleCount);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}

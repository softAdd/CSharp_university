using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct Journal
        {
            public string title;
            // freq per week
            public int period;
            public int price;
            // number of journals issued
            public int count;

            public Journal(string title, int period, int price, int count)
            {
                this.title = title;
                this.period = period;
                this.price = price;
                this.count = count;
            }

            public int getPrice()
            {
                return period * 4 * price;
            }

            public void changeCount(int nCount)
            {
                this.count = nCount;
            }
        }

        public static Journal[] journals = new Journal[20];

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            journals[0] = new Journal("Одуванчик", 7, 100, rnd.Next(0, 1000));
            journals[1] = new Journal("Молодежный", 2, 150, rnd.Next(0, 1000));
            journals[2] = new Journal("Автолюбитель", 2, 120, rnd.Next(0, 1000));
            journals[3] = new Journal("Новости. Главное.", 7, 70, rnd.Next(0, 1000));
            journals[4] = new Journal("Личность", 1, 200, rnd.Next(0, 1000));
            journals[5] = new Journal("Первый игровой", 2, 150, rnd.Next(0, 1000));
            journals[6] = new Journal("Особый", 1, 125, rnd.Next(0, 1000));
            journals[7] = new Journal("Путешествия", 1, 100, rnd.Next(0, 1000));
            journals[8] = new Journal("Тайны мира", 1, 115, rnd.Next(0, 1000));
            journals[9] = new Journal("Военная тайна", 1, 115, rnd.Next(0, 1000));
            journals[10] = new Journal("Продажа", 1, 60, rnd.Next(0, 1000));
            journals[11] = new Journal("Экономический", 1, 75, rnd.Next(0, 1000));
            journals[12] = new Journal("Программирование", 4, 85, rnd.Next(0, 1000));
            journals[13] = new Journal("Техно", 1, 140, rnd.Next(0, 1000));
            journals[14] = new Journal("Зажигалка!", 3, 120, rnd.Next(0, 1000));
            journals[15] = new Journal("Рубрика недели", 5, 100, rnd.Next(0, 1000));
            journals[16] = new Journal("Новости мира", 7, 50, rnd.Next(0, 1000));
            journals[17] = new Journal("Публицист", 7, 50, rnd.Next(0, 1000));
            journals[18] = new Journal("Новости дня", 7, 50, rnd.Next(0, 1000));
            journals[19] = new Journal("Шоконтент!", 3, 75, rnd.Next(0, 1000));
            journals[13].changeCount(327);

            comboBox1.Items.Add("Все");
            comboBox1.Items.Add("Дешевле 100 рублей");
            comboBox1.Items.Add("Чаще раза в неделю");
            comboBox1.Items.Add("Менее 500 экземпляров");
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    cleanText();
                    for (int i = 0; i < journals.Length; i++)
                    {
                        richTextBox1.Text += string.Format("{0, -30}\t{1, -15}\t {2, -25}\t{3, -40}", journals[i].title, journals[i].period, journals[i].price, journals[i].count) + "\n\n";
                    }
                    break;
                case 1:
                    cleanText();
                    for (int i = 0; i < journals.Length; i++)
                    {
                        if (journals[i].price < 100)
                        {
                            richTextBox1.Text += string.Format("{0, -30}\t{1, -15}\t {2, -25}\t{3, -40}", journals[i].title, journals[i].period, journals[i].price, journals[i].count) + "\n\n";
                        }
                    }
                    break;
                case 2:
                    cleanText();
                    for (int i = 0; i < journals.Length; i++)
                    {
                        if (journals[i].period > 1)
                        {
                            richTextBox1.Text += string.Format("{0, -30}\t{1, -15}\t {2, -25}\t{3, -40}", journals[i].title, journals[i].period, journals[i].price, journals[i].count) + "\n\n";
                        }
                    }
                    break;
                case 3:
                    cleanText();
                    for (int i = 0; i < journals.Length; i++)
                    {
                        if (journals[i].count < 500)
                        {
                            richTextBox1.Text += string.Format("{0, -30}\t{1, -15}\t {2, -25}\t{3, -40}", journals[i].title, journals[i].period, journals[i].price, journals[i].count) + "\n\n";
                        }
                    }
                    break;
                default:
                    cleanText();
                    for (int i = 0; i < journals.Length; i++)
                    {
                        richTextBox1.Text += string.Format("{0, -30}\t{1, -15}\t {2, -25}\t{3, -40}", journals[i].title, journals[i].period, journals[i].price, journals[i].count) + "\n\n";
                    }
                    break;

            }
        }

        private void cleanText()
        {
            richTextBox1.Text = "";
            richTextBox1.Text += string.Format("{0, -20}\t{1, -20}\t {2, -15}\t{3, -40}", "Название", "Периодичность", "Стоимость", "Количество экземпляров") + "\n\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "Soft";
            string path = @"C:\Users\" + username + @"\Desktop\table.txt";
            FileStream fs = File.Create(path);
            Byte[] b_text = new UTF8Encoding(true).GetBytes(richTextBox1.Text);
            fs.Write(b_text, 0, b_text.Length);
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Array.Resize(ref journals, journals.Length + 1);
            if (!int.TryParse(textBox2.Text, out int period))
            {
                MessageBox.Show("Введите число в поле \"Периодичность\"");
            }
            if (!int.TryParse(textBox3.Text, out int price))
            {
                MessageBox.Show("Введите число в поле \"Цена\"");
            }
            if (!int.TryParse(textBox4.Text, out int count))
            {
                MessageBox.Show("Введите число в поле \"Всего выпущено\"");
            }
            journals[journals.Length - 1] = new Journal(textBox1.Text, period, price, count);
            richTextBox1.Text += string.Format("{0, -30}\t{1, -15}\t {2, -25}\t{3, -40}", textBox1.Text, period, price, count) + "\n\n";
        }
    }
}

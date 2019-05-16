using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.DataSource = goods;
        }

        public struct Good
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public int Price { get; set; }
        }

        public List<Good> goods = new List<Good>
        {
            new Good { Id=0, Title="Лопата", Price=100 },
            new Good { Id=1, Title="Грабли", Price=70 },
            new Good { Id=3, Title="Маленькая лопата", Price=50 },
            new Good { Id=4, Title="Горшок для цветка", Price=60 },
            new Good { Id=5, Title="Мешок", Price=20 },
            new Good { Id=6, Title="Клейкая лента", Price=35 },
            new Good { Id=7, Title="Ведро", Price=40 },
            new Good { Id=8, Title="Пленка защитная", Price=40 }
        };
        public double discount = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DisplayMember = "Title";
            listBox1.ValueMember = "Price";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                discount = 1;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox3.Checked = false;
                checkBox1.Checked = false;
                discount = 0.95;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                discount = 0.97;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked)
            {
                MessageBox.Show("Выберите способ оплаты!");
            } else
            {
                if (!int.TryParse(textBox1.Text, out int count))
                {
                    MessageBox.Show("Укажите корректное количество товара!");
                } else
                {
                    double price = int.Parse(listBox1.SelectedValue.ToString()) * int.Parse(textBox1.Text) * discount;
                    MessageBox.Show("Цена товара с учетом всех скидок и количества: " + price.ToString());
                }
            }
        }
    }
}

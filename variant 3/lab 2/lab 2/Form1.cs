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
            new Good { Id=0, Title="Лопата - 100р", Price=100 },
            new Good { Id=1, Title="Грабли - 70р", Price=70 },
            new Good { Id=3, Title="Маленькая лопата - 50р", Price=50 },
            new Good { Id=4, Title="Горшок для цветка - 60р", Price=60 },
            new Good { Id=5, Title="Мешок - 20р", Price=20 },
            new Good { Id=6, Title="Клейкая лента - 35р", Price=35 },
            new Good { Id=7, Title="Ведро - 40р", Price=40 },
            new Good { Id=8, Title="Пленка защитная - 40р", Price=40 }
        };
        public double discount = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DisplayMember = "Title";
            listBox1.ValueMember = "Price";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (discount == 0)
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            discount = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            discount = 0.95;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            discount = 0.97;
        }
    }
}

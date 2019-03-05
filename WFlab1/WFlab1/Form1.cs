using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFlab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Diff> diffs = new List<Diff>
            {
                 new Diff { Id=0, Name="Простые швы", Fac = 1.1 },
                 new Diff { Id=1, Name="Качественные швы", Fac = 1.3 }
            };

            listBox1.DataSource = diffs;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Id";

            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0;

            foreach (var product in productList.SelectedItems)
            {
                var priceStr = product.ToString();
                var dash = priceStr.LastIndexOf('-');
                var price = int.Parse(priceStr.Substring(dash + 1));
                sum += price;
            }
            Diff diff = (Diff)listBox1.SelectedItem;
            sum *= diff.Fac;
            if (checkBox1.Checked)
            {
                sum *= 1.1;
            }
            if (checkBox2.Checked)
            {
                sum += 150;
            }
            MessageBox.Show($"Заказ оформлен! Стоимость: {sum}.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
class Diff
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Fac { get; set; }
}
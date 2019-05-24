using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace lab6
{
    public partial class Form1 : Form
    {
        public static string connectString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Soft\Downloads\Алгоритмические языки и системы программирования\Лабораторная работа 6\Бытовая техника.mdb;";

        private OleDbConnection myConnection;

        public Form1()
        {
            InitializeComponent();

            myConnection = new OleDbConnection(connectString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "SELECT Продажи.[код чека], Продажи.дата, Продажи.товар, Ассортимент.фирма, Ассортимент.[базовая стоимость], [вид акций].[вид акции] " +
                "FROM [вид акций] INNER JOIN (([название товара] INNER JOIN Ассортимент ON [название товара].название = Ассортимент.название) INNER JOIN (акции INNER JOIN Продажи ON акции.код = Продажи.[код акции]) ON Ассортимент.код = Продажи.товар) ON [вид акций].код = акции.название_акции " +
                "ORDER BY [код чека]";
            setData(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Ассортимент WHERE Ассортимент.[базовая стоимость] > 5000";
            setData(query);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Ассортимент WHERE Ассортимент.[фирма] = 'Sumsung'";
            setData(query);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Продажи WHERE Продажи.[дата] BETWEEN #6/1/2011# AND #8/31/2017#";
            setData(query);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // string query = "SELECT * FROM [Продажи] INNER JOIN [Ассортимент] ON [Продажи].[код чека] = [Ассортимент].[код] WHERE ([код акции] = 7 OR [код акции] = 8) AND ([код чека] = 9 OR [код чека] = 43 OR [код чека] = 45 OR [код чека] = 57 OR [код чека] = 58)";
            // string query = "SELECT Продажи.[код чека], Продажи.дата, Ассортимент.название FROM Продажи INNER JOIN Ассортимент ON Продажи.[товар] = Ассортимент.код";
            string query = "SELECT Продажи.[код чека], Продажи.дата, Ассортимент.название, Продажи.[код акции] FROM Продажи INNER JOIN Ассортимент ON Продажи.[товар] = Ассортимент.код " +
                "WHERE ([код акции] = 7 OR [код акции] = 8) AND ([код чека] = 9 OR [код чека] = 43 OR [код чека] = 45 OR [код чека] = 57 OR [код чека] = 58)";
            // query = "SELECT акции.код, [вид акций].[вид акции] FROM [акции] INNER JOIN [вид акций] ON [акции].[название_акции] = [вид акций].[код]";
            setData(query);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Продажи WHERE Продажи.[код акции] > 0 AND Продажи.[код акции] < 7";
            setData(query);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string query = "SELECT Продажи.[код чека], Продажи.дата, Продажи.товар, Ассортимент.фирма, Ассортимент.[базовая стоимость], [вид акций].[вид акции] " +
                "FROM [вид акций] INNER JOIN (([название товара] INNER JOIN Ассортимент ON [название товара].название = Ассортимент.название) " +
                "INNER JOIN (акции INNER JOIN Продажи ON акции.код = Продажи.[код акции]) ON Ассортимент.код = Продажи.товар) ON [вид акций].код = акции.название_акции " +
                "WHERE Продажи.[код акции] = 4 OR Продажи.[код акции] = 1";
            setData(query);
            double giftPrice = 300;
            giftPrice *= getSelectionCount("Покупка+подарок", 5);
            textBox1.Text = giftPrice.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM [Ассортимент] WHERE [фирма] = 'Vitec'";
            setData(query);
            textBox1.Text = getSelectionCount("Vitec", 2).ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string query = "SELECT Продажи.[код чека], Продажи.дата, Продажи.товар, Ассортимент.фирма, Ассортимент.[базовая стоимость], [вид акций].[вид акции] " +
                "FROM [вид акций] INNER JOIN (([название товара] INNER JOIN Ассортимент ON [название товара].название = Ассортимент.название) INNER JOIN (акции INNER JOIN Продажи ON акции.код = Продажи.[код акции]) ON Ассортимент.код = Продажи.товар) ON [вид акций].код = акции.название_акции " +
                "ORDER BY [код чека]";
            setData(query);
        }

        public void setData(string query)
        {
            myConnection.Open();
            DataSet ds = new DataSet();
            new OleDbDataAdapter(query, myConnection).Fill(ds);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection.Close();
            textBox1.Text = "";
        }

        public int getSelectionCount(string parameter, int column)
        {
            if (dataGridView1.RowCount == 0)
            {
                return 0;
            }
            int result = 0;
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                if (dataGridView1[column, i].Value.ToString() == parameter)
                {
                    result++;
                }
            }
            return result;
        }
    }
}

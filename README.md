# CSharp_university
C#. Laboratory works for my University.
Example for SQL


        private OleDbConnection myConnection;
        string[] zapros;
        public Form1()
        {
            InitializeComponent();
            string connetionString = null;
            connetionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Хозтовары.mdb;Persist Security Info=True";
            myConnection = new OleDbConnection(connetionString);
            myConnection.Open();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            OleDbDataAdapter sdr = new OleDbDataAdapter("SELECT [Код_товара], Название, Количество, [Дата поступления], Цена, Фирма, Поставщик, Страна, Город, [Вид_доставки]FROM[Продажа хозтоваров]", myConnection);
            sdr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            OleDbDataAdapter sdr = new OleDbDataAdapter("SELECT [Код_товара], Название, Количество, [Дата поступления], Цена, Фирма, Поставщик, Страна, Город, [Вид_доставки]FROM[Продажа хозтоваров]WHERE([Вид_доставки] = 'авто')", myConnection);
            sdr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            OleDbDataAdapter sdr = new OleDbDataAdapter("SELECT [Код_товара], Название, Количество, [Дата поступления], Цена, Фирма, Поставщик, Страна, Город, [Вид_доставки]FROM[Продажа хозтоваров]WHERE(Страна = 'Италия')", myConnection);
            sdr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            OleDbDataAdapter sdr = new OleDbDataAdapter("SELECT [Код_товара], Название, Количество, [Дата поступления], Цена, Фирма, Поставщик, Страна, Город, [Вид_доставки]FROM[Продажа хозтоваров]WHERE([Дата поступления] BETWEEN #9/1/2012# AND #9/30/2012#)", myConnection);
            sdr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            OleDbDataAdapter sdr = new OleDbDataAdapter("SELECT [Код_товара], Название, Количество, [Дата поступления], Цена, Фирма, Поставщик, Страна, Город, [Вид_доставки]FROM[Продажа хозтоваров]WHERE(Количество > 20) AND(Фирма = 'philips')", myConnection);
            sdr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            OleDbDataAdapter sdr = new OleDbDataAdapter("SELECT SUM([Цена]) / COUNT(*) AS Итоговаятоимость FROM[Продажа хозтоваров]", myConnection);
            sdr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            OleDbDataAdapter sdr = new OleDbDataAdapter("SELECT COUNT(*) AS Количество, Вид_Доставки FROM[Продажа хозтоваров] GROUP BY Вид_Доставки HAVING(Вид_Доставки = 'ж/д')", myConnection);
            sdr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }

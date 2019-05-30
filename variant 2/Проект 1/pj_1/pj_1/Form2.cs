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

namespace pj_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            nowHide();
        }

        private List<River> _Rivers = new List<River>();

        private string dirPath = "";
        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("one", "Номер");
            dataGridView1.Columns.Add("two", "Название реки");
            dataGridView1.Columns.Add("three", "Протяженность (км)");
            dataGridView1.Columns.Add("four", "Протяженность в России (км)");
            dataGridView1.Columns.Add("five", "Площадь бассейна (тыс. км^2)");
            dataGridView1.Columns.Add("six", "Расход воды м^3/с");
            dataGridView1.Columns.Add("seven", "Впадает в...");
            River r;
            string[] path = Environment.CurrentDirectory.ToString().Split('\\');

            for (int i = 0; i < 5; i++)
            {
                dirPath += path[i] + "/";
            }
            string[] read = File.ReadAllLines(dirPath + "files/Данные.txt");
            for (var i = 0; i < read.Length; i++)
            {
                string[] s = read[i].Split(';');
                r.number = int.Parse(s[0]);
                r.title = s[1];
                r.extent = int.Parse(s[2]);
                r.extentRussia = int.Parse(s[3]);
                r.poolArea = int.Parse(s[4]);
                r.waterFlow = double.Parse(s[5]);
                r.flowsInto = s[6];
                _Rivers.Add(r);
            }
            refresh();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Image picture = Image.FromFile(dirPath + "files/images/default.jpg");
            pictureBox1.Image = picture;
            comboBox1.Text = "Столбец...";
            textBox9.Text = "Параметры поиска...";
        }

        private struct River
        {
            public int number;
            public int extent;
            public int extentRussia;
            public int poolArea;
            public double waterFlow;
            public string title;
            public string flowsInto;

            public River(int number, string title, int extent, int extentRussia, int poolArea, double waterFlow, string flowsInto)
            {
                this.number = number;
                this.title = title;
                this.extent = extent;
                this.extentRussia = extentRussia;
                this.poolArea = poolArea;
                this.waterFlow = waterFlow;
                this.flowsInto = flowsInto;
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox1.Text == "1234")
            {
                nowShow();
            } else
            {
                nowHide();
            }
        }

        private void Form2_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void nowHide()
        {
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            textBox8.Hide();
            button4.Hide();
            textBox2.Hide();
            button3.Hide();
            button1.Hide();
        }
        
        private void nowShow()
        {
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Show();
            label8.Show();
            textBox3.Show();
            textBox4.Show();
            textBox5.Show();
            textBox2.Show();
            textBox6.Show();
            label2.Show();
            textBox7.Show();
            textBox8.Show();
            button3.Show();
            button4.Show();
            button1.Show();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            string num = "0";
            try
            {
                num = dataGridView1[0, e.RowIndex].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Выберите другую ячейку!");
            }
            if (int.Parse(num) > 0 && int.Parse(num) < 21)
            {
                string ext = "jpg";
                if (int.Parse(num) == 14 || int.Parse(num) == 15)
                {
                    ext = "jfif";
                } else if (int.Parse(num) == 20)
                {
                    ext = "jpeg";
                } else
                {
                    ext = "jpg";
                }
                Image picture = Image.FromFile(dirPath + $"files/images/{num}.{ext}");
                pictureBox1.Image = picture;
            } else
            {
                Image picture = Image.FromFile(dirPath + $"files/images/default.jpg");
                pictureBox1.Image = picture;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var text = comboBox1.Text;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    /* LINQ */
                    var sel = from river in _Rivers
                              select river;
                    dataGridView1.Rows.Clear();
                    foreach (var elem in sel)
                    {
                        setAllFieldsRiver(elem);
                    }
                    break;
                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string myPath = dirPath + "files/Save.txt";
            bool error = false;
            try
            {
                writeAll(myPath);
            }
            catch
            {
                MessageBox.Show("Возникла непредвиденная ошибка при попытке записи в файл!");
                error = true;
            }
            finally
            {
                if (!error)
                {
                    MessageBox.Show("Данные записаны в файл: " + myPath);
                }
                error = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = _Rivers.Count + 1;
            try
            {
                River myNewRiver = new River(count, textBox3.Text, int.Parse(textBox4.Text),
                int.Parse(textBox5.Text), int.Parse(textBox6.Text), double.Parse(textBox7.Text), textBox8.Text);
                _Rivers.Add(myNewRiver);
                dataGridView1.Rows.Add(myNewRiver.number, myNewRiver.title, myNewRiver.extent, myNewRiver.extentRussia, myNewRiver.poolArea, myNewRiver.waterFlow, myNewRiver.flowsInto);
            }
            catch
            {
                MessageBox.Show("Некорректный ввод данных!");
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
            }
            finally
            {
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
            }
        }

        private void setAllFieldsRiver(River myNewRiver)
        {
            dataGridView1.Rows.Add(myNewRiver.number, myNewRiver.title, myNewRiver.extent, myNewRiver.extentRussia, myNewRiver.poolArea, myNewRiver.waterFlow, myNewRiver.flowsInto);
        }

        private void refresh()
        {
            dataGridView1.Rows.Clear();
            foreach (var river in _Rivers)
            {
                dataGridView1.Rows.Add(river.number.ToString(), river.title, river.extent.ToString(),
                    river.extentRussia.ToString(), river.poolArea.ToString(), river.waterFlow.ToString(), river.flowsInto);
            }
        }

        private void writeAll(string filePath)
        {
            StreamWriter go = new StreamWriter(filePath);

            for (int row = 0; row < dataGridView1.Rows.Count - 1; row++)
            {
                go.WriteLine("Номер:            " + dataGridView1[0, row].Value);
                go.WriteLine("Название:         " + dataGridView1[1, row].Value);
                go.WriteLine("Длина км:         " + dataGridView1[2, row].Value);
                go.WriteLine("Длина в РФ км:    " + dataGridView1[3, row].Value);
                go.WriteLine("Площадь бассейна: " + dataGridView1[4, row].Value);
                go.WriteLine("Расход воды:      " + dataGridView1[5, row].Value);
                go.WriteLine("Впадает:          " + dataGridView1[6, row].Value);
                go.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            }
            string date = DateTime.Now.ToString();
            go.Write("\nДата сохранения: " + date);
            go.Close();
        }

        private void saveChanges(string filePath)
        {
            StreamWriter go = new StreamWriter(filePath);

            for (int i = 0; i < _Rivers.Count; i++)
            {
                var river = _Rivers[i];
                go.WriteLine(river.number.ToString() + ";" + river.title + ";" + river.extent.ToString() + ";" + river.extentRussia.ToString() + ";" +
                    river.poolArea.ToString() + ";" + river.waterFlow.ToString() + ";" + river.flowsInto + ";");
            }
            go.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myPath = dirPath + "files/Данные.txt";
            try
            {
                saveChanges(myPath);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при попытке сохранить :С");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox2.Text, out int index);
            try
            {
                _Rivers.RemoveAt(index - 1);

            }
            catch
            {
                MessageBox.Show("Во время удаления произошла ошибка!");
            }
            textBox2.Text = "";
            refresh();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            
        }

        public bool clicked = false;
        private void textBox9_Click(object sender, EventArgs e)
        {
            if (!clicked)
            {
                clicked = true;
                textBox9.Text = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string text = textBox9.Text;
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    /* LINQ */
                    var sel = from river in _Rivers
                              where river.title.Contains(text)
                              select river;
                    dataGridView1.Rows.Clear();
                    foreach (var elem in sel)
                    {
                        setAllFieldsRiver(elem);
                    }
                    break;
                case 2:
                    /* LINQ */
                    try
                    {
                        var sel1 = from river in _Rivers
                                   where river.extent > int.Parse(text)
                                   select river;
                        dataGridView1.Rows.Clear();
                        foreach (var elem in sel1)
                        {
                            setAllFieldsRiver(elem);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Введите корректный текст!");
                    }
                    break;
                case 3:
                    /* LINQ */
                    var sel2 = from river in _Rivers
                               where river.flowsInto.Contains(text)
                               select river;
                    dataGridView1.Rows.Clear();
                    foreach (var elem in sel2)
                    {
                        setAllFieldsRiver(elem);
                    }
                    break;
                default: break;
            }
        }
    }
}

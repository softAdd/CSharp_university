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

namespace WF2
{
    public partial class Form1 : Form
    {
        public static Student[] students = new Student[20];
        public static List<Student> addedStudents = new List<Student>();
        public Form1()
        {
            InitializeComponent();

            label1.Text = "Добавить студента (Имя, Группа, Дата рождения,\n Оценки: физика, математика, информатика)";
            students[0] = new Student("Евсей", "ОЭ-102", DateTime.Parse("1999.1.6"), 5, 5, 5);
            students[1] = new Student("Парфен", "ОЭ-203", DateTime.Parse("1998.12.7"), 3, 3, 3);
            students[2] = new Student("Назар", "ИТ-201", DateTime.Parse("1997.1.1"), 3, 4, 5);
            students[3] = new Student("Артемий", "ИП-132", DateTime.Parse("1999.3.22"), 4, 4, 4);
            students[4] = new Student("Эрнст", "ИТ-201", DateTime.Parse("1995.1.21"), 5, 4, 5);
            students[5] = new Student("Леондий", "ИТм-205", DateTime.Parse("1999.3.5"), 5, 4, 5);
            students[6] = new Student("Агап", "ИТм-205", DateTime.Parse("2000.9.9"), 5, 4, 4);
            students[7] = new Student("Макар", "РЭ-102", DateTime.Parse("1999.2.2"), 5, 4, 5);
            students[8] = new Student("Афанасий", "РЭ-201", DateTime.Parse("1997.2.3"), 4, 5, 5);
            students[9] = new Student("Викентий", "ИТм-204", DateTime.Parse("1999.6.8"), 5, 5, 5);
            students[10] = new Student("Злата", "ИТ-203", DateTime.Parse("2000.11.23"), 5, 5, 5);
            students[11] = new Student("Антонина", "ИТ-201", DateTime.Parse("1999.3.23"), 3, 4, 5);
            students[12] = new Student("Майя", "ПТ-202", DateTime.Parse("1999.2.2"), 5, 4, 3);
            students[13] = new Student("Валентина", "ОЭ-203", DateTime.Parse("1999.11.28"), 5, 5, 5);
            students[14] = new Student("Ульяна", "ОЭ-203", DateTime.Parse("1999.6.23"), 4, 4, 5);
            students[15] = new Student("Лидия", "ИТм-205", DateTime.Parse("1999.11.23"), 5, 4, 5);
            students[16] = new Student("Ника", "РЭ-102", DateTime.Parse("2000.7.22"), 5, 4, 3);
            students[17] = new Student("Ариадна", "ИТ-201", DateTime.Parse("1999.11.17"), 3, 4, 3);
            students[18] = new Student("Юлия", "РЭ-201", DateTime.Parse("1998.9.16"), 3, 3, 3);
            students[19] = new Student("Анисья", "ОЭ-203", DateTime.Parse("1999.11.11"), 4, 4, 5);

            comboBox1.Items.Add("Все");
            comboBox1.Items.Add("Есть стипендия");
            comboBox1.Items.Add("Старше 18 лет");
            comboBox1.Items.Add("Добавленные");
            comboBox1.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public struct Student
        {
            public string name;
            public string group;
            public DateTime dateBirthDay;
            public int physMark;
            public int mathMark;
            public int infoMark;

            public Student(string name, string group, DateTime dateBirthDay, int physMark, int mathMark, int infoMark)
            {
                this.name = name;
                this.group = group;
                this.dateBirthDay = dateBirthDay;
                this.physMark = physMark;
                this.mathMark = mathMark;
                this.infoMark = infoMark;
            }

            public int getAge(DateTime dateBirthDay)
            {
                DateTime dateNow = DateTime.Now;
                int year = dateNow.Year - dateBirthDay.Year;
                if (dateNow.Month < dateBirthDay.Month ||
                (dateNow.Month == dateBirthDay.Month && dateNow.Day < dateBirthDay.Day)) year--;
                return year;
            }
            public double getScholar(int physMark, int mathMark, int infoMark)
            {
                if (physMark <= 3 || mathMark <= 3 || infoMark <= 3)
                {
                    return 0;
                }
                double currentScholar = 1300;
                double coefficient = (double)(physMark + mathMark + infoMark / 3) / 10 + 1;
                currentScholar *= coefficient;
                return currentScholar;
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var words = richTextBox2.Text.Split(' ');
            if (words.Length == 6)
            {
                Array.Resize(ref students, students.Length + 1);
                var size = students.Length - 1;
                var stud = new Student(words[0], words[1], DateTime.Parse(words[2]), int.Parse(words[3]), int.Parse(words[4]), int.Parse(words[5]));
                students[size] = stud;
                var name = students[size].name;
                var group = students[size].group;
                var scholar = students[size].getScholar(students[size - 1].physMark, students[size].mathMark, students[size].infoMark);
                var text = string.Format("{0, -20}\t{1, -20}\t {2, -15}\t{3, -40}", name, group, DateTime.Parse(words[2]).ToShortDateString(), scholar);
                addedStudents.Add(stud);
                richTextBox1.Text += text;
                richTextBox2.Text = "";
            } else
            {
                richTextBox2.Text = "";
                MessageBox.Show("Введены неверные данные");
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            var path = @"C:\Users\Soft\Desktop\table.txt";
            FileStream fs = File.Create(path);
            Byte[] b_text = new UTF8Encoding(true).GetBytes(richTextBox1.Text);
            fs.Write(b_text, 0, b_text.Length);
            fs.Close();
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    richTextBox1.Text = "";
                    richTextBox1.Text += string.Format("{0, -20}\t{1, -20}\t {2, -15}\t{3, -40}", "Имя", "Группа", "Дата рождения", "Стипендия") + "\n\n";
                    for (int i = 0; i < students.Length; i++)
                    {
                        var name = students[i].name;
                        var group = students[i].group;
                        var scholar = students[i].getScholar(students[i].physMark, students[i].mathMark, students[i].infoMark);
                        var text = string.Format("{0, -20}\t{1, -20}\t {2, -15}\t{3, -40}", name, group, students[i].dateBirthDay.ToShortDateString(), scholar);
                        richTextBox1.Text += text + "\n";
                    }
                    break;
                case 1:
                    richTextBox1.Text = "";
                    richTextBox1.Text += string.Format("{0, -20}\t{1, -20}\t {2, -15}\t{3, -40}", "Имя", "Группа", "Дата рождения", "Стипендия") + "\n\n";
                    for (int i = 0; i < students.Length; i++)
                    {
                        var scholar = students[i].getScholar(students[i].physMark, students[i].mathMark, students[i].infoMark);
                        if (scholar != 0)
                        {
                            var name = students[i].name;
                            var group = students[i].group;
                            var text = string.Format("{0, -20}\t{1, -20}\t {2, -15}\t{3, -40}", name, group, students[i].dateBirthDay.ToShortDateString(), scholar);
                            richTextBox1.Text += text + "\n";
                        }
                    }
                    break;
                case 2:
                    richTextBox1.Text = "";
                    richTextBox1.Text += string.Format("{0, -20}\t{1, -20}", "Имя", "Возраст") + "\n\n";
                    for (int i = 0; i < students.Length; i++)
                    {
                        if (students[i].getAge(students[i].dateBirthDay) >= 19)
                        {
                            var elem = students[i].name + " - " + students[i].getAge(students[i].dateBirthDay) + " лет";
                            var text = string.Format("{0, -20}\t{1, -20}", students[i].name, students[i].getAge(students[i].dateBirthDay));
                            richTextBox1.Text += text + "\n";
                        }
                    }
                    break;
                case 3:
                    richTextBox1.Text = "";
                    richTextBox1.Text += string.Format("{0, -20}\t{1, -20}\t {2, -15}\t{3, -40}", "Имя", "Группа", "Дата рождения", "Стипендия") + "\n\n";
                    for (int i = 0; i < addedStudents.Count; i++)
                    {
                        var name = addedStudents[i].name;
                        var group = addedStudents[i].group;
                        var scholar = addedStudents[i].getScholar(addedStudents[i].physMark, addedStudents[i].mathMark, addedStudents[i].infoMark);
                        var text = string.Format("{0, -20}\t{1, -20}\t {2, -15}\t{3, -40}", name, group, addedStudents[i].dateBirthDay.ToShortDateString(), scholar);
                        richTextBox1.Text += text + "\n";
                    }
                    break;
                default:
                    richTextBox1.Text = "";
                    richTextBox1.Text += string.Format("{0, -20}\t{1, -20}\t {2, -15}\t{3, -40}", "Имя", "Группа", "Дата рождения", "Стипендия") + "\n\n";
                    for (int i = 0; i < students.Length; i++)
                    {
                        var name = students[i].name;
                        var group = students[i].group;
                        var scholar = students[i].getScholar(students[i].physMark, students[i].mathMark, students[i].infoMark);
                        var text = string.Format("{0, -20}\t{1, -20}\t {2, -15}\t{3, -40}", name, group, students[i].dateBirthDay.ToShortDateString(), scholar);
                        richTextBox1.Text += text + "\n";
                    }
                    break;
            }
        }
    }
}

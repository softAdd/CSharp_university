using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF2
{
    public partial class Form1 : Form
    {
        public static Student[] students = new Student[20];
        public Form1()
        {
            InitializeComponent();

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

            richTextBox1.Text += string.Format("{0, -20}\t{1, -20}\t {2, -15}\t{3, -40}", "Имя", "Группа", "Возраст", "Стипендия") + "\n\n";
            for (int i = 0; i < students.Length; i++)
            {
                var name = students[i].name;
                var group = students[i].group;
                var age = students[i].getAge(students[i].dateBirthDay);
                var scholar = students[i].getScholar(students[i].physMark, students[i].mathMark, students[i].infoMark);
                var text = string.Format("{0, -20}\t{1, -20}\t {2, -15}\t{3, -40}", name, group, age, scholar);
                richTextBox1.Text += text + "\n";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        struct Student
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
    }
}

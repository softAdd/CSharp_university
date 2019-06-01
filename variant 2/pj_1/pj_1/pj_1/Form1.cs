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
using System.Drawing;
using System.Drawing.Drawing2D;

namespace pj_1
{
    public partial class Form1 : Form
    {
        private string dirPath = "";
        public Form1()
        {
            InitializeComponent();
            this.timer1.Enabled = true;
            this.timer1.Interval = 70;
            string[] path = Environment.CurrentDirectory.ToString().Split('\\');
  
            for (int i = 0; i < 5; i++)
            {
                dirPath += path[i] + "/";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 900;
            this.Height = 850;
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            // создаем эллипс с высотой и шириной формы
            myPath.AddEllipse(0, 0, this.Width, this.Height);
            // создаем с помощью элипса ту область формы, которую мы хотим видеть
            Region myRegion = new Region(myPath);
            // устанавливаем видимую область
            this.Region = myRegion;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity - 0.01;
            if (this.Opacity <= 0.6)
            {
                this.timer1.Interval = 5;
            }
            if (this.Opacity <= 0)
            {
                Form2 f = new Form2();
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Height = 850;
                f.Width = 900;
                f.Show();
                this.timer1.Enabled = false;
                this.Hide();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Image ScreenSaver = Image.FromFile(dirPath + "files/заставка.jpg");
            Graphics g = e.Graphics;
            Rectangle background = new Rectangle(0, 0, 900, 850);
            e.Graphics.DrawImage(ScreenSaver, background);
            g.Dispose();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}

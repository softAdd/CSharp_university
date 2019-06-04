using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_5
{
    public partial class Form1 : Form
    {
        Graphics g;
        public int x, y;
        public bool moon = false, sun = false;

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            this.BackColor = Color.GhostWhite;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            if (e.Button == MouseButtons.Left && ModifierKeys == Keys.Shift)
            {
                moon = true;
                sun = false;
                draw();
            } else
            {
                moon = false;
                sun = true;
                draw();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            int TL = 150;
            int X = 0;
            int Y = 0;
            Random R = new Random();
            Bitmap BM = new Bitmap(this.Width, this.Height);
            Graphics G = Graphics.FromImage(BM);
            System.Drawing.Drawing2D.LinearGradientBrush grad = new System.Drawing.Drawing2D.LinearGradientBrush(new Rectangle(0, 0, this.Width, this.Height), Color.Blue, Color.Aqua, System.Drawing.Drawing2D.LinearGradientMode.Vertical);
            G.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            G.FillRectangle(grad, new Rectangle(0, 0, this.Width, this.Height));
            for (float I = 0; I <= 360; I += 0.9F)
            {
                X = Convert.ToInt32(Math.Cos(I) * 100 * R.Next(0, 6) + TL);
                Y = Convert.ToInt32(Math.Sin(I) * 100 * R.Next(0, 6) + TL);
                G.DrawLine(Pens.Yellow, X, Y, TL, TL);
            }
            G.FillEllipse(Brushes.Yellow, new Rectangle(TL / 2, TL / 2, TL, TL));
            this.BackgroundImage = BM;
            */
        }

        private void draw()
        {
            if (sun)
            {
                g.FillEllipse(Brushes.Yellow, new Rectangle(x - 30, y - 30, 60, 60));
                Random R = new Random();
                for (int i = 0; i < 450; i += 40)
                {
                    g.DrawLine(Pens.Yellow, 800, i, x, y);
                }
                for (int i = 0; i < 450; i += 40)
                {
                    g.DrawLine(Pens.Yellow, 0, i, x, y);
                }
                for (int i = 0; i < 800; i += 40)
                {
                    g.DrawLine(Pens.Yellow, i, 0, x, y);
                }
                for (int i = 0; i < 800; i += 40)
                {
                    g.DrawLine(Pens.Yellow, i, 450, x, y);
                }
            }
            if (moon)
            {
                // <------------- МЕСЯЦ ----------->
                Pen pen = new Pen(Color.LightBlue, 10);
                g.DrawArc(pen, x, y - 40, 75, 80, 90, 180);
                g.DrawArc(pen, x + 30, y - 40, 20, 80, 90, 180);

                /* <------------- ПОЛНАЯ ЛУНА ---------->
                Brush brush = new SolidBrush(Color.LightBlue);
                g.FillEllipse(brush, new Rectangle(x + 30, y - 30, 60, 60));
                brush.Dispose();
                */
            }
        }
    }
}

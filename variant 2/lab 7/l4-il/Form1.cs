using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace l4_il
{
    public partial class Form1 : Form
    {
        Graphics g;
        Color c = Color.Black;
        float w = 2;

        public Form1()
        {
            InitializeComponent();
        }

        private void толщинаЛинииToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e) //сетка
        {
            g = panel1.CreateGraphics();

            g.TranslateTransform(210, 210);
            g.RotateTransform(180f);

            Pen pen = new Pen(c, w);
            Pen grid = new Pen(Color.Bisque, 0.1f);

            int x = -200;
            int y = -200;
            while (x <= 200)
            {
                x = x + 10;
                y = y + 10;

                g.DrawLine(grid, new Point(x, -200), new Point(x, 200));
                g.DrawLine(grid, new Point(-200, y), new Point(200, y));
            }

        }

        private void осиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen green = new Pen(Color.Green, 2f);
            g.DrawLine(green, new Point(-200, 0), new Point(200, 0));
            g.DrawLine(green, new Point(0, -200), new Point(0, 200));
        }

        private void прямаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(c, w);
            g.DrawLine(pen, new Point(-200, 50), new Point(200, -50));
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void зеленыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c = Color.Green;
        }

        private void синийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c = Color.CornflowerBlue;
        }

        private void черныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c = Color.Black;
        }

        private void тонкаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w = 1;
        }

        private void средняяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w = 2;
        }

        private void утолщеннаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w = 4;
        }

        private void параболаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(c, w);
            List<Point> p = new List<Point>();

            int x = -200;
            double y;

            while (x <= 200)
            {
                y = 0.2 * x * x;
                x++;

                Point poss = new Point(x, Convert.ToInt32(y));
                p.Add(poss);
            }

            g.DrawCurve(pen, p.ToArray());
        }

        private void гиперболаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(c, w);
            List<Point> p = new List<Point>();

            int x = -200;
            int y;

            while (x <= -1)
            {
                y = -210 / (x);
                x++;

                Point poss = new Point(x, y);
                p.Add(poss);
            }

            g.DrawCurve(pen, p.ToArray());

            x = 1;
            while (x <= 200)
            {
                y = -210 / (x);
                x++;

                Point poss = new Point(x, y);
                p.Add(poss);
            }

            g.DrawCurve(pen, p.ToArray());
        }

        private void синусоидаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(c, w);
            List<Point> p = new List<Point>();

            double x = -220;
            double y = 0;

            while (x <= 200)
            {
                y = 160 * Math.Sin(x);
                x = x + 20;

                Point poss = new Point((int)x, (int)y);
                p.Add(poss);
            }

            g.DrawCurve(pen, p.ToArray());
        }

        private void желтыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c = Color.Yellow;
        }

        private void кардиоидаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Point> p = new List<Point>();
            for (int i = 0; i < 360; i++)
            {
                // радиусы в радианы
                var angle = 6.28 * i / 360.0;
                var xx = 50 * Math.Cos(angle) - 50 * Math.Sin(angle) * Math.Cos(angle);
                var yy = 50 * Math.Sin(angle) - 50 * Math.Sin(angle) * Math.Sin(angle);
                p.Add(new Point((int)xx, (int)yy));
            }
            Pen test = new Pen(c, w);
            g.DrawCurve(test, p.ToArray());
        }
    }
}
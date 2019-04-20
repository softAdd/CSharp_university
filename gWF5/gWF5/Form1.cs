using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gWF5
{
    public partial class Form1 : Form
    {
        Graphics g;
        public int x, y;
        public bool mushroom = false, tree = false;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void draw()
        {
            if (mushroom)
            {
                Brush brush = new SolidBrush(Color.Orange);
                RectangleF foot = new RectangleF(new PointF(x + 15, y + 25), new SizeF(20.0F, 25.0F));
                g.FillPie(brush, x, y, 50, 50, 180f, 180f);
                brush = new SolidBrush(Color.Brown);
                g.FillRectangle(brush, foot);
                brush.Dispose();
            }
            if (tree)
            {
                Pen pen = new Pen(Color.Black);
                Brush brush = new SolidBrush(Color.Green);
                PointF[] treeFoliage = new PointF[3];
                treeFoliage[0] = new PointF(x, y);
                treeFoliage[1] = new PointF(x + 70, y - 150);
                treeFoliage[2] = new PointF(x + 140, y);
                g.FillPolygon(brush, treeFoliage);
                g.DrawLines(pen, treeFoliage);
                RectangleF foot = new RectangleF(new PointF(x + 50, y), new SizeF(35.0F, 35.0F));
                brush = new SolidBrush(Color.Brown);
                g.FillRectangle(brush, foot);
                brush.Dispose();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;

            if (e.Button == MouseButtons.Left)
            {
                tree = true;
                mushroom = false;
                draw();
            }
            if (e.Button == MouseButtons.Right)
            {
                tree = false;
                mushroom = true;
                draw();
            }
        }
    }
}

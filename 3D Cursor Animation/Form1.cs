using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3D_Cursor_Animation
{
    public partial class Form1 : Form
    {
        private static Graphics formGraphics;
        private static Color col = Color.Red;
        private static int strength;
        private static Stopwatch sw;

        public Form1()
        {
            InitializeComponent();

            formGraphics = this.panel1.CreateGraphics();
            strength = 3;
            sw = new Stopwatch();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Point point = panel1.PointToClient(Cursor.Position);

            curX.Text = "Cursor X: " + point.X;
            curY.Text = "Cursor Y: " + point.Y;

            if (e.Button == MouseButtons.Left)
            {
                formGraphics.FillRectangle(new SolidBrush(col), new Rectangle(point.X, point.Y - strength, strength, strength));
                formGraphics.FillRectangle(new SolidBrush(col), new Rectangle(point.X, point.Y + strength, strength, strength));

                formGraphics.FillRectangle(new SolidBrush(col), new Rectangle(point.X - strength, point.Y, strength, strength));
                formGraphics.FillRectangle(new SolidBrush(col), new Rectangle(point.X + strength , point.Y, strength, strength));

                formGraphics.FillRectangle(new SolidBrush(col), new Rectangle(point.X, point.Y - strength, strength, strength));
                formGraphics.FillRectangle(new SolidBrush(col), new Rectangle(point.X, point.Y + strength, strength, strength));

                formGraphics.FillRectangle(new SolidBrush(col), new Rectangle(point.X - strength, point.Y + strength, strength, strength));
                formGraphics.FillRectangle(new SolidBrush(col), new Rectangle(point.X + strength, point.Y - strength, strength, strength));

                formGraphics.FillRectangle(new SolidBrush(col), new Rectangle(point.X + strength, point.Y + strength, strength, strength));
                formGraphics.FillRectangle(new SolidBrush(col), new Rectangle(point.X - strength, point.Y - strength, strength, strength));

                formGraphics.FillRectangle(new SolidBrush(col), new Rectangle(point.X + strength, point.Y - strength, strength, strength));
                formGraphics.FillRectangle(new SolidBrush(col), new Rectangle(point.X + strength, point.Y - strength, strength, strength));

                formGraphics.FillRectangle(new SolidBrush(col), new Rectangle(point.X - strength, point.Y + strength, strength, strength));
                formGraphics.FillRectangle(new SolidBrush(col), new Rectangle(point.X - strength, point.Y + strength, strength, strength));

            }
        }

        private void button1_Click(object sender, EventArgs e) => formGraphics.Clear(Color.Gainsboro);

        private void Form1_ResizeEnd(object sender, EventArgs e) => formGraphics = this.panel1.CreateGraphics();

        private void Form1_DoubleClick(object sender, EventArgs e) => formGraphics = this.panel1.CreateGraphics();

        private void addStrengthBtn_Click(object sender, EventArgs e)
        {
            strength++;
            str.Text = "Strength: " + strength;
        }

        private void removeStrengthBtn_Click(object sender, EventArgs e)
        {
            strength--;
            str.Text = "Strength: " + strength;
        }

        private void AddStrengthBtn_MouseDown(object sender, EventArgs e) 
        {
            sw.Start();
        }


        private void AddStrengthBtn_MouseUp(object sender, EventArgs e)
        {
            sw.Stop();
            if (sw.ElapsedMilliseconds <= 700 && sw.ElapsedMilliseconds >= 200)
            {
                strength += 10;
                str.Text = "Strength: " + strength;
            }
            sw.Reset();
        }
    }
}

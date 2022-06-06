using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public Form1()
        {
            InitializeComponent();

            formGraphics = this.panel1.CreateGraphics();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Point point = panel1.PointToClient(Cursor.Position);

            curX.Text = "Cursor X: " + point.X;
            curY.Text = "Cursor Y: " + point.Y;

            if (e.Button == MouseButtons.Left)
            {
                formGraphics.FillRectangle(new SolidBrush(col), new Rectangle(point.X - 1, point.Y, 3, 3));
                formGraphics.FillRectangle(new SolidBrush(col), new Rectangle(point.X + 1 , point.Y, 3, 3));

                formGraphics.FillRectangle(new SolidBrush(col), new Rectangle(point.X, point.Y - 1, 3, 3));
                formGraphics.FillRectangle(new SolidBrush(col), new Rectangle(point.X, point.Y + 1, 3, 3));

                formGraphics.FillRectangle(new SolidBrush(col), new Rectangle(point.X - 1, point.Y + 1, 3, 3));
                formGraphics.FillRectangle(new SolidBrush(col), new Rectangle(point.X + 1, point.Y - 1, 3, 3));

                formGraphics.FillRectangle(new SolidBrush(col), new Rectangle(point.X + 1, point.Y + 1, 3, 3));
                formGraphics.FillRectangle(new SolidBrush(col), new Rectangle(point.X - 1, point.Y - 1, 3, 3));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formGraphics.Clear(Color.Gainsboro);
        }
    }
}

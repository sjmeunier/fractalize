using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace FractalDraw
{
    public partial class Bifurcation : UserControl
    {
        private StatusStrip statusStrip1 = null;

        public Bifurcation()
        {
            InitializeComponent();
        }

        private void picFractal_Click(object sender, EventArgs e)
        {

        }

        public Image GetImage()
        {
            return picFractal.Image;
        }

        private void Bifurcation_Load(object sender, EventArgs e)
        {
        }

        public void DrawBifurcation(double r, double delta_r, Color oColor)
        {
            picFractal.Image = DrawBifurcationImage(r, delta_r, oColor, picFractal.Width, picFractal.Height);
        }

        public Bitmap DrawBifurcationImage(double r, double delta_r, Color oColor, int iWidth, int iHeight)
        {
            Bitmap oImage = new Bitmap(iWidth, iHeight);

            Graphics g = Graphics.FromImage(oImage);

            Generate(g, r, delta_r, iWidth, iHeight, oColor);
            return oImage;
        }

        public void Generate(Graphics g, double r, double delta_r, int iWidth, int iHeight, Color oColor)
        {
            double x;
            int i;
            int row, col;
            SolidBrush oPen = new SolidBrush(oColor);


            for (col = 0; col < iWidth; col++)
            {
                x = 0.5;
                r = r + delta_r;
                i = 0;
                do
                {
                    x = r * x * (1 - x);
                    row = (int)Math.Round((double)iHeight - ((x / r) * ((double)iHeight * 2)));

                    if (i > 64)
                    {
                        if (row < iHeight)
                        {
                            if (row >= 0)
                            {
                                if (col >= 0)
                                {
                                    if (col < iWidth)
                                    {
                                        g.FillRectangle(oPen, col, row, 1, 1);
                                    }
                                }
                            }
                        }
                    }
                    i++;
                } while ((x <= 1000) && (x >= -1000) && (i <= 255));
            }
        }

        private void Bifurcation_MouseLeave(object sender, EventArgs e)
        {

        }

        private void UpdateStatus(int index, string message)
        {
            if (statusStrip1 != null)
            {
                statusStrip1.Items[index].Text = message;
            }
        }

        public void SetStatusStrip(ref StatusStrip statusStripRef)
        {
            statusStrip1 = statusStripRef;
        }

        private void Bifurcation_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void picFractal_MouseMove(object sender, MouseEventArgs e)
        {
            UpdateStatus(0, "(" + e.X.ToString() + "," + e.Y.ToString() + ")");

        }

        private void picFractal_MouseUp(object sender, MouseEventArgs e)
        {
         

        }

        private void picFractal_MouseLeave(object sender, EventArgs e)
        {
            UpdateStatus(0, "");
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace FractalDraw
{
    public partial class TSquare : UserControl
    {
        private StatusStrip statusStrip1 = null;

        public TSquare()
        {
            InitializeComponent();
        }

        private void TSquare_Load(object sender, EventArgs e)
        {

        }
        public void GenerateTSquare(Graphics g, int iIterations, double iLeft, double iTop, double iWidth, double iHeight, Color oColor)
        {
            g.FillRectangle(new SolidBrush(oColor), (float)iLeft, (float)iTop, (float)iWidth, (float)iHeight);
            if (iIterations > 1)
            {
                double dNewWidth = iWidth / 2.0;
                double dNewHeight = iHeight / 2.0;

                GenerateTSquare(g, iIterations - 1, iLeft - (dNewWidth / 2.0), iTop - (dNewHeight / 2.0), dNewWidth, dNewHeight, oColor);
                GenerateTSquare(g, iIterations - 1, iLeft + iWidth - (dNewWidth / 2.0), iTop - (dNewHeight / 2.0), dNewWidth, dNewHeight, oColor);
                GenerateTSquare(g, iIterations - 1, iLeft - (dNewWidth / 2.0), iTop + iHeight - (dNewHeight / 2.0), dNewWidth, dNewHeight, oColor);
                GenerateTSquare(g, iIterations - 1, iLeft + iWidth - (dNewWidth / 2.0), iTop + iHeight - (dNewHeight / 2.0), dNewWidth, dNewHeight, oColor);
                

            }
        }

        public void DrawTSquare(int iIterations, Color oColor)
        {
            picFractal.Image = DrawTSquare(iIterations, oColor, picFractal.Width, picFractal.Height);
        }

        public Bitmap DrawTSquare(int iIterations, Color oColor, int iWidth, int iHeight)
        {
            Bitmap oImage = new Bitmap(iWidth, iHeight);
            Graphics g = Graphics.FromImage(oImage);

            GenerateTSquare(g, iIterations, (double)((iWidth - 2.0) / 4.0) + 1, ((iHeight - 2.0) / 4.0) + 1, (double)(iWidth - 2.0) / 2.0, (double)(iHeight - 2.0) / 2.0, oColor);
            return oImage;
        }

        public Image GetImage()
        {
            return picFractal.Image;
        }

        private void picFractal_MouseMove(object sender, MouseEventArgs e)
        {
            UpdateStatus(0, "(" + e.X.ToString() + "," + e.Y.ToString() + ")");
        }

        private void picFractal_MouseLeave(object sender, EventArgs e)
        {
            UpdateStatus(0, "");
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

    }
}

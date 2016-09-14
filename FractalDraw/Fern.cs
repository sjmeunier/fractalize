using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using UtilLib;

namespace FractalDraw
{
    public partial class Fern : UserControl
    {
        private StatusStrip statusStrip1 = null;

        public Fern()
        {
            InitializeComponent();
        }

        private void Fern_Load(object sender, EventArgs e)
        {
        }

        public void GenerateFern(Graphics g, int iIterations, double dStartX, double dStartY, double dScale, double[] dA, double[] dB, double[] dC, double[] dD, int[] iRand, Color oColor)
        {
            FastRandom rnd = new FastRandom();
            int iRandNum;
            double dX = 0;
            double dY = 0;
            double dNewX = 0;
            double dNewY = 0;

            for (int i = 0; i < iIterations; i++)
            {

                iRandNum = rnd.Next(0, 100);
                if (iRandNum < iRand[0])
                {
                    dNewX = dA[0];
                    dNewY = dA[1] * dY;

                }
                else if (iRandNum < iRand[1])
                {
                    dNewX = (dB[0] * dX) + (dB[1] * dY) + dB[2];
                    dNewY = (dB[3] * dX) + (dB[4] * dY) + dB[5];
                }
                else if (iRandNum < iRand[2])
                {
                    dNewX = (dC[0] * dX) + (dC[1] * dY) + dC[2];
                    dNewY = (dC[3] * dX) + (dC[4] * dY) + dC[5];
                }
                else
                {
                    dNewX = (dD[0] * dX) + (dD[1] * dY) + dD[2];
                    dNewY = (dD[3] * dX) + (dD[4] * dY) + dD[5];
                }
                dX = dNewX;
                dY = dNewY;
                g.FillRectangle(new SolidBrush(oColor), (float)(dStartX + (dNewX * dScale)), (float)(dStartY - (dNewY * dScale)), 1, 1);
            }

        }

        public void DrawFern(int iIterations,  double fScale, Color oColor)
        {
            double[] dA = new double[2];
            double[] dB = new double[6];
            double[] dC = new double[6];
            double[] dD = new double[6];
            int[] iRand = new int[4];

            dA[0] = 0;
            dA[1] = 0.16;
            dB[0] = 0.2;
            dB[1] = -0.26;
            dB[2] = 0;
            dB[3] = 0.23;
            dB[4] = 0.22;
            dB[5] = 1.6;
            dC[0] = -0.15;
            dC[1] = 0.28;
            dC[2] = 0;
            dC[3] = 0.26;
            dC[4] = 0.25;
            dC[5] = 0.44;
            dD[0] = 0.85;
            dD[1] = 0.04;
            dD[2] = 0;
            dD[3] = -0.04;
            dD[4] = 0.85;
            dD[5] = 1.6;
            iRand[0] = 1;
            iRand[1] = 8;
            iRand[2] = 15;
            iRand[3] = 85;

            picFractal.Image = DrawFernImage(iIterations, fScale, oColor, dA, dB, dC, dD, iRand, picFractal.Width, picFractal.Height);
        }

        public void DrawFern(int iIterations, double fScale, Color oColor, double[] dA, double[] dB, double[] dC, double[] dD, int[] iRand)
        {
            picFractal.Image = DrawFernImage(iIterations, fScale, oColor, dA, dB, dC, dD, iRand, picFractal.Width, picFractal.Height);
        }

        public Bitmap DrawFernImage(int iIterations, double fScale, Color oColor, double[] dA, double[] dB, double[] dC, double[] dD, int[] iRand, int iWidth, int iHeight)
        {

            Bitmap oImage = new Bitmap(iWidth,iHeight);
            Graphics g = Graphics.FromImage(oImage);

            GenerateFern(g, iIterations, iWidth / 2.0, (double)iHeight, fScale, dA, dB, dC, dD, iRand, oColor);
            return oImage;

        }

        public Image GetImage()
        {
            return picFractal.Image;
        }

        private void picFractal_Click(object sender, EventArgs e)
        {

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

    }
}

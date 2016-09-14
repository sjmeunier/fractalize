using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace FractalDraw
{
    public partial class NewtonRhapson : UserControl
    {
		Color[] oColor = new Color[16];
        private StatusStrip statusStrip1 = null;


        public NewtonRhapson()
        {
            InitializeComponent();

			for (int i = 0; i < 16; i++)
			{
				oColor[i] = new Color();
			}

			oColor[0] = Color.Black;
			oColor[1] = Color.Blue;
			oColor[2] = Color.Brown;
			oColor[3] = Color.Green;
			oColor[4] = Color.Magenta;
			oColor[5] = Color.Orange;
			oColor[6] = Color.Red;
			oColor[7] = Color.DarkGray;
			oColor[8] = Color.LightBlue;
			oColor[9] = Color.LightGreen;
			oColor[10] = Color.LightYellow;
			oColor[11] = Color.PaleVioletRed;
			oColor[12] = Color.Ivory;
			oColor[13] = Color.Yellow;
			oColor[14] = Color.Cyan;
			oColor[15] = Color.Lime;
		}

		public void Generate(Graphics g, int iIterations, int iSize, double XMax, double XMin, double YMax, double YMin, int iWidth, int iHeight)
		{
			int flag, iColor, col, row, i;
			double deltaX, deltaY, X, Y, Xsquare,Xold,Yold;
			double Ysquare,denom;

			deltaX = (XMax - XMin)/(iWidth);
			deltaY = (YMax - YMin)/(iHeight);
			for (col = 0; col < iWidth; col++)
			{
				for (row = 0; row < iHeight; row++)
				{
					X = XMin + col * deltaX;
					Y = YMax - row * deltaY;
					Xsquare = 0;
					Ysquare = 0;
					Xold = 42;
					Yold = 42;
					i = 0;
					flag = 0;
					while ((i <= iIterations) && (flag == 0))
					{
																   
						Xsquare = X*X;
						Ysquare = Y*Y;
						denom = 3.0*((Xsquare - Ysquare)*(Xsquare - Ysquare) + 4.0*Xsquare*Ysquare);
						if (denom == 0)
						{
							denom = 0.00000001;
						}
						X = 0.6666667*X + (Xsquare - Ysquare)/denom;

						Y = 0.6666667*Y - 2.0*X*Y/denom;
						if ((Xold == X) && (Yold == Y)) 
						{
							flag = 1;
						}
						Xold = X;
						Yold = Y;
						i++;
					}
					if (X > 0)
					{
						iColor = i % 5;
					}
					else
					{
						if ((X < -0.3) && (Y > 0)) 
						{
							iColor = (i % 5) + 5;
						}
						else
						{
							iColor = (i % 6) + 10;
						}
					}
					g.FillRectangle(new SolidBrush(oColor[iColor]),col, row, 1, 1);
				}
			}

		}

        public void DrawNewtonRhapson(int iIterations, int iSize, double XMax, double XMin, double YMax, double YMin)
        {
            picFractal.Image = DrawNewtonRhapsonImage(iIterations, iSize, XMax, XMin, YMax, YMin, picFractal.Width, picFractal.Height);
        }

        public Bitmap DrawNewtonRhapsonImage(int iIterations, int iSize, double XMax, double XMin, double YMax, double YMin, int iWidth, int iHeight)
        {
            Bitmap oImage = new Bitmap(iWidth, iHeight);
            Graphics g = Graphics.FromImage(oImage);

            Generate(g, iIterations, iSize, XMax, XMin, YMax, YMin, iWidth, iHeight);
            return oImage;
        }
        
        private void NewtonRhapson_Load(object sender, EventArgs e)
        {

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
    }
}

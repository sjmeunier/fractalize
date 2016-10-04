using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MathLib;

namespace FractalDraw
{
    public partial class Mandelbrot : UserControl
    {
   		Color[] oColor = new Color[16];
        public int selectX = 0, selectY = 0, selectWidth = 0, selectHeight = 0;
        private bool bDown = false;
        private StatusStrip statusStrip1 = null;

        public Mandelbrot(ref StatusStrip statusStripRef)
        {
            InitializeComponent();

            statusStrip1 = statusStripRef;
			int i;

			for (i = 0; i < 16; i++)
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

        public Mandelbrot()
        {
            InitializeComponent();

            int i;

            for (i = 0; i < 16; i++)
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

		public void Generate(Graphics g, int iIterations, double Scaling, int iInitialSize, double iOffsetRe, double iOffsetIm, int iLeft, int iTop, int iWidth, int iHeight, int iPower, int iPower2)
		{
			Complex Z = new Complex( 0.0, -0.0);
			Complex T = new Complex( 0.0, -0.0);
			Complex C = new Complex( 0.0, -0.0);
			Complex Offset = new Complex( 0.0, -0.0);
			//			double ManualOffsetX = 0, ManualOffsetY = 0;

			// iterate over the area in the complex plane indicated by the Scaling and Offset
			//   i is the real axis,  j is the complex axis

			for (double i = -iWidth/2; i < iWidth/2 ; i++)
			{
				for (double j = -iHeight/2; j < iHeight/2; j++)
				{
					// Normalize Z and adjust for Scaling and Offset
					Z.Real = (i/((double)iInitialSize)) * Scaling + (double)iOffsetRe;
					Z.Imaginary = (j/((double)iInitialSize)) * Scaling + (double)iOffsetIm;

					// C is the Z(0) of the formula based on the pixel position
					// We've also added a ManualOffset from the text boxes on the screen
					C.Real = Z.Real;// + ManualOffsetX;
					C.Imaginary = Z.Imaginary;// + ManualOffsetY;

					// initialize the  interation counter
					int iteration = 0;

					// iterate a maximum of 150 times and break
					// out if or when |Z| > 2

					for (int k = 1; k < iIterations; k++)
					{
						Z = (Z^iPower) + (Z^iPower2) + C;
						// if modulus of Z > 2, break out of the loop
						// and remember the current iteration to choose the color
						if (Z.Abs() > 2.0)
						{
							iteration = k;
							break;
						}
					}

					// draw the point on the complex plain and choose the color based on the iteration
					// the color is picked by casting the iteration to a KnownColor enumeration
					DrawComplexPoint(g, ((int)i) + (iWidth/2), ((int)j) + (iHeight/2), iteration);
				}
			}
		}

		private void DrawComplexPoint(Graphics g, int iX, int iY, int iColor)
		{
			g.FillRectangle(new SolidBrush(oColor[iColor%16]), iX, iY, 1, 1);
		}

        public void DrawMandelbrot(int iIterations, double Scaling, int iInitialSize, double iOffsetRe, double iOffsetIm, int iLeft, int iTop, int iPower, int iPower2)
        {
            selectX = 0;
            selectY = 0;
            selectWidth = 0;
            selectHeight = 0;
            picFractal.Image = DrawMandelbrotImage(iIterations, Scaling, iInitialSize, iOffsetRe, iOffsetIm, iLeft, iTop, iPower, iPower2, picFractal.Width, picFractal.Height);
        }

        public Bitmap DrawMandelbrotImage(int iIterations, double Scaling, int iInitialSize, double iOffsetRe, double iOffsetIm, int iLeft, int iTop, int iPower, int iPower2, int iWidth, int iHeight)
        {
            Bitmap oImage = new Bitmap(iWidth, iHeight);
            Graphics g = Graphics.FromImage(oImage);

            Generate(g, iIterations, Scaling, iInitialSize, iOffsetRe, iOffsetIm, iLeft, iTop, iWidth, iHeight, iPower, iPower2);
            return oImage;

        }


        private void Mandelbrot_Load(object sender, EventArgs e)
        {

        }
        public Image GetImage()
        {
            return picFractal.Image;
        }

        private void picFractal_Click(object sender, EventArgs e)
        {

        }


        private void picFractal_MouseDown(object sender, MouseEventArgs e)
        {
            ControlPaint.DrawReversibleFrame(picFractal.RectangleToScreen(new Rectangle(selectX, selectY, selectWidth, selectHeight)), Color.Red, FrameStyle.Dashed);

            selectX = e.X;
            selectY = e.Y;
            selectWidth = 0;
            selectHeight = 0;
            bDown = true;
            UpdateStatus(2, "(" + selectX.ToString() + "," + selectY.ToString() + ")-(" + Convert.ToString(selectX + selectWidth) + "," + Convert.ToString(selectY + selectHeight) + ")");
            ControlPaint.DrawReversibleFrame(picFractal.RectangleToScreen(new Rectangle(selectX, selectY, selectWidth, selectHeight)), Color.Red, FrameStyle.Dashed);

        }

        private void picFractal_MouseUp(object sender, MouseEventArgs e)
        {
            bDown = false;
            ControlPaint.DrawReversibleFrame(picFractal.RectangleToScreen(new Rectangle(selectX, selectY, selectWidth, selectHeight)), Color.Red, FrameStyle.Dashed);

            if (e.X < selectX)
            {
                selectWidth = selectX - e.X;
                selectX = e.X;
            }
            else
            {
                selectWidth = e.X - selectX;
            }
            if (e.Y < selectY)
            {
                selectHeight = selectY - e.Y;
                selectY = e.Y;
            }
            else
            {
                selectHeight = e.Y - selectY;
            }

            ControlPaint.DrawReversibleFrame(picFractal.RectangleToScreen(new Rectangle(selectX, selectY, selectWidth, selectHeight)), Color.Red, FrameStyle.Dashed);

        }

        private void picFractal_MouseMove(object sender, MouseEventArgs e)
        {
            UpdateStatus(0, "(" + e.X.ToString() + "," + e.Y.ToString() + ")");
            if (bDown == true)
            {
                ControlPaint.DrawReversibleFrame(picFractal.RectangleToScreen(new Rectangle(selectX, selectY, selectWidth, selectHeight)), Color.Red, FrameStyle.Dashed);
                if (e.X < selectX)
                {
                    selectWidth = selectX - e.X;
                    selectX = e.X;
                }
                else
                {
                    selectWidth = e.X - selectX;
                }
                if (e.Y < selectY)
                {
                    selectHeight = selectY - e.Y;
                    selectY = e.Y;
                }
                else
                {
                    selectHeight = e.Y - selectY;
                }
                UpdateStatus(2, "(" + selectX.ToString() + "," + selectY.ToString() + ")-(" + Convert.ToString(selectX + selectWidth) + "," + Convert.ToString(selectY + selectHeight) + ")");
                ControlPaint.DrawReversibleFrame(picFractal.RectangleToScreen(new Rectangle(selectX, selectY, selectWidth, selectHeight)), Color.Red, FrameStyle.Dashed);
            }

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

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
    public partial class Plasma : UserControl
    {
        private StatusStrip statusStrip1 = null;

        public double gRoughness;
        public double gBigSize;
        FastRandom rnd;

        public Plasma()
        {
            InitializeComponent();

        }

        private void Plasma_Load(object sender, EventArgs e)
        {
            rnd = new FastRandom();       
        }

        public void DrawPlasma(double iRoughness, string plasmaType)
        {
            picFractal.Image = DrawPlasmaImage(iRoughness, plasmaType, picFractal.Width, picFractal.Height);
        }

        public Bitmap DrawPlasmaImage(double iRoughness, string plasmaType, int iWidth, int iHeight)
        {
            Bitmap bmp = new Bitmap(iWidth + 1, iHeight + 1);
            Graphics g = Graphics.FromImage(bmp);

            double[,] points = new double[iWidth + 1, iHeight + 1];
            points = Generate(iWidth, iHeight, iRoughness);
            for (int x = 0; x < iWidth; x++)
            {
                for (int y = 0; y < iHeight; y++)
                {
                    g.FillRectangle(new SolidBrush(ComputeColor(points[x, y], plasmaType)), x, y, 1, 1);
                }
            }

            g.Dispose();
            return bmp;
        }

        private double Displace(double SmallSize)
        {
            
            double Max = SmallSize/ gBigSize * gRoughness;
            return (rnd.NextDouble() - 0.5) * Max;
        }

        public double[,] Generate(int iWidth, int iHeight, double iRoughness)
        {
            double c1, c2, c3, c4;
            double[,] points = new double[iWidth+1, iHeight+1];
            
            //Assign the four corners of the intial grid random color values
            //These will end up being the colors of the four corners of the applet.		
            c1 = rnd.NextDouble();
            c2 = rnd.NextDouble();
            c3 = rnd.NextDouble();
            c4 = rnd.NextDouble();
            gRoughness = iRoughness;
            gBigSize = iWidth + iHeight;
            DivideGrid(ref points, 0, 0, iWidth, iHeight, c1, c2, c3, c4);
            return points;
        }

        public void DivideGrid(ref double[,] points, double x, double y, double width, double height, double c1, double c2, double c3, double c4)
        {
            double Edge1, Edge2, Edge3, Edge4, Middle;

            double newWidth = Math.Floor(width / 2);
            double newHeight = Math.Floor(height / 2);

            if (width > 1 || height > 1)
            {
                Middle = ((c1 + c2 + c3 + c4) / 4)+Displace(newWidth + newHeight);	//Randomly displace the midpoint!
                Edge1 = ((c1 + c2) / 2);	//Calculate the edges by averaging the two corners of each edge.
                Edge2 = ((c2 + c3) / 2);
                Edge3 = ((c3 + c4) / 2);
                Edge4 = ((c4 + c1) / 2);//
                //Make sure that the midpoint doesn't accidentally "randomly displaced" past the boundaries!
                Middle= Rectify(Middle);
                Edge1 = Rectify(Edge1);
                Edge2 = Rectify(Edge2);
                Edge3 = Rectify(Edge3);
                Edge4 = Rectify(Edge4);
                //Do the operation over again for each of the four new grids.			
                DivideGrid(ref points, x, y, newWidth, newHeight, c1, Edge1, Middle, Edge4);
                DivideGrid(ref points, x + newWidth, y, width - newWidth, newHeight, Edge1, c2, Edge2, Middle);
                DivideGrid(ref points, x + newWidth, y + newHeight, width - newWidth, height - newHeight, Middle, Edge2, c3, Edge3);
                DivideGrid(ref points, x, y + newHeight, newWidth, height - newHeight, Edge4, Middle, Edge3, c4);
            }
            else	//This is the "base case," where each grid piece is less than the size of a pixel.
            {
                //The four corners of the grid piece will be averaged and drawn as a single pixel.
                double c = (c1 + c2 + c3 + c4) / 4;

                points[(int)(x), (int)(y)] = c;
                if (width == 2)
                {
                    points[(int)(x+1), (int)(y)] = c;
                }
                if (height == 2)
                {
                    points[(int)(x), (int)(y+1)] = c;
                }
                if ((width == 2) && (height == 2)) 
                {
                    points[(int)(x + 1), (int)(y+1)] = c;
                }
            }
        }

        private double Rectify(double iNum)
        {
            if (iNum < 0)
            {
                iNum = 0;
            }
            else if (iNum > 1.0)
            {
                iNum = 1.0;
            }
            return iNum;
        }

        //Returns a color based on a color value, c.
        public Color ComputeColor(double c, string plasmaType)
        {
            double Red = 0;
            double Green = 0;
            double Blue = 0;

            //      Red = Math.Round(c * 255, 0);
            //       Green = Math.Round(c * 255, 0);
            //       Blue = Math.Round(c * 255, 0);
            //       return Color.FromArgb((int)Red, (int)Green, (int)Blue);

            if (plasmaType == "Plasma")
            {
                if (c < 0.5)
                {
                    Red = c * 2;
                }
                else
                {
                    Red = (1.0 - c) * 2;
                }

                if (c >= 0.3 && c < 0.8)
                {
                    Green = (c - 0.3) * 2;
                }
                else if (c < 0.3)
                {
                    Green = (0.3 - c) * 2;
                }
                else
                {
                    Green = (1.3 - c) * 2;
                }

                if (c >= 0.5)
                {
                    Blue = (c - 0.5) * 2;
                }
                else
                {
                    Blue = (0.5 - c) * 2;
                }
            }
            else if (plasmaType == "Cloud")
            {

                if (c < 0.3)
                {
                    Red = c;
                }
                Red = Green = c;

                Blue = 1;
            }
            else
            {
                Red = Green = Blue = c;
            }
            Red = Math.Round(Red * 255, 0);
            Green = Math.Round(Green * 255, 0);
            Blue = Math.Round(Blue * 255, 0);
            return Color.FromArgb((int)Red, (int)Green, (int)Blue);
        }

        private void Plasma_Resize(object sender, EventArgs e)
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
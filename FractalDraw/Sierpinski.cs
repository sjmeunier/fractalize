using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace FractalDraw
{
    public partial class Sierpinski : UserControl
    {
        private StatusStrip statusStrip1 = null;

        public Sierpinski()
        {
            InitializeComponent();
        }

        private void Sierpinski_Load(object sender, EventArgs e)
        {

        }

        public void GenerateSquare(Graphics g, int iIterations, double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, Color oColor)
        {
            if (iIterations > 1)
            {
                double midx1a = x1 + ((x2 - x1) / 3);
                double midy1a = y1;
                double midx1b = x1 + ((x2 - x1) / 3 * 2);
                double midy1b = y1;
                double midx2a = x2;
                double midy2a = y2 + ((y3 - y2) / 3);
                double midx2b = x2;
                double midy2b = y2 + ((y3 - y2) / 3 * 2);
                double midx3a = x1 + ((x3 - x4) / 3);
                double midy3a = y3;
                double midx3b = x1 + ((x3 - x4) / 3 * 2);
                double midy3b = y3;
                double midx4a = x1;
                double midy4a = y1 + ((y4 - y1) / 3);
                double midx4b = x1;
                double midy4b = y1 + ((y4 - y1) / 3 * 2);
                double midx5a = x1 + ((x2 - x1) / 3);
                double midy5a = y1 + ((y4 - y1) / 3);
                double midx5b = x1 + ((x2 - x1) / 3 * 2);
                double midy5b = y1 + ((y4 - y1) / 3);
                double midx5d = x1 + ((x2 - x1) / 3);
                double midy5d = y1 + ((y4 - y1) / 3 * 2);
                double midx5c = x1 + ((x2 - x1) / 3 * 2);
                double midy5c = y1 + ((y4 - y1) / 3 * 2);

                GenerateSquare(g, iIterations - 1, x1, y1, midx1a, midy1a, midx5a, midy5a, midx4a, midy4a, oColor);
                GenerateSquare(g, iIterations - 1, midx1a, midy1a, midx1b, midy1b, midx5b, midy5b, midx5a, midy5a, oColor);
                GenerateSquare(g, iIterations - 1, midx1b, midy1b, x2, y2, midx2a, midy2a, midx5b, midy5b, oColor);
                GenerateSquare(g, iIterations - 1, midx5b, midy5b, midx2a, midy2a, midx2b, midy2b, midx5c, midy5c, oColor);
                GenerateSquare(g, iIterations - 1, midx5c, midy5c, midx2b, midy2b, x3, y3, midx3b, midy3b, oColor);
                GenerateSquare(g, iIterations - 1, midx5d, midy5d, midx5c, midy5c, midx3b, midy3b, midx3a, midy3a, oColor);
                GenerateSquare(g, iIterations - 1, midx4b, midy4b, midx5d, midy5d, midx3a, midy3a, x4, y4, oColor);
                GenerateSquare(g, iIterations - 1, midx4a, midy4a, midx5a, midy5a, midx5d, midy5d, midx4b, midy4b, oColor);
            }
            else
            {
                Pen o = new Pen(new SolidBrush(oColor));
                PointF[] points = new PointF[4];
                points[0] = new PointF((float)x1, (float)y1);
                points[1] = new PointF((float)x2, (float)y2);
                points[2] = new PointF((float)x3, (float)y3);
                points[3] = new PointF((float)x4, (float)y4);

                g.FillPolygon(new SolidBrush(oColor), points);
    //            g.DrawLine(oPen, (float)x1, (float)y1, (float)x2, (float)y2);
    //            g.DrawLine(oPen, (float)x2, (float)y2, (float)x3, (float)y3);
    //            g.DrawLine(oPen, (float)x3, (float)y3, (float)x4, (float)y4);
    //            g.DrawLine(oPen, (float)x4, (float)y4, (float)x1, (float)y1);
            }
        
        }

        public void GenerateTriangle(Graphics g, int iIterations, double x1, double y1, double x2, double y2, double x3, double y3, Color oColor)
        {
           
            if (iIterations > 1)
            {
                double midx1 = (x1 + x2) / 2;
                double midy1 = (y1 + y2) / 2;
                double midx2 = (x2 + x3) / 2;
                double midy2 = (y2 + y3) / 2;
                double midx3 = (x3 + x1) / 2;
                double midy3 = (y3 + y1) / 2;
                GenerateTriangle(g, iIterations - 1, x1, y1, midx1, midy1, midx3, midy3, oColor);
                GenerateTriangle(g, iIterations - 1, midx1, midy1, x2, y2, midx2, midy2, oColor);
                GenerateTriangle(g, iIterations - 1, midx3, midy3, midx2, midy2, x3, y3, oColor);
            }
            else
            {
                PointF[] points = new PointF[3];
                points[0] = new PointF((float)x1, (float)y1);
                points[1] = new PointF((float)x2, (float)y2);
                points[2] = new PointF((float)x3, (float)y3);

                g.FillPolygon(new SolidBrush(oColor), points);

//                Pen oPen = new Pen(new SolidBrush(oColor));
//                g.DrawLine(oPen, (float)x1, (float)y1, (float)x2, (float)y2);
//                g.DrawLine(oPen, (float)x2, (float)y2, (float)x3, (float)y3);
//                g.DrawLine(oPen, (float)x3, (float)y3, (float)x1, (float)y1);
            }
        }

        public void DrawSierpinskiTriangle(int iIterations, Color oColor)
        {
            picFractal.Image = DrawSierpinskiTriangleImage(iIterations, oColor, picFractal.Width, picFractal.Height);
        }

        public Bitmap DrawSierpinskiTriangleImage(int iIterations, Color oColor, int iWidth, int iHeight)
        {
            Bitmap oImage = new Bitmap(iWidth, iHeight);
            Graphics g = Graphics.FromImage(oImage);

            GenerateTriangle(g, iIterations, 1, (double)iHeight - 2, (double)iWidth / 2.0, 1, (double)iWidth - 2, (double)iHeight - 2, oColor);
            return oImage;
        }

        public void DrawSierpinskiSquare(int iIterations, Color oColor)
        {
            picFractal.Image = DrawSierpinskiSquareImage(iIterations, oColor, picFractal.Width, picFractal.Height);
        }

        public Bitmap DrawSierpinskiSquareImage(int iIterations, Color oColor, int iWidth, int iHeight)
        {
            Bitmap oImage = new Bitmap(iWidth, iHeight);
            Graphics g = Graphics.FromImage(oImage);

            GenerateSquare(g, iIterations, 1, 1, (double)iWidth, 1, (double)iWidth - 2, (double)iHeight - 2, 1, (double)iHeight - 2, oColor);
            return oImage;
        }

        public Image GetImage()
        {
            return picFractal.Image;
        }

        private void Sierpinski_MouseMove(object sender, MouseEventArgs e)
        {
            UpdateStatus(0, "(" + e.X.ToString() + "," + e.Y.ToString() + ")");
        }

        private void Sierpinski_MouseLeave(object sender, EventArgs e)
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

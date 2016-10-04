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
    public partial class Koch : UserControl
    {
        public Koch()
        {
            InitializeComponent();
        }

        private void Koch_Load(object sender, EventArgs e)
        {

        }

        public void GenerateKochLine(Graphics g, int iIterations, PointF p1, PointF p2, Color oColor)
        {
            if (iIterations > 1)
            {
                PointF pMid = new System.Drawing.Point(0, 0);
                PointF pLM = new System.Drawing.Point(0, 0);
                PointF pRM = new System.Drawing.Point(0, 0);
             
                pMid.X = p1.X + ((p2.X - p1.X) / 2);
                pMid.Y = p1.Y + ((p2.Y - p1.Y) / 2);

                if (pMid.Y == p1.Y)
                {
                    pMid.Y = pMid.Y - ((p2.X - p1.X) / 4);
                }
                pLM.X = p1.X + ((p2.X - p1.X) / 4);
                pLM.Y = p1.Y + ((p2.Y - p1.Y) / 4);
                pRM.X = p1.X + (((p2.X - p1.X) / 4) * 3);
                pRM.Y = p1.Y + (((p2.Y - p1.Y) / 4) * 3);

                GenerateKochLine(g, iIterations - 1, p1, pLM, oColor);
                GenerateKochLine(g, iIterations - 1, pLM, pMid, oColor);
                GenerateKochLine(g, iIterations - 1, pMid, pRM, oColor);
                GenerateKochLine(g, iIterations - 1, pRM, p2, oColor);
            }
            else
            {
                g.DrawLine(new Pen(oColor, 1), p1, p2);
            }
        }

        public void DrawKoch(int iIterations, Color oColor)
        {
            Bitmap oImage = new Bitmap(picFractal.Width, picFractal.Height);
            Graphics g = Graphics.FromImage(oImage);
            int iWidth = picFractal.Width - 2;
            float fY = (float)((float)(iWidth) / 3.0);

            GenerateKochLine(g, iIterations, new PointF(1, fY), new PointF(iWidth+1, fY), oColor);
            GenerateKochLine(g, iIterations, new PointF(iWidth + 1, fY), new PointF((float)((iWidth / 2.0) + 1), (float)(Math.Cos(Trig.DegToRad(45)) * iWidth) + fY), oColor);
            GenerateKochLine(g, iIterations, new PointF((float)((iWidth / 2.0) + 1), (float)(Math.Cos(Trig.DegToRad(45)) * iWidth) + fY), new PointF(1, fY), oColor);
            picFractal.Image = oImage;

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace FractalDraw
{
    public partial class Brownian : UserControl
    {
        private StatusStrip statusStrip1 = null;

        public Brownian()
        {
            InitializeComponent();
        }
        double[] Fh = new double[257];


        private double Gauss(int iSeed, double fMu, double fSigma)
        {
            double fx;
            int i;

            fx = 0;
            for (i = 0; i < 12; i++)
            {
                fx = fx + (new System.Random(iSeed).NextDouble());
            }
            fx = fx - 6.0;
            return fMu + fSigma * fx;
        }

        private void Subdivide(int f1, int f2, double std, double ratio, double fMu, double fSigma)
        {
            int fmid;
            double stdmid;

            fmid = (int)Math.Round((f1 + f2) / 2.0);
            if ((fmid != f1) && (fmid != f2))
            {
                Fh[fmid] = (Fh[f1] + Fh[f2]) / 2.0 + Gauss(0, fMu, fSigma) * std;
                stdmid = std * ratio;
                Subdivide(f1, fmid, stdmid, ratio, fMu, fSigma);
                Subdivide(fmid, f2, stdmid, ratio, fMu, fSigma);
            }
        }

        public void Generate(Graphics g, double fMu, double fSigma, double fScale, double fH, int fSeed, Color oColor)
        {


            double fRatio, fStd;
            int i;
            Pen oPen = new Pen(oColor);

            Fh[0] = Gauss(fSeed, fMu, fSigma) * fScale;
            Fh[256] = Gauss(0, fMu, fSigma) * fScale;
            fRatio = Math.Exp(-0.693147 * fH);
            fStd = fScale * fRatio;

            Subdivide(0, 255, fStd, fRatio, fMu, fSigma);

            for (i = 0; i < 255; i++)
            {
                g.DrawLine(oPen, 2 * i + 80, 275 - (int)Math.Round(Fh[i]), 2 * (i + 1) + 80, 275 - (int)Math.Round(Fh[i + 1]));
            }

        }

        public void DrawBrownian(double fMu, double fSigma, double fScale, double fH, int fSeed, Color oColor)
        {
            picFractal.Image = DrawBrownianImage(fMu, fSigma, fScale, fH, fSeed, oColor, picFractal.Width, picFractal.Height);
        }

        public Bitmap DrawBrownianImage(double fMu, double fSigma, double fScale, double fH, int fSeed, Color oColor, int iWidth, int iHeight)
        {
            Bitmap oImage = new Bitmap(iWidth, iHeight);
            Graphics g = Graphics.FromImage(oImage);

            Generate(g, fMu, fSigma, fScale, fH, fSeed, oColor);
            return oImage;
        }
        
        private void Brownian_Load(object sender, EventArgs e)
        {

        }

        public Image GetImage()
        {
            return picFractal.Image;
        }

        private void picFractal_MouseLeave(object sender, EventArgs e)
        {
            UpdateStatus(0, "");
        }

        private void picFractal_MouseMove(object sender, MouseEventArgs e)
        {
            UpdateStatus(0, "(" + e.X.ToString() + "," + e.Y.ToString() + ")");
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

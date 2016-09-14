using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Fractalize
{
    public partial class FernForm : Form
    {
        public int gWidth = 0;
        public int gHeight = 0;
        public int gIterations = 0;
        public double gScale = 0;
        public double[] gA = new double[2];
        public double[] gB = new double[6];
        public double[] gC = new double[6];
        public double[] gD = new double[6];
        public int[] gRand = new int[4];
        public Color gColor = new Color();

        public FernForm()
        {
            InitializeComponent();
        }

        private void cmdDraw_Click(object sender, EventArgs e)
        {
            gA[0] = Convert.ToDouble(txtA0.Text);
            gA[1] = Convert.ToDouble(txtA1.Text);
            gB[0] = Convert.ToDouble(txtB0.Text);
            gB[1] = Convert.ToDouble(txtB1.Text);
            gB[2] = Convert.ToDouble(txtB2.Text);
            gB[3] = Convert.ToDouble(txtB3.Text);
            gB[4] = Convert.ToDouble(txtB4.Text);
            gB[5] = Convert.ToDouble(txtB5.Text);
            gC[0] = Convert.ToDouble(txtC0.Text);
            gC[1] = Convert.ToDouble(txtC1.Text);
            gC[2] = Convert.ToDouble(txtC2.Text);
            gC[3] = Convert.ToDouble(txtC3.Text);
            gC[4] = Convert.ToDouble(txtC4.Text);
            gC[5] = Convert.ToDouble(txtC5.Text);
            gD[0] = Convert.ToDouble(txtD0.Text);
            gD[1] = Convert.ToDouble(txtD1.Text);
            gD[2] = Convert.ToDouble(txtD2.Text);
            gD[3] = Convert.ToDouble(txtD3.Text);
            gD[4] = Convert.ToDouble(txtD4.Text);
            gD[5] = Convert.ToDouble(txtD5.Text);
            gRand[0] = Convert.ToInt32(txtRand0.Text);
            gRand[1] = Convert.ToInt32(txtRand1.Text);
            gRand[2] = Convert.ToInt32(txtRand2.Text);
            gRand[3] = Convert.ToInt32(txtRand3.Text);

            gColor = Color.FromArgb(Convert.ToInt32(txtCol0.Text), Convert.ToInt32(txtCol1.Text), Convert.ToInt32(txtCol2.Text));
            gIterations = Convert.ToInt32(txtIterations.Text);
            gScale = Convert.ToInt32(txtScale.Text);
            gWidth = fern1.Width;
            gHeight = fern1.Height;

            Thread drawThread = new Thread(new ThreadStart(DrawImage));
            drawThread.Start();

            cmdSave.Enabled = true;

        }

        private void DrawImage()
        {
            statusStrip1.Items[1].Text = "Calculating...";
            fern1.DrawFern(gIterations, gScale, gColor, gA, gB, gC, gD, gRand);
            statusStrip1.Items[1].Text = "Done";

        }

        private void FernForm_Resize(object sender, EventArgs e)
        {
            fern1.Width = this.Width - 137;
            fern1.Height = this.Height - 50;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPG files|*.jpg|BMP files|*.bmp|GIF files|*.gif";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        fern1.GetImage().Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        fern1.GetImage().Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        fern1.GetImage().Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }

        }

        private void FernForm_Load(object sender, EventArgs e)
        {
            fern1.SetStatusStrip(ref statusStrip1);
            fern1.Width = this.Width - 137;
            fern1.Left = 129;
            fern1.Height = this.Height - 50;

            gIterations = 100000;
            gScale = 40;
            gColor = Color.FromArgb(0, 255, 0);
            gWidth = fern1.Width;
            gHeight = fern1.Height;
            gA[0] = 0;
            gA[1] = 0.16;
            gB[0] = 0.2;
            gB[1] = -0.26;
            gB[2] = 0;
            gB[3] = 0.23;
            gB[4] = 0.22;
            gB[5] = 1.6;
            gC[0] = -0.15;
            gC[1] = 0.28;
            gC[2] = 0;
            gC[3] = 0.26;
            gC[4] = 0.25;
            gC[5] = 0.44;
            gD[0] = 0.85;
            gD[1] = 0.04;
            gD[2] = 0;
            gD[3] = -0.04;
            gD[4] = 0.85;
            gD[5] = 1.6;
            gRand[0] = 1;
            gRand[1] = 8;
            gRand[2] = 15;
            gRand[3] = 85;

            txtIterations.Text = gIterations.ToString().Trim();
            txtScale.Text = gScale.ToString().Trim();
            txtA0.Text = gA[0].ToString().Trim();
            txtA1.Text = gA[1].ToString().Trim();
            txtB0.Text = gB[0].ToString().Trim();
            txtB1.Text = gB[1].ToString().Trim();
            txtB2.Text = gB[2].ToString().Trim();
            txtB3.Text = gB[3].ToString().Trim();
            txtB4.Text = gB[4].ToString().Trim();
            txtB5.Text = gB[5].ToString().Trim();
            txtC0.Text = gC[0].ToString().Trim();
            txtC1.Text = gC[1].ToString().Trim();
            txtC2.Text = gC[2].ToString().Trim();
            txtC3.Text = gC[3].ToString().Trim();
            txtC4.Text = gC[4].ToString().Trim();
            txtC5.Text = gC[5].ToString().Trim();
            txtD0.Text = gD[0].ToString().Trim();
            txtD1.Text = gD[1].ToString().Trim();
            txtD2.Text = gD[2].ToString().Trim();
            txtD3.Text = gD[3].ToString().Trim();
            txtD4.Text = gD[4].ToString().Trim();
            txtD5.Text = gD[5].ToString().Trim();
            txtRand0.Text = gRand[0].ToString().Trim();
            txtRand1.Text = gRand[1].ToString().Trim();
            txtRand2.Text = gRand[2].ToString().Trim();
            txtRand3.Text = gRand[3].ToString().Trim();
            txtCol0.Text = gColor.R.ToString().Trim();
            txtCol1.Text = gColor.G.ToString().Trim();
            txtCol2.Text = gColor.B.ToString().Trim();
        }

        public void LoadFromFile(string filename)
        {
            string fileLine;
            string[] colorBits;
            string[] tmp;

            StreamReader reader = new StreamReader(filename);
            fileLine = reader.ReadLine();

            fileLine = reader.ReadLine();
            gWidth = Convert.ToInt32(fileLine.Split(':')[1].Trim());

            fileLine = reader.ReadLine();
            gHeight = Convert.ToInt32(fileLine.Split(':')[1].Trim());

            fileLine = reader.ReadLine();
            gIterations = Convert.ToInt32(fileLine.Split(':')[1].Trim());

            fileLine = reader.ReadLine();
            gScale = Convert.ToDouble(fileLine.Split(':')[1].Trim());

            fileLine = reader.ReadLine();
            tmp = fileLine.Split(':')[1].Trim().Split(',');
            gA = new double[tmp.Count()];
            for (int i = 0; i < tmp.Count(); i++)
            {
                gA[i] = Convert.ToDouble(tmp[i]);
            }

            fileLine = reader.ReadLine();
            tmp = fileLine.Split(':')[1].Trim().Split(',');
            gB = new double[tmp.Count()];
            for (int i = 0; i < tmp.Count(); i++)
            {
                gB[i] = Convert.ToDouble(tmp[i]);
            }

            fileLine = reader.ReadLine();
            tmp = fileLine.Split(':')[1].Trim().Split(',');
            gC = new double[tmp.Count()];
            for (int i = 0; i < tmp.Count(); i++)
            {
                gC[i] = Convert.ToDouble(tmp[i]);
            }

            fileLine = reader.ReadLine();
            tmp = fileLine.Split(':')[1].Trim().Split(',');
            gD = new double[tmp.Count()];
            for (int i = 0; i < tmp.Count(); i++)
            {
                gD[i] = Convert.ToDouble(tmp[i]);
            }


            fileLine = reader.ReadLine();
            tmp = fileLine.Split(':')[1].Trim().Split(',');
            gRand = new int[tmp.Count()];
            for (int i = 0; i < tmp.Count(); i++)
            {
                gRand[i] = Convert.ToInt32(tmp[i]);
            }

            fileLine = reader.ReadLine();
            colorBits = fileLine.Split(':')[1].Trim().Split(',');
            gColor = Color.FromArgb(Convert.ToInt32(colorBits[0]), Convert.ToInt32(colorBits[1]), Convert.ToInt32(colorBits[2]));
            reader.Close();


            this.Width = gWidth + 137;
            this.Height = gHeight + 29;
            fern1.Width = gWidth;
            fern1.Height = gHeight;

            txtScale.Text = gScale.ToString().Trim();
            txtIterations.Text = gIterations.ToString();
            txtA0.Text = gA[0].ToString().Trim();
            txtA1.Text = gA[1].ToString().Trim();
            txtB0.Text = gB[0].ToString().Trim();
            txtB1.Text = gB[1].ToString().Trim();
            txtB2.Text = gB[2].ToString().Trim();
            txtB3.Text = gB[3].ToString().Trim();
            txtB4.Text = gB[4].ToString().Trim();
            txtB5.Text = gB[5].ToString().Trim();
            txtC0.Text = gC[0].ToString().Trim();
            txtC1.Text = gC[1].ToString().Trim();
            txtC2.Text = gC[2].ToString().Trim();
            txtC3.Text = gC[3].ToString().Trim();
            txtC4.Text = gC[4].ToString().Trim();
            txtC5.Text = gC[5].ToString().Trim();
            txtD0.Text = gD[0].ToString().Trim();
            txtD1.Text = gD[1].ToString().Trim();
            txtD2.Text = gD[2].ToString().Trim();
            txtD3.Text = gD[3].ToString().Trim();
            txtD4.Text = gD[4].ToString().Trim();
            txtD5.Text = gD[5].ToString().Trim();
            txtRand0.Text = gRand[0].ToString().Trim();
            txtRand1.Text = gRand[1].ToString().Trim();
            txtRand2.Text = gRand[2].ToString().Trim();
            txtRand3.Text = gRand[3].ToString().Trim();
            txtCol0.Text = gColor.R.ToString().Trim();
            txtCol1.Text = gColor.G.ToString().Trim();
            txtCol2.Text = gColor.B.ToString().Trim();

            Thread drawThread = new Thread(new ThreadStart(DrawImage));
            drawThread.Start();

            cmdSave.Enabled = true;
        }

        private void cmdExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text files|*.txt|All files|*.*";
            saveFileDialog1.DefaultExt = ".txt";

            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                StreamWriter writer = new StreamWriter(saveFileDialog1.FileName);
                writer.WriteLine("Type:\t\tFern");
                writer.WriteLine("Width:\t\t" + gWidth.ToString().Trim());
                writer.WriteLine("Height:\t\t" + gHeight.ToString().Trim());
                writer.WriteLine("Iterations:\t\t" + gIterations.ToString().Trim());
                writer.WriteLine("Scale:\t\t" + gScale.ToString().Trim());
                writer.WriteLine("A:\t\t" + gA[0].ToString().Trim() + ", " + gA[1].ToString().Trim());
                writer.WriteLine("B:\t\t" + gB[0].ToString().Trim() + ", " + gB[1].ToString().Trim() + ", " + gB[2].ToString().Trim() + ", " + gB[3].ToString().Trim() + ", " + gB[4].ToString().Trim() + ", " + gB[5].ToString().Trim());
                writer.WriteLine("C:\t\t" + gC[0].ToString().Trim() + ", " + gC[1].ToString().Trim() + ", " + gC[2].ToString().Trim() + ", " + gC[3].ToString().Trim() + ", " + gC[4].ToString().Trim() + ", " + gC[5].ToString().Trim());
                writer.WriteLine("D:\t\t" + gD[0].ToString().Trim() + ", " + gD[1].ToString().Trim() + ", " + gD[2].ToString().Trim() + ", " + gD[3].ToString().Trim() + ", " + gD[4].ToString().Trim() + ", " + gD[5].ToString().Trim());
                writer.WriteLine("Random:\t\t" + gRand[0].ToString().Trim() + ", " + gRand[1].ToString().Trim() + ", " + gRand[2].ToString().Trim() + ", " + gRand[3].ToString().Trim());
                writer.WriteLine("Color:\t\t" + gColor.R.ToString().Trim() + "," + gColor.G.ToString().Trim() + "," + gColor.B.ToString().Trim());
                writer.Close();
            }
        }







    }
}

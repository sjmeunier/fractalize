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
    public partial class BrownianForm : Form
    {
        public int gWidth = 0;
        public int gHeight = 0;
        public double gMu = 0;
        public double gSigma = 0;
        public double gH = 0;
        public double gScale = 0;
        public int gSeed = 0;
        public Color gColor = new Color();


        public BrownianForm()
        {
            InitializeComponent();
        }

        private void cmdDraw_Click(object sender, EventArgs e)
        {

            gColor = Color.FromArgb(Convert.ToInt32(txtCol0.Text), Convert.ToInt32(txtCol1.Text), Convert.ToInt32(txtCol2.Text));
            gMu = Convert.ToDouble(txtMu.Text);
            gSigma = Convert.ToDouble(txtSigma.Text);
            gH = Convert.ToDouble(txtH.Text);
            gScale = Convert.ToInt32(txtScale.Text);
            gSeed = Convert.ToInt32(txtSeed.Text);
            gWidth = brownian1.Width;
            gHeight = brownian1.Height;

            Thread drawThread = new Thread(new ThreadStart(DrawImage));
            drawThread.Start();

            cmdSave.Enabled = true;
        }

        private void DrawImage()
        {
            statusStrip1.Items[1].Text = "Calculating...";
            brownian1.DrawBrownian(gMu, gSigma, gScale, gH, gSeed, gColor);
            statusStrip1.Items[1].Text = "Done";
        }

        private void BrownianForm_Resize(object sender, EventArgs e)
        {
            brownian1.Width = this.Width - 137;
            brownian1.Height = this.Height - 50;
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
                        brownian1.GetImage().Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        brownian1.GetImage().Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        brownian1.GetImage().Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }
        }

        private void BrownianForm_Load(object sender, EventArgs e)
        {
            brownian1.SetStatusStrip(ref statusStrip1);
            brownian1.Width = this.Width - 137;
            brownian1.Left = 129;
            brownian1.Height = this.Height - 50;

            gMu = 0;
            gSigma = 1.0;
            gH = 0.87;
            gScale = 80;
            gSeed = 3456;
            gColor = Color.FromArgb(255, 255, 0);
            gWidth = brownian1.Width;
            gHeight = brownian1.Height;

            txtMu.Text = gMu.ToString().Trim();
            txtSigma.Text = gSigma.ToString().Trim();
            txtH.Text = gH.ToString().Trim();
            txtScale.Text = gScale.ToString().Trim();
            txtSeed.Text = gSeed.ToString().Trim();
            txtCol0.Text = gColor.R.ToString().Trim();
            txtCol1.Text = gColor.G.ToString().Trim();
            txtCol2.Text = gColor.B.ToString().Trim();
        }

        public void LoadFromFile(string filename)
        {
            string fileLine;
            string[] colorBits;

            StreamReader reader = new StreamReader(filename);
            fileLine = reader.ReadLine();

            fileLine = reader.ReadLine();
            gWidth = Convert.ToInt32(fileLine.Split(':')[1].Trim());

            fileLine = reader.ReadLine();
            gHeight = Convert.ToInt32(fileLine.Split(':')[1].Trim());

            fileLine = reader.ReadLine();
            gMu = Convert.ToDouble(fileLine.Split(':')[1].Trim());

            fileLine = reader.ReadLine();
            gSigma = Convert.ToDouble(fileLine.Split(':')[1].Trim());

            fileLine = reader.ReadLine();
            gH = Convert.ToDouble(fileLine.Split(':')[1].Trim());

            fileLine = reader.ReadLine();
            gScale = Convert.ToDouble(fileLine.Split(':')[1].Trim());

            fileLine = reader.ReadLine();
            gSeed = Convert.ToInt32(fileLine.Split(':')[1].Trim());

            fileLine = reader.ReadLine();
            colorBits = fileLine.Split(':')[1].Trim().Split(',');
            gColor = Color.FromArgb(Convert.ToInt32(colorBits[0]), Convert.ToInt32(colorBits[1]), Convert.ToInt32(colorBits[2]));

            reader.Close();
            
            this.Width = gWidth + 137;
            this.Height = gHeight + 50;
            brownian1.Width = gWidth;
            brownian1.Height = gHeight;
            
            txtMu.Text = gMu.ToString().Trim();
            txtSigma.Text = gSigma.ToString().Trim();
            txtH.Text = gH.ToString().Trim();
            txtScale.Text = gScale.ToString().Trim();
            txtSeed.Text = gSeed.ToString().Trim();
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
                writer.WriteLine("Type:\t\tBrownian");
                writer.WriteLine("Width:\t\t" + gWidth.ToString().Trim());
                writer.WriteLine("Height:\t\t" + gHeight.ToString().Trim());
                writer.WriteLine("Mu:\t\t" + gMu.ToString().Trim());
                writer.WriteLine("Sigma:\t\t" + gSigma.ToString().Trim());
                writer.WriteLine("h:\t\t" + gH.ToString().Trim());
                writer.WriteLine("Scale:\t\t" + gScale.ToString().Trim());
                writer.WriteLine("Seed:\t\t" + gSeed.ToString().Trim());
                writer.WriteLine("Color:\t\t" + gColor.R.ToString().Trim() + "," + gColor.G.ToString().Trim() + "," + gColor.B.ToString().Trim());
                writer.Close();
            }
        }

    }
}

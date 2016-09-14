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
    public partial class BifurcationForm : Form
    {
        public double gR = 0;
        public double gDeltaR = 0;
        public int gWidth = 0;
        public int gHeight = 0;
        public Color gColor = new Color();

        public BifurcationForm()
        {
            InitializeComponent();
        }

        private void BifurcationForm_Load(object sender, EventArgs e)
        {
            bifurcation1.SetStatusStrip(ref statusStrip1);
            bifurcation1.Width = this.Width - 137;
            bifurcation1.Left = 129;
            bifurcation1.Height = this.Height - 50;

            gR = 0.05;
            gDeltaR = 0.005;
            gColor = Color.FromArgb(255, 255, 0);
            gWidth = bifurcation1.Width;
            gHeight = bifurcation1.Height;

            txtR.Text = gR.ToString().Trim();
            txtDeltaR.Text = gDeltaR.ToString().Trim();
            txtCol0.Text = gColor.R.ToString().Trim();
            txtCol1.Text = gColor.G.ToString().Trim();
            txtCol2.Text = gColor.B.ToString().Trim();
        }

        private void cmdDraw_Click(object sender, EventArgs e)
        {
            gColor = Color.FromArgb(Convert.ToInt32(txtCol0.Text), Convert.ToInt32(txtCol1.Text), Convert.ToInt32(txtCol2.Text));
            gR = Convert.ToDouble(txtR.Text);
            gDeltaR = Convert.ToDouble(txtDeltaR.Text);
            gWidth = bifurcation1.Width;
            gHeight = bifurcation1.Height;

            Thread drawThread = new Thread(new ThreadStart(DrawImage));
            drawThread.Start();

            cmdSave.Enabled = true;

        }

        private void DrawImage()
        {
            statusStrip1.Items[1].Text = "Calculating...";
            bifurcation1.DrawBifurcation(gR, gDeltaR, gColor);
            statusStrip1.Items[1].Text = "Done";

        }

        private void BifurcationForm_Resize(object sender, EventArgs e)
        {
            bifurcation1.Width = this.Width - 137;
            bifurcation1.Height = this.Height - 50;
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
                        bifurcation1.GetImage().Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        bifurcation1.GetImage().Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        bifurcation1.GetImage().Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }
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
            gR = Convert.ToDouble(fileLine.Split(':')[1].Trim());

            fileLine = reader.ReadLine();
            gDeltaR = Convert.ToDouble(fileLine.Split(':')[1].Trim());

            fileLine = reader.ReadLine();
            colorBits = fileLine.Split(':')[1].Trim().Split(',');
            gColor = Color.FromArgb(Convert.ToInt32(colorBits[0]), Convert.ToInt32(colorBits[1]), Convert.ToInt32(colorBits[2]));

            reader.Close();

            this.Width = gWidth + 137;
            this.Height = gHeight + 50;
            bifurcation1.Width = gWidth;
            bifurcation1.Height = gHeight;

            txtR.Text = gR.ToString().Trim();
            txtDeltaR.Text = gDeltaR.ToString().Trim();
            txtCol0.Text = gColor.R.ToString().Trim();
            txtCol1.Text = gColor.G.ToString().Trim();
            txtCol2.Text = gColor.B.ToString().Trim();

            Thread drawThread = new Thread(new ThreadStart(DrawImage));
            drawThread.Start();

            cmdSave.Enabled = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

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
                writer.WriteLine("Type:\t\tBifurcation");
                writer.WriteLine("Width:\t\t" + gWidth.ToString().Trim());
                writer.WriteLine("Height:\t\t" + gHeight.ToString().Trim());
                writer.WriteLine("r:\t\t" + gR.ToString().Trim());
                writer.WriteLine("Delta r:\t\t" + gDeltaR.ToString().Trim());
                writer.WriteLine("Color:\t\t" + gColor.R.ToString().Trim() + "," + gColor.G.ToString().Trim() + "," + gColor.B.ToString().Trim());
                writer.Close();
            }

        }

    }
}

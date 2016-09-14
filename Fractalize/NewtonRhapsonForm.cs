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
    public partial class NewtonRhapsonForm : Form
    {
        public int gWidth = 0;
        public int gHeight = 0;
        public int gIterations = 0;
        public int gSize = 0;
        public double gXMax = 0;
        public double gXMin = 0;
        public double gYMax = 0;
        public double gYMin = 0;

        public NewtonRhapsonForm()
        {
            InitializeComponent();
        }

        private void cmdDraw_Click(object sender, EventArgs e)
        {
            statusStrip1.Items[1].Text = "Calculating...";
            gIterations = Convert.ToInt32(txtIterations.Text);
            gSize = Convert.ToInt32(txtSize.Text);
            gXMax = Convert.ToDouble(txtXMax.Text);
            gXMin = Convert.ToDouble(txtXMin.Text);
            gYMax = Convert.ToDouble(txtYMax.Text);
            gYMin = Convert.ToDouble(txtYMin.Text);
            gWidth = newtonRhapson1.Width;
            gHeight = newtonRhapson1.Height;

            Thread drawThread = new Thread(new ThreadStart(DrawImage));
            drawThread.Start();

            cmdSave.Enabled = true;
        }

        private void DrawImage()
        {
            statusStrip1.Items[1].Text = "Calculating...";
            newtonRhapson1.DrawNewtonRhapson(gIterations, gSize, gXMax, gXMin, gYMax, gYMin);
            statusStrip1.Items[1].Text = "Done";

        }

        private void NewtonRhapsonForm_Resize(object sender, EventArgs e)
        {
            newtonRhapson1.Width = this.Width - 137;
            newtonRhapson1.Height = this.Height - 50;
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
                        newtonRhapson1.GetImage().Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        newtonRhapson1.GetImage().Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        newtonRhapson1.GetImage().Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }
        }

        private void NewtonRhapsonForm_Load(object sender, EventArgs e)
        {
            newtonRhapson1.SetStatusStrip(ref statusStrip1);
            newtonRhapson1.Width = this.Width - 137;
            newtonRhapson1.Left = 129;
            newtonRhapson1.Height = this.Height - 50;

            gIterations = 150;
            gSize = 4;
            gXMax = 3.5;
            gXMin = -3.5;
            gYMax = 2.5;
            gYMin = -2.5;
            gWidth = newtonRhapson1.Width;
            gHeight = newtonRhapson1.Height;

            txtIterations.Text = gIterations.ToString().Trim();
            txtSize.Text = gSize.ToString().Trim();
            txtXMax.Text = gXMax.ToString().Trim();
            txtXMin.Text = gXMin.ToString().Trim();
            txtYMax.Text = gYMax.ToString().Trim();
            txtYMin.Text = gYMin.ToString().Trim();
        }

        public void LoadFromFile(string filename)
        {
            string fileLine;

            StreamReader reader = new StreamReader(filename);
            fileLine = reader.ReadLine();

            fileLine = reader.ReadLine();
            gWidth = Convert.ToInt32(fileLine.Split(':')[1].Trim());

            fileLine = reader.ReadLine();
            gHeight = Convert.ToInt32(fileLine.Split(':')[1].Trim());

            fileLine = reader.ReadLine();
            gIterations = Convert.ToInt32(fileLine.Split(':')[1].Trim());

            fileLine = reader.ReadLine();
            gSize = Convert.ToInt32(fileLine.Split(':')[1].Trim());

            fileLine = reader.ReadLine();
            gXMax = Convert.ToDouble(fileLine.Split(':')[1].Trim());

            fileLine = reader.ReadLine();
            gXMin = Convert.ToDouble(fileLine.Split(':')[1].Trim());

            fileLine = reader.ReadLine();
            gYMax = Convert.ToDouble(fileLine.Split(':')[1].Trim());

            fileLine = reader.ReadLine();
            gYMin = Convert.ToDouble(fileLine.Split(':')[1].Trim());

            reader.Close();

            this.Width = gWidth + 137;
            this.Height = gHeight + 29;
            newtonRhapson1.Width = gWidth;
            newtonRhapson1.Height = gHeight;
            txtIterations.Text = gIterations.ToString().Trim();
            txtSize.Text = gSize.ToString().Trim();
            txtXMax.Text = gXMax.ToString().Trim();
            txtXMin.Text = gXMin.ToString().Trim();
            txtYMax.Text = gYMax.ToString().Trim();
            txtYMin.Text = gYMin.ToString().Trim();

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
                writer.WriteLine("Type:\t\tNewtonRhapson");
                writer.WriteLine("Width:\t\t" + gWidth.ToString().Trim());
                writer.WriteLine("Height:\t\t" + gHeight.ToString().Trim());
                writer.WriteLine("Iterations:\t\t" + gIterations.ToString().Trim());
                writer.WriteLine("Size:\t\t" + gSize.ToString().Trim());
                writer.WriteLine("XMax:\t\t" + gXMax.ToString().Trim());
                writer.WriteLine("XMin:\t\t" + gXMin.ToString().Trim());
                writer.WriteLine("YMax:\t\t" + gYMax.ToString().Trim());
                writer.WriteLine("YMin:\t\t" + gYMin.ToString().Trim());
                writer.Close();
            }
        }


    }
}

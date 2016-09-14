﻿using System;
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
    public partial class MandelbrotForm : Form
    {
        public int gIterations = 0;
        public int gSize = 0;
        public int gLeft = 0;
        public int gTop = 0;
        public int gPower1 = 0;
        public int gPower2 = 0;
        public double gXOffset = 0;
        public double gYOffset = 0;
        public double gScaling = 1;
        public int gWidth = 0;
        public int gHeight = 0;

        private double[,] zoomData = new double[1000, 3];
        private int zoomCount = -1;

        public MandelbrotForm()
        {
            InitializeComponent();
        }

        private void cmdDraw_Click(object sender, EventArgs e)
        {

            gIterations = Convert.ToInt32(txtIterations.Text);
            gSize = Convert.ToInt32(txtSize.Text);
            gLeft = 0;
            gTop = 0;
            gXOffset = Convert.ToDouble(txtXOffset.Text);
            gYOffset = Convert.ToDouble(txtYOffset.Text);
            gPower1 = Convert.ToInt32(cboPower.Text);
            gPower2 = Convert.ToInt32(cboPower2.Text);
            gScaling = 1;
            gWidth = mandelbrot1.Width;
            gHeight = mandelbrot1.Height;
            zoomCount = -1;

            Thread drawThread = new Thread(new ThreadStart(DrawImage));
            drawThread.Start();
            cmdZoomIn.Enabled = true;
            cmdZoomOut.Enabled = false;
            cmdSave.Enabled = true;

        }

        private void DrawImage()
        {
            statusStrip1.Items[1].Text = "Calculating...";
            mandelbrot1.DrawMandelbrot(gIterations, gScaling, gSize, gXOffset, gYOffset, gLeft, gTop, gPower1, gPower2);
            statusStrip1.Items[1].Text = "Done";

        }

        private void MandelbrotForm_Resize(object sender, EventArgs e)
        {
            mandelbrot1.Width = this.Width - 137;
            mandelbrot1.Height = this.Height - 50;
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
                        mandelbrot1.GetImage().Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        mandelbrot1.GetImage().Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        mandelbrot1.GetImage().Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }
        }

        private void MandelbrotForm_Load(object sender, EventArgs e)
        {
            cboPower.SelectedIndex = 2;
            cboPower2.SelectedIndex = 0;
            mandelbrot1.SetStatusStrip(ref this.statusStrip1);
            mandelbrot1.Width = this.Width - 137;
            mandelbrot1.Left = 129;
            mandelbrot1.Height = this.Height - 50;
            gIterations = 150;
            gScaling = 1;
            gSize = 200;
            gXOffset = -0.5;
            gYOffset = 0;
            gPower1 = 2;
            gPower2 = 0;
            gWidth = mandelbrot1.Width;
            gHeight = mandelbrot1.Height;

            txtIterations.Text = gIterations.ToString().Trim();
            txtSize.Text = gSize.ToString().Trim();
            txtXOffset.Text = gXOffset.ToString().Trim();
            txtYOffset.Text = gYOffset.ToString().Trim();
            cboPower.Text = gPower1.ToString().Trim();
            cboPower2.Text = gPower2.ToString().Trim();

        }

        public void LoadFromFile(string filename)
        {
            statusStrip1.Items[1].Text = "Calculating...";

            string fileLine;

            StreamReader reader = new StreamReader(filename);
            fileLine = reader.ReadLine();

            fileLine = reader.ReadLine();
            gWidth = Convert.ToInt32(fileLine.Split(':')[1].Trim());

            fileLine = reader.ReadLine();
            gHeight = Convert.ToInt32(fileLine.Split(':')[1].Trim());

            fileLine = reader.ReadLine();
            gPower1 = Convert.ToInt32(fileLine.Split(':')[1].Trim());

            fileLine = reader.ReadLine();
            gPower2 = Convert.ToInt32(fileLine.Split(':')[1].Trim());

            fileLine = reader.ReadLine();
            gIterations = Convert.ToInt32(fileLine.Split(':')[1].Trim());

            fileLine = reader.ReadLine();
            gScaling = Convert.ToDouble(fileLine.Split(':')[1].Trim());

            fileLine = reader.ReadLine();
            gSize = Convert.ToInt32(fileLine.Split(':')[1].Trim());

            fileLine = reader.ReadLine();
            gLeft = Convert.ToInt32(fileLine.Split(':')[1].Trim());

            fileLine = reader.ReadLine();
            gTop = Convert.ToInt32(fileLine.Split(':')[1].Trim());

            fileLine = reader.ReadLine();
            gXOffset = Convert.ToDouble(fileLine.Split(':')[1].Trim());

            fileLine = reader.ReadLine();
            gYOffset = Convert.ToDouble(fileLine.Split(':')[1].Trim());

            reader.Close();

            this.Width = gWidth + 137;
            this.Height = gHeight + 50;
            mandelbrot1.Width = gWidth;
            mandelbrot1.Height = gHeight;

            txtIterations.Text = gIterations.ToString().Trim();
            txtSize.Text = gSize.ToString().Trim();
            txtXOffset.Text = gXOffset.ToString().Trim();
            txtYOffset.Text = gYOffset.ToString().Trim();
            cboPower.Text = gPower1.ToString().Trim();
            cboPower2.Text = gPower2.ToString().Trim();

            Thread drawThread = new Thread(new ThreadStart(DrawImage));
            drawThread.Start();

            zoomCount = -1;

            cmdZoomIn.Enabled = true;
            cmdZoomOut.Enabled = false;
            cmdSave.Enabled = true;


        }


        public void UpdateStatus(int panel, string message)
        {
            statusStrip1.Items[panel].Text = message;
        }

        private void cmdZoomIn_Click(object sender, EventArgs e)
        {

            zoomCount++;
            zoomData[zoomCount, 0] = gScaling;
            zoomData[zoomCount, 1] = gXOffset;
            zoomData[zoomCount, 2] = gYOffset;

            double newScaling = (((double)mandelbrot1.selectHeight) / (double)gHeight) * gScaling;
            double newXOffset = (((double)(mandelbrot1.selectX + (mandelbrot1.selectWidth / 2.0)) - (gWidth / 2.0)) / (gSize / gScaling)) + gXOffset;
            double newYOffset = (((double)(mandelbrot1.selectY + (mandelbrot1.selectHeight / 2.0)) - (gHeight / 2.0)) / (gSize / gScaling)) + gYOffset;

            gScaling = newScaling;
            gXOffset = newXOffset;
            gYOffset = newYOffset;

            txtXOffset.Text = gXOffset.ToString().Trim();
            txtYOffset.Text = gYOffset.ToString().Trim();

            Thread drawThread = new Thread(new ThreadStart(DrawImage));
            drawThread.Start();

            cmdZoomOut.Enabled = true;


        }

        private void cmdZoomOut_Click(object sender, EventArgs e)
        {

            gScaling = zoomData[zoomCount, 0];
            gXOffset = zoomData[zoomCount, 1];
            gYOffset = zoomData[zoomCount, 2];
            zoomCount--;

            txtXOffset.Text = gXOffset.ToString().Trim();
            txtYOffset.Text = gYOffset.ToString().Trim();

            Thread drawThread = new Thread(new ThreadStart(DrawImage));
            drawThread.Start();
            if (zoomCount == -1)
            {
                cmdZoomOut.Enabled = false;
            }

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
                writer.WriteLine("Type:\t\tMandelbrot");
                writer.WriteLine("Width:\t\t" + gWidth.ToString().Trim());
                writer.WriteLine("Height:\t\t" + gHeight.ToString().Trim());
                writer.WriteLine("Power1:\t\t" + gPower1.ToString().Trim());
                writer.WriteLine("Power2:\t\t" + gPower2.ToString().Trim());
                writer.WriteLine("Iterations:\t\t" + gIterations.ToString().Trim());
                writer.WriteLine("Scaling:\t\t" + gScaling.ToString().Trim());
                writer.WriteLine("Size:\t\t" + gSize.ToString().Trim());
                writer.WriteLine("Left:\t\t" + gLeft.ToString().Trim());
                writer.WriteLine("Top:\t\t" + gTop.ToString().Trim());
                writer.WriteLine("XOffset:\t\t" + gXOffset.ToString().Trim());
                writer.WriteLine("YOffset:\t\t" + gYOffset.ToString().Trim());
                writer.Close();
            }
        }




    }
}

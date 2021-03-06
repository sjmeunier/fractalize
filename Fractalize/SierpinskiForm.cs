﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading;


namespace Fractalize
{
    public partial class SierpinskiForm : Form
    {
        public int gWidth = 0;
        public int gHeight = 0;
        public int gIterations = 0;
        public string gShape;

        public Color gColor = new Color();

        public SierpinskiForm()
        {
            InitializeComponent();
        }

        private void cmdDraw_Click(object sender, EventArgs e)
        {
            gColor = Color.FromArgb(Convert.ToInt32(txtCol0.Text), Convert.ToInt32(txtCol1.Text), Convert.ToInt32(txtCol2.Text));
            gIterations = Convert.ToInt32(txtIterations.Text);
            gShape = cboType.Text;
            gWidth = sierpinski1.Width;
            gHeight = sierpinski1.Height;

            Thread drawThread = new Thread(new ThreadStart(DrawImage));
            drawThread.Start();

            cmdSave.Enabled = true;
        }


        private void DrawImage()
        {
            statusStrip1.Items[1].Text = "Calculating...";
            if (gShape == "Triangle")
            {
                sierpinski1.DrawSierpinskiTriangle(gIterations, gColor);
            }
            else if (gShape == "Square")
            {
                sierpinski1.DrawSierpinskiSquare(gIterations, gColor);
            }
            statusStrip1.Items[1].Text = "Done";

        }
        private void SierpinskiForm_Resize(object sender, EventArgs e)
        {
            sierpinski1.Width = this.Width - 137;
            sierpinski1.Height = this.Height - 50;
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
                        sierpinski1.GetImage().Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        sierpinski1.GetImage().Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        sierpinski1.GetImage().Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }

        }

        private void SierpinskiForm_Load(object sender, EventArgs e)
        {
            cboType.SelectedIndex = 0;
            sierpinski1.SetStatusStrip(ref statusStrip1);
            sierpinski1.Width = this.Width - 137;
            sierpinski1.Left = 129;
            sierpinski1.Height = this.Height - 50;

            gIterations = 7;
            gShape = "Triangle";
            gColor = Color.FromArgb(255, 255, 0);
            gWidth = sierpinski1.Width;
            gHeight = sierpinski1.Height;

            txtIterations.Text = gIterations.ToString().Trim();
            cboType.Text = gShape;
            txtCol0.Text = gColor.R.ToString().Trim();
            txtCol1.Text = gColor.G.ToString().Trim();
            txtCol2.Text = gColor.B.ToString().Trim();
        }

        public void LoadFromParams(int width, int height, string shape, int iterations, Color oColor)
        {
            this.Width = width + 137;
            this.Height = height + 29;
            sierpinski1.Width = width;
            sierpinski1.Height = height;
            cboType.Text = shape.ToString().Trim();
            txtIterations.Text = iterations.ToString();
            txtCol0.Text = oColor.R.ToString().Trim();
            txtCol1.Text = oColor.G.ToString().Trim();
            txtCol2.Text = oColor.B.ToString().Trim();

            if (shape == "Triangle")
            {
                sierpinski1.DrawSierpinskiTriangle(iterations, oColor);
            }
            else
            {
                sierpinski1.DrawSierpinskiSquare(iterations, oColor);
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
            gShape = fileLine.Split(':')[1].Trim();

            fileLine = reader.ReadLine();
            gIterations = Convert.ToInt32(fileLine.Split(':')[1].Trim());

            fileLine = reader.ReadLine();
            colorBits = fileLine.Split(':')[1].Trim().Split(',');
            gColor = Color.FromArgb(Convert.ToInt32(colorBits[0]), Convert.ToInt32(colorBits[1]), Convert.ToInt32(colorBits[2]));
            reader.Close();

            this.Width = gWidth + 137;
            this.Height = gHeight + 29;
            sierpinski1.Width = gWidth;
            sierpinski1.Height = gHeight;
            if (gShape == "Triangle")
            {
                cboType.SelectedIndex = 0;
            }
            else
            {
                cboType.SelectedIndex = 1;
            }
            txtIterations.Text = gIterations.ToString();
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
                writer.WriteLine("Type:\t\tSierpinski");
                writer.WriteLine("Width:\t\t" + gWidth.ToString().Trim());
                writer.WriteLine("Height:\t\t" + gHeight.ToString().Trim());
                writer.WriteLine("Shape:\t\t" + gShape);
                writer.WriteLine("Iterations:\t\t" + gIterations.ToString().Trim());
                writer.WriteLine("Color:\t\t" + gColor.R.ToString().Trim() + "," + gColor.G.ToString().Trim() + "," + gColor.B.ToString().Trim());
                writer.Close();
            }

        }

    }
}

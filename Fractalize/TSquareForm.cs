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
    public partial class TSquareForm : Form
    {
        public int gWidth = 0;
        public int gHeight = 0;
        public int gIterations = 0;
        public Color gColor = new Color();

        public TSquareForm()
        {
            InitializeComponent();
        }

        private void cmdDraw_Click(object sender, EventArgs e)
        {
            gColor = Color.FromArgb(Convert.ToInt32(txtCol0.Text), Convert.ToInt32(txtCol1.Text), Convert.ToInt32(txtCol2.Text));
            gIterations = Convert.ToInt32(txtIterations.Text);
            gWidth = tSquare1.Width;
            gHeight = tSquare1.Height;

            Thread drawThread = new Thread(new ThreadStart(DrawImage));
            drawThread.Start();

            cmdSave.Enabled = true;
        }

        private void DrawImage()
        {
            statusStrip1.Items[1].Text = "Calculating...";
            tSquare1.DrawTSquare(gIterations, gColor);
            statusStrip1.Items[1].Text = "Done";

        }

        private void TSquareForm_Resize(object sender, EventArgs e)
        {
            tSquare1.Width = this.Width - 137;
            tSquare1.Height = this.Height - 50;

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
                        tSquare1.GetImage().Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        tSquare1.GetImage().Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        tSquare1.GetImage().Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }

        }

        private void TSquareForm_Load(object sender, EventArgs e)
        {
            tSquare1.SetStatusStrip(ref statusStrip1);
            tSquare1.Width = this.Width - 137;
            tSquare1.Left = 129;
            tSquare1.Height = this.Height - 50;

            gIterations = 7;
            gColor = Color.FromArgb(255, 255, 0);
            gWidth = tSquare1.Width;
            gHeight = tSquare1.Height;

            txtIterations.Text = gIterations.ToString().Trim();
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
            gIterations = Convert.ToInt32(fileLine.Split(':')[1].Trim());

            fileLine = reader.ReadLine();
            colorBits = fileLine.Split(':')[1].Trim().Split(',');
            gColor = Color.FromArgb(Convert.ToInt32(colorBits[0]), Convert.ToInt32(colorBits[1]), Convert.ToInt32(colorBits[2]));
            reader.Close();
            this.Width = gWidth + 137;
            this.Height = gHeight + 29;
            tSquare1.Width = gWidth;
            tSquare1.Height = gHeight;
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
                writer.WriteLine("Type:\t\tTSquare");
                writer.WriteLine("Width:\t\t" + gWidth.ToString().Trim());
                writer.WriteLine("Height:\t\t" + gHeight.ToString().Trim());
                writer.WriteLine("Iterations:\t\t" + gIterations.ToString().Trim());
                writer.WriteLine("Color:\t\t" + gColor.R.ToString().Trim() + "," + gColor.G.ToString().Trim() + "," + gColor.B.ToString().Trim());
                writer.Close();
            }
        }
    }
}

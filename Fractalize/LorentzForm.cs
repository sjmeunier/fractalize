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
    public partial class LorentzForm : Form
    {
        public int gDimensions = 0;
        public int gWidth = 0;
        public int gHeight = 0;

        public LorentzForm()
        {
            InitializeComponent();
        }

        private void LorentzForm_Load(object sender, EventArgs e)
        {
            lorentz1.SetStatusStrip(ref statusStrip1);
            lorentz1.Width = this.Width - 137;
            lorentz1.Height = this.Height - 50;
            lorentz1.Left = 129;
            cboDim.SelectedIndex = 0;
            gDimensions = 2;
            gHeight = lorentz1.Height;
            gWidth = lorentz1.Width;

            cboDim.Text = gDimensions.ToString().Trim();
        }

        private void cmdDraw_Click(object sender, EventArgs e)
        {
            
            gDimensions = Convert.ToInt32(cboDim.Text);
            gWidth = lorentz1.Width;
            gHeight = lorentz1.Height;

            Thread drawThread = new Thread(new ThreadStart(DrawImage));
            drawThread.Start();

            cmdSave.Enabled = true;
        }

        private void DrawImage()
        {
            statusStrip1.Items[1].Text = "Calculating...";
            lorentz1.DrawLorentz(gDimensions);
            statusStrip1.Items[1].Text = "Done";

        }
        private void LorentzForm_Resize(object sender, EventArgs e)
        {
            lorentz1.Width = this.Width - 137;
            lorentz1.Height = this.Height - 50;
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
                        lorentz1.GetImage().Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        lorentz1.GetImage().Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        lorentz1.GetImage().Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }

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
            gDimensions = Convert.ToInt32(fileLine.Split(':')[1].Trim());

            reader.Close();

            this.Width = gWidth + 137;
            this.Height = gHeight + 29;
            lorentz1.Width = gWidth;
            lorentz1.Height = gHeight;
            cboDim.Text = gDimensions.ToString().Trim();

            Thread drawThread = new Thread(new ThreadStart(DrawImage));
            drawThread.Start();


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
                writer.WriteLine("Dimensions:\t" + gDimensions.ToString().Trim());
                writer.Close();
            }
        }
    }
}

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
    public partial class PlasmaForm : Form
    {
        public int gWidth = 0;
        public int gHeight = 0;
        public int gRoughness = 0;
        public string gType;

        public PlasmaForm()
        {
            InitializeComponent();
        }

        private void cmdDraw_Click(object sender, EventArgs e)
        {
            gRoughness = Convert.ToInt32(txtRoughness.Text);
            switch (cboType.SelectedIndex)
            {
                case 0:
                    gType = "Plasma";
                    break;
                case 1:
                    gType = "Cloud";
                    break;
                case 2:
                    gType = "Grey";
                    break;
            }
            gWidth = plasma1.Width;
            gHeight = plasma1.Height;

            Thread drawThread = new Thread(new ThreadStart(DrawImage));
            drawThread.Start();

            cmdSave.Enabled = true;
        }

        private void DrawImage()
        {
            statusStrip1.Items[1].Text = "Calculating...";
            plasma1.DrawPlasma(gRoughness, gType);

            statusStrip1.Items[1].Text = "Done";

        }

        private void PlasmaForm_Resize(object sender, EventArgs e)
        {
            plasma1.Width = this.Width - 137;
            plasma1.Height = this.Height - 50;
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
                        plasma1.GetImage().Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        plasma1.GetImage().Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        plasma1.GetImage().Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
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
            gRoughness = Convert.ToInt32(fileLine.Split(':')[1].Trim());

            fileLine = reader.ReadLine();
            gType = fileLine.Split(':')[1].Trim();

            reader.Close();

            this.Width = gWidth + 137;
            this.Height = gHeight + 29;
            plasma1.Width = gWidth;
            plasma1.Height = gHeight;
            txtRoughness.Text = gRoughness.ToString().Trim();

            switch (gType)
            {
                case "Plasma":
                    cboType.SelectedIndex = 0;
                    break;
                case "Cloud":
                    cboType.SelectedIndex = 1;
                    break;
                case "Grey":
                    cboType.SelectedIndex = 2;
                    break;
            }

            Thread drawThread = new Thread(new ThreadStart(DrawImage));
            drawThread.Start();

            cmdSave.Enabled = true;

        }

       

        private void PlasmaForm_Load(object sender, EventArgs e)
        {
            plasma1.SetStatusStrip(ref statusStrip1);
            plasma1.Width = this.Width - 137;
            plasma1.Left = 129;
            plasma1.Height = this.Height - 50;

            gRoughness = 3;
            gType = "Plasma";
            cboType.SelectedIndex = 0;
 
            gWidth = plasma1.Width;
            gHeight = plasma1.Height;

            txtRoughness.Text = gRoughness.ToString().Trim();
            cboType.Text = gType;
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
                writer.WriteLine("Type:\t\tPlasma");
                writer.WriteLine("Width:\t\t" + gWidth.ToString().Trim());
                writer.WriteLine("Height:\t\t" + gHeight.ToString().Trim());
                writer.WriteLine("Roughness:\t\t" + gRoughness.ToString().Trim());
                writer.WriteLine("Type:\t\t" + gType);
                writer.Close();
            }
        }
    }
}

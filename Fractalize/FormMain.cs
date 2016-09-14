using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Fractalize
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();

        }

        private void fernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FernForm fernForm = new FernForm();
            fernForm.MdiParent = this;
            fernForm.Show();
        }

        private void brownianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrownianForm brownianForm = new BrownianForm();
            brownianForm.MdiParent = this;
            brownianForm.Show();
        }

        private void bifurcationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BifurcationForm bifurcationForm = new BifurcationForm();
            bifurcationForm.MdiParent = this;
            bifurcationForm.Show();

        }

        private void juliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JuliaForm juliaForm = new JuliaForm();
            juliaForm.MdiParent = this;
            juliaForm.Show();
        }

        private void lorenzAttractorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LorentzForm lorentzForm = new LorentzForm();
            lorentzForm.MdiParent = this;
            lorentzForm.Show();
        }

        private void mandelbrotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MandelbrotForm mandelbrotForm = new MandelbrotForm();
            mandelbrotForm.MdiParent = this;
            mandelbrotForm.Show();
        }

        private void newtonRhapsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewtonRhapsonForm newtonRhapsonForm = new NewtonRhapsonForm();
            newtonRhapsonForm.MdiParent = this;
            newtonRhapsonForm.Show();
        }

        private void plasmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlasmaForm plasmaForm = new PlasmaForm();
            plasmaForm.MdiParent = this;
            plasmaForm.Show();
        }

        private void sierpinksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SierpinskiForm sierpinskiForm = new SierpinskiForm();
            sierpinskiForm.MdiParent = this;
            sierpinskiForm.Show();
        }

        private void tSquareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TSquareForm tSquareForm = new TSquareForm();
            tSquareForm.MdiParent = this;
            tSquareForm.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                ProcessFile(openFileDialog1.FileName);
            }
        }

        public void ProcessFile(string filename)
        {
            string fractalType;
            string fileLine;

            StreamReader reader = new StreamReader(filename);
            fileLine = reader.ReadLine();
            fractalType = fileLine.Split(':')[1].Trim();
            reader.Close();
            switch (fractalType)
            {
                case "Bifurcation":
                    BifurcationForm bifurcationForm = new BifurcationForm();
                    bifurcationForm.MdiParent = this;
                    bifurcationForm.Show();
                    bifurcationForm.LoadFromFile(filename);
                    break;

                case "Brownian":
                    BrownianForm brownianForm = new BrownianForm();
                    brownianForm.MdiParent = this;
                    brownianForm.Show();
                    brownianForm.LoadFromFile(filename);
                    break;

                case "Fern":
                    FernForm fernForm = new FernForm();
                    fernForm.MdiParent = this;
                    fernForm.Show();
                    fernForm.LoadFromFile(filename);
                    break;

                case "Julia":
                    JuliaForm juliaForm = new JuliaForm();
                    juliaForm.MdiParent = this;
                    juliaForm.Show();
                    juliaForm.LoadFromFile(filename);
                    break;

                case "Lorentz":
                    LorentzForm lorentzForm = new LorentzForm();
                    lorentzForm.MdiParent = this;
                    lorentzForm.Show();
                    lorentzForm.LoadFromFile(filename);
                    break;

                case "Mandelbrot":
                    MandelbrotForm mandelbrotForm = new MandelbrotForm();
                    mandelbrotForm.MdiParent = this;
                    mandelbrotForm.Show();
                    mandelbrotForm.LoadFromFile(filename);
                    break;

                case "NewtonRhapson":
                    NewtonRhapsonForm newtonRhapsonForm = new NewtonRhapsonForm();
                    newtonRhapsonForm.MdiParent = this;
                    newtonRhapsonForm.Show();
                    newtonRhapsonForm.LoadFromFile(filename);
                    break;

                case "Plasma":
                    PlasmaForm plasmaForm = new PlasmaForm();
                    plasmaForm.MdiParent = this;
                    plasmaForm.Show();
                    plasmaForm.LoadFromFile(filename);
                    break;

                case "Sierpinski":
                    SierpinskiForm sierpinskiForm = new SierpinskiForm();
                    sierpinskiForm.MdiParent = this;
                    sierpinskiForm.Show();
                    sierpinskiForm.LoadFromFile(filename);
                    break;

                case "TSquare":
                    TSquareForm tSquareForm = new TSquareForm();
                    tSquareForm.MdiParent = this;
                    tSquareForm.Show();
                    tSquareForm.LoadFromFile(filename);
                    break;
            }
            
        }
    }
}

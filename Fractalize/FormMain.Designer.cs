namespace Fractalize
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bifurcationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brownianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lorenzAttractorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mandelbrotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newtonRhapsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plasmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sierpinksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tSquareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadFileToolStripMenuItem.Text = "&Load File...";
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bifurcationToolStripMenuItem,
            this.brownianToolStripMenuItem,
            this.fernToolStripMenuItem,
            this.juliaToolStripMenuItem,
            this.lorenzAttractorToolStripMenuItem,
            this.mandelbrotToolStripMenuItem,
            this.newtonRhapsonToolStripMenuItem,
            this.plasmaToolStripMenuItem,
            this.sierpinksiToolStripMenuItem,
            this.tSquareToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItem1.Text = "&Action";
            // 
            // bifurcationToolStripMenuItem
            // 
            this.bifurcationToolStripMenuItem.Name = "bifurcationToolStripMenuItem";
            this.bifurcationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bifurcationToolStripMenuItem.Text = "&Bifurcation";
            this.bifurcationToolStripMenuItem.Click += new System.EventHandler(this.bifurcationToolStripMenuItem_Click);
            // 
            // brownianToolStripMenuItem
            // 
            this.brownianToolStripMenuItem.Name = "brownianToolStripMenuItem";
            this.brownianToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.brownianToolStripMenuItem.Text = "&Brownian";
            this.brownianToolStripMenuItem.Click += new System.EventHandler(this.brownianToolStripMenuItem_Click);
            // 
            // fernToolStripMenuItem
            // 
            this.fernToolStripMenuItem.Name = "fernToolStripMenuItem";
            this.fernToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fernToolStripMenuItem.Text = "&Fern";
            this.fernToolStripMenuItem.Click += new System.EventHandler(this.fernToolStripMenuItem_Click);
            // 
            // juliaToolStripMenuItem
            // 
            this.juliaToolStripMenuItem.Name = "juliaToolStripMenuItem";
            this.juliaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.juliaToolStripMenuItem.Text = "&Julia";
            this.juliaToolStripMenuItem.Click += new System.EventHandler(this.juliaToolStripMenuItem_Click);
            // 
            // lorenzAttractorToolStripMenuItem
            // 
            this.lorenzAttractorToolStripMenuItem.Name = "lorenzAttractorToolStripMenuItem";
            this.lorenzAttractorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lorenzAttractorToolStripMenuItem.Text = "&Lorenz Attractor";
            this.lorenzAttractorToolStripMenuItem.Click += new System.EventHandler(this.lorenzAttractorToolStripMenuItem_Click);
            // 
            // mandelbrotToolStripMenuItem
            // 
            this.mandelbrotToolStripMenuItem.Name = "mandelbrotToolStripMenuItem";
            this.mandelbrotToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mandelbrotToolStripMenuItem.Text = "&Mandelbrot";
            this.mandelbrotToolStripMenuItem.Click += new System.EventHandler(this.mandelbrotToolStripMenuItem_Click);
            // 
            // newtonRhapsonToolStripMenuItem
            // 
            this.newtonRhapsonToolStripMenuItem.Name = "newtonRhapsonToolStripMenuItem";
            this.newtonRhapsonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newtonRhapsonToolStripMenuItem.Text = "&Newton-Rhapson";
            this.newtonRhapsonToolStripMenuItem.Click += new System.EventHandler(this.newtonRhapsonToolStripMenuItem_Click);
            // 
            // plasmaToolStripMenuItem
            // 
            this.plasmaToolStripMenuItem.Name = "plasmaToolStripMenuItem";
            this.plasmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.plasmaToolStripMenuItem.Text = "&Plasma";
            this.plasmaToolStripMenuItem.Click += new System.EventHandler(this.plasmaToolStripMenuItem_Click);
            // 
            // sierpinksiToolStripMenuItem
            // 
            this.sierpinksiToolStripMenuItem.Name = "sierpinksiToolStripMenuItem";
            this.sierpinksiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sierpinksiToolStripMenuItem.Text = "&Sierpinksi";
            this.sierpinksiToolStripMenuItem.Click += new System.EventHandler(this.sierpinksiToolStripMenuItem_Click);
            // 
            // tSquareToolStripMenuItem
            // 
            this.tSquareToolStripMenuItem.Name = "tSquareToolStripMenuItem";
            this.tSquareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tSquareToolStripMenuItem.Text = "&T-Square";
            this.tSquareToolStripMenuItem.Click += new System.EventHandler(this.tSquareToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowToolStripMenuItem.Text = "&Window";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.cascadeToolStripMenuItem.Text = "&Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.tileVerticalToolStripMenuItem.Text = "Tile &Vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.tileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.tileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.closeAllToolStripMenuItem.Text = "C&lose All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.closeAllToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.arrangeIconsToolStripMenuItem.Text = "&Arrange Icons";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.arrangeIconsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Text files|*.txt|All files|*.*";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 662);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Fractalize";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brownianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bifurcationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem juliaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lorenzAttractorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mandelbrotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newtonRhapsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plasmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sierpinksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tSquareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


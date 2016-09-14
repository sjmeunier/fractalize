namespace Fractalize
{
    partial class BifurcationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BifurcationForm));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdDraw = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCol2 = new FractalDraw.NumericTextbox();
            this.txtCol0 = new FractalDraw.NumericTextbox();
            this.txtCol1 = new FractalDraw.NumericTextbox();
            this.txtDeltaR = new FractalDraw.NumericTextbox();
            this.txtR = new FractalDraw.NumericTextbox();
            this.bifurcation1 = new FractalDraw.Bifurcation();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panXY = new System.Windows.Forms.ToolStripStatusLabel();
            this.panStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panCoord = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmdExport = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(4, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 112;
            this.label7.Text = "Delta r";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(4, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 110;
            this.label6.Text = "r";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cmdDraw
            // 
            this.cmdDraw.Location = new System.Drawing.Point(51, 117);
            this.cmdDraw.Name = "cmdDraw";
            this.cmdDraw.Size = new System.Drawing.Size(65, 24);
            this.cmdDraw.TabIndex = 5;
            this.cmdDraw.Text = "&Draw";
            this.cmdDraw.Click += new System.EventHandler(this.cmdDraw_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Enabled = false;
            this.cmdSave.Location = new System.Drawing.Point(51, 147);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(65, 24);
            this.cmdSave.TabIndex = 6;
            this.cmdSave.Text = "&Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 146;
            this.label1.Text = "Color";
            // 
            // txtCol2
            // 
            this.txtCol2.CommaFormat = false;
            this.txtCol2.CurrencyFormat = false;
            this.txtCol2.DecimalPrecision = 0;
            this.txtCol2.DisableFormat = false;
            this.txtCol2.Location = new System.Drawing.Point(84, 81);
            this.txtCol2.MaxValue = 255;
            this.txtCol2.MinValue = 0;
            this.txtCol2.Name = "txtCol2";
            this.txtCol2.PercentFormat = false;
            this.txtCol2.ReadOnly = false;
            this.txtCol2.Size = new System.Drawing.Size(32, 20);
            this.txtCol2.TabIndex = 4;
            this.txtCol2.UseMaxMin = true;
            // 
            // txtCol0
            // 
            this.txtCol0.CommaFormat = false;
            this.txtCol0.CurrencyFormat = false;
            this.txtCol0.DecimalPrecision = 0;
            this.txtCol0.DisableFormat = false;
            this.txtCol0.Location = new System.Drawing.Point(7, 81);
            this.txtCol0.MaxValue = 255;
            this.txtCol0.MinValue = 0;
            this.txtCol0.Name = "txtCol0";
            this.txtCol0.PercentFormat = false;
            this.txtCol0.ReadOnly = false;
            this.txtCol0.Size = new System.Drawing.Size(32, 20);
            this.txtCol0.TabIndex = 2;
            this.txtCol0.UseMaxMin = true;
            // 
            // txtCol1
            // 
            this.txtCol1.CommaFormat = false;
            this.txtCol1.CurrencyFormat = false;
            this.txtCol1.DecimalPrecision = 0;
            this.txtCol1.DisableFormat = false;
            this.txtCol1.Location = new System.Drawing.Point(46, 81);
            this.txtCol1.MaxValue = 255;
            this.txtCol1.MinValue = 0;
            this.txtCol1.Name = "txtCol1";
            this.txtCol1.PercentFormat = false;
            this.txtCol1.ReadOnly = false;
            this.txtCol1.Size = new System.Drawing.Size(32, 20);
            this.txtCol1.TabIndex = 3;
            this.txtCol1.UseMaxMin = true;
            // 
            // txtDeltaR
            // 
            this.txtDeltaR.CommaFormat = false;
            this.txtDeltaR.CurrencyFormat = false;
            this.txtDeltaR.DecimalPrecision = 3;
            this.txtDeltaR.DisableFormat = true;
            this.txtDeltaR.Location = new System.Drawing.Point(68, 35);
            this.txtDeltaR.MaxValue = 0;
            this.txtDeltaR.MinValue = 0;
            this.txtDeltaR.Name = "txtDeltaR";
            this.txtDeltaR.PercentFormat = false;
            this.txtDeltaR.ReadOnly = false;
            this.txtDeltaR.Size = new System.Drawing.Size(48, 20);
            this.txtDeltaR.TabIndex = 1;
            this.txtDeltaR.UseMaxMin = false;
            // 
            // txtR
            // 
            this.txtR.CommaFormat = false;
            this.txtR.CurrencyFormat = false;
            this.txtR.DecimalPrecision = 3;
            this.txtR.DisableFormat = true;
            this.txtR.Location = new System.Drawing.Point(68, 9);
            this.txtR.MaxValue = 0;
            this.txtR.MinValue = 0;
            this.txtR.Name = "txtR";
            this.txtR.PercentFormat = false;
            this.txtR.ReadOnly = false;
            this.txtR.Size = new System.Drawing.Size(48, 20);
            this.txtR.TabIndex = 0;
            this.txtR.UseMaxMin = false;
            // 
            // bifurcation1
            // 
            this.bifurcation1.Location = new System.Drawing.Point(146, 0);
            this.bifurcation1.Name = "bifurcation1";
            this.bifurcation1.Size = new System.Drawing.Size(780, 498);
            this.bifurcation1.TabIndex = 0;
            this.bifurcation1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panXY,
            this.panStatus,
            this.panCoord});
            this.statusStrip1.Location = new System.Drawing.Point(0, 501);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(926, 22);
            this.statusStrip1.TabIndex = 167;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panXY
            // 
            this.panXY.AutoSize = false;
            this.panXY.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.panXY.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.panXY.Name = "panXY";
            this.panXY.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.panXY.Size = new System.Drawing.Size(100, 17);
            this.panXY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panStatus
            // 
            this.panStatus.AutoSize = false;
            this.panStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.panStatus.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.panStatus.Name = "panStatus";
            this.panStatus.Size = new System.Drawing.Size(150, 17);
            this.panStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panCoord
            // 
            this.panCoord.AutoSize = false;
            this.panCoord.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.panCoord.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.panCoord.Name = "panCoord";
            this.panCoord.Size = new System.Drawing.Size(180, 17);
            this.panCoord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdExport
            // 
            this.cmdExport.Location = new System.Drawing.Point(51, 177);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.Size = new System.Drawing.Size(65, 24);
            this.cmdExport.TabIndex = 7;
            this.cmdExport.Text = "&Export";
            this.cmdExport.UseVisualStyleBackColor = true;
            this.cmdExport.Click += new System.EventHandler(this.cmdExport_Click);
            // 
            // BifurcationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 523);
            this.Controls.Add(this.cmdExport);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtCol2);
            this.Controls.Add(this.txtCol0);
            this.Controls.Add(this.txtCol1);
            this.Controls.Add(this.txtDeltaR);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmdDraw);
            this.Controls.Add(this.bifurcation1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BifurcationForm";
            this.Text = "Bifurcation";
            this.Load += new System.EventHandler(this.BifurcationForm_Load);
            this.Resize += new System.EventHandler(this.BifurcationForm_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FractalDraw.Bifurcation bifurcation1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdDraw;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Label label1;
        private FractalDraw.NumericTextbox txtR;
        private FractalDraw.NumericTextbox txtDeltaR;
        private FractalDraw.NumericTextbox txtCol1;
        private FractalDraw.NumericTextbox txtCol0;
        private FractalDraw.NumericTextbox txtCol2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel panXY;
        private System.Windows.Forms.ToolStripStatusLabel panStatus;
        private System.Windows.Forms.ToolStripStatusLabel panCoord;
        private System.Windows.Forms.Button cmdExport;
    }
}
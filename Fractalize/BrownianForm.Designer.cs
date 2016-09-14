namespace Fractalize
{
    partial class BrownianForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrownianForm));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdDraw = new System.Windows.Forms.Button();
            this.brownian1 = new FractalDraw.Brownian();
            this.cmdSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCol2 = new FractalDraw.NumericTextbox();
            this.txtCol0 = new FractalDraw.NumericTextbox();
            this.txtCol1 = new FractalDraw.NumericTextbox();
            this.txtMu = new FractalDraw.NumericTextbox();
            this.txtSigma = new FractalDraw.NumericTextbox();
            this.txtH = new FractalDraw.NumericTextbox();
            this.txtScale = new FractalDraw.NumericTextbox();
            this.txtSeed = new FractalDraw.NumericTextbox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panXY = new System.Windows.Forms.ToolStripStatusLabel();
            this.panStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panCoord = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmdExport = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 122;
            this.label4.Text = "Seed";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 120;
            this.label3.Text = "Scale";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 118;
            this.label2.Text = "h";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 116;
            this.label1.Text = "Sigma";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 114;
            this.label8.Text = "Mu";
            // 
            // cmdDraw
            // 
            this.cmdDraw.Location = new System.Drawing.Point(59, 177);
            this.cmdDraw.Name = "cmdDraw";
            this.cmdDraw.Size = new System.Drawing.Size(65, 24);
            this.cmdDraw.TabIndex = 8;
            this.cmdDraw.Text = "&Draw";
            this.cmdDraw.Click += new System.EventHandler(this.cmdDraw_Click);
            // 
            // brownian1
            // 
            this.brownian1.Location = new System.Drawing.Point(153, 0);
            this.brownian1.Name = "brownian1";
            this.brownian1.Size = new System.Drawing.Size(527, 541);
            this.brownian1.TabIndex = 124;
            this.brownian1.TabStop = false;
            // 
            // cmdSave
            // 
            this.cmdSave.Enabled = false;
            this.cmdSave.Location = new System.Drawing.Point(59, 207);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(65, 24);
            this.cmdSave.TabIndex = 9;
            this.cmdSave.Text = "&Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 150;
            this.label5.Text = "Color";
            // 
            // txtCol2
            // 
            this.txtCol2.CommaFormat = false;
            this.txtCol2.CurrencyFormat = false;
            this.txtCol2.DecimalPrecision = 0;
            this.txtCol2.DisableFormat = false;
            this.txtCol2.Location = new System.Drawing.Point(92, 151);
            this.txtCol2.MaxValue = 255;
            this.txtCol2.MinValue = 0;
            this.txtCol2.Name = "txtCol2";
            this.txtCol2.PercentFormat = false;
            this.txtCol2.ReadOnly = false;
            this.txtCol2.Size = new System.Drawing.Size(32, 20);
            this.txtCol2.TabIndex = 7;
            this.txtCol2.UseMaxMin = true;
            // 
            // txtCol0
            // 
            this.txtCol0.CommaFormat = false;
            this.txtCol0.CurrencyFormat = false;
            this.txtCol0.DecimalPrecision = 0;
            this.txtCol0.DisableFormat = false;
            this.txtCol0.Location = new System.Drawing.Point(15, 151);
            this.txtCol0.MaxValue = 255;
            this.txtCol0.MinValue = 0;
            this.txtCol0.Name = "txtCol0";
            this.txtCol0.PercentFormat = false;
            this.txtCol0.ReadOnly = false;
            this.txtCol0.Size = new System.Drawing.Size(32, 20);
            this.txtCol0.TabIndex = 5;
            this.txtCol0.UseMaxMin = true;
            // 
            // txtCol1
            // 
            this.txtCol1.CommaFormat = false;
            this.txtCol1.CurrencyFormat = false;
            this.txtCol1.DecimalPrecision = 0;
            this.txtCol1.DisableFormat = false;
            this.txtCol1.Location = new System.Drawing.Point(54, 151);
            this.txtCol1.MaxValue = 255;
            this.txtCol1.MinValue = 0;
            this.txtCol1.Name = "txtCol1";
            this.txtCol1.PercentFormat = false;
            this.txtCol1.ReadOnly = false;
            this.txtCol1.Size = new System.Drawing.Size(32, 20);
            this.txtCol1.TabIndex = 6;
            this.txtCol1.UseMaxMin = true;
            // 
            // txtMu
            // 
            this.txtMu.CommaFormat = false;
            this.txtMu.CurrencyFormat = false;
            this.txtMu.DecimalPrecision = 3;
            this.txtMu.DisableFormat = true;
            this.txtMu.Location = new System.Drawing.Point(76, 9);
            this.txtMu.MaxValue = 100;
            this.txtMu.MinValue = 0;
            this.txtMu.Name = "txtMu";
            this.txtMu.PercentFormat = false;
            this.txtMu.ReadOnly = false;
            this.txtMu.Size = new System.Drawing.Size(48, 20);
            this.txtMu.TabIndex = 0;
            this.txtMu.UseMaxMin = false;
            // 
            // txtSigma
            // 
            this.txtSigma.CommaFormat = false;
            this.txtSigma.CurrencyFormat = false;
            this.txtSigma.DecimalPrecision = 3;
            this.txtSigma.DisableFormat = true;
            this.txtSigma.Location = new System.Drawing.Point(76, 33);
            this.txtSigma.MaxValue = 100;
            this.txtSigma.MinValue = 0;
            this.txtSigma.Name = "txtSigma";
            this.txtSigma.PercentFormat = false;
            this.txtSigma.ReadOnly = false;
            this.txtSigma.Size = new System.Drawing.Size(48, 20);
            this.txtSigma.TabIndex = 1;
            this.txtSigma.UseMaxMin = false;
            // 
            // txtH
            // 
            this.txtH.CommaFormat = false;
            this.txtH.CurrencyFormat = false;
            this.txtH.DecimalPrecision = 3;
            this.txtH.DisableFormat = true;
            this.txtH.Location = new System.Drawing.Point(76, 57);
            this.txtH.MaxValue = 100;
            this.txtH.MinValue = 0;
            this.txtH.Name = "txtH";
            this.txtH.PercentFormat = false;
            this.txtH.ReadOnly = false;
            this.txtH.Size = new System.Drawing.Size(48, 20);
            this.txtH.TabIndex = 2;
            this.txtH.UseMaxMin = false;
            // 
            // txtScale
            // 
            this.txtScale.CommaFormat = false;
            this.txtScale.CurrencyFormat = false;
            this.txtScale.DecimalPrecision = 0;
            this.txtScale.DisableFormat = false;
            this.txtScale.Location = new System.Drawing.Point(76, 81);
            this.txtScale.MaxValue = 100;
            this.txtScale.MinValue = 0;
            this.txtScale.Name = "txtScale";
            this.txtScale.PercentFormat = false;
            this.txtScale.ReadOnly = false;
            this.txtScale.Size = new System.Drawing.Size(48, 20);
            this.txtScale.TabIndex = 3;
            this.txtScale.UseMaxMin = false;
            // 
            // txtSeed
            // 
            this.txtSeed.CommaFormat = false;
            this.txtSeed.CurrencyFormat = false;
            this.txtSeed.DecimalPrecision = 0;
            this.txtSeed.DisableFormat = false;
            this.txtSeed.Location = new System.Drawing.Point(76, 105);
            this.txtSeed.MaxValue = 100;
            this.txtSeed.MinValue = 0;
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.PercentFormat = false;
            this.txtSeed.ReadOnly = false;
            this.txtSeed.Size = new System.Drawing.Size(48, 20);
            this.txtSeed.TabIndex = 4;
            this.txtSeed.UseMaxMin = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panXY,
            this.panStatus,
            this.panCoord});
            this.statusStrip1.Location = new System.Drawing.Point(0, 544);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(680, 22);
            this.statusStrip1.TabIndex = 168;
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
            this.cmdExport.Location = new System.Drawing.Point(59, 237);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.Size = new System.Drawing.Size(65, 24);
            this.cmdExport.TabIndex = 10;
            this.cmdExport.Text = "&Export";
            this.cmdExport.UseVisualStyleBackColor = true;
            this.cmdExport.Click += new System.EventHandler(this.cmdExport_Click);
            // 
            // BrownianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 566);
            this.Controls.Add(this.cmdExport);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtSeed);
            this.Controls.Add(this.txtScale);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtSigma);
            this.Controls.Add(this.txtMu);
            this.Controls.Add(this.txtCol2);
            this.Controls.Add(this.txtCol0);
            this.Controls.Add(this.txtCol1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.brownian1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmdDraw);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BrownianForm";
            this.Text = "Brownian";
            this.Load += new System.EventHandler(this.BrownianForm_Load);
            this.Resize += new System.EventHandler(this.BrownianForm_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cmdDraw;
        private FractalDraw.Brownian brownian1;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Label label5;
        private FractalDraw.NumericTextbox txtCol2;
        private FractalDraw.NumericTextbox txtCol0;
        private FractalDraw.NumericTextbox txtCol1;
        private FractalDraw.NumericTextbox txtMu;
        private FractalDraw.NumericTextbox txtSigma;
        private FractalDraw.NumericTextbox txtH;
        private FractalDraw.NumericTextbox txtScale;
        private FractalDraw.NumericTextbox txtSeed;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel panXY;
        private System.Windows.Forms.ToolStripStatusLabel panStatus;
        private System.Windows.Forms.ToolStripStatusLabel panCoord;
        private System.Windows.Forms.Button cmdExport;
    }
}
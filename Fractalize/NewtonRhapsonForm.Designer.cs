namespace Fractalize
{
    partial class NewtonRhapsonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewtonRhapsonForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdDraw = new System.Windows.Forms.Button();
            this.newtonRhapson1 = new FractalDraw.NewtonRhapson();
            this.cmdSave = new System.Windows.Forms.Button();
            this.txtIterations = new FractalDraw.NumericTextbox();
            this.txtSize = new FractalDraw.NumericTextbox();
            this.txtXMax = new FractalDraw.NumericTextbox();
            this.txtXMin = new FractalDraw.NumericTextbox();
            this.txtYMin = new FractalDraw.NumericTextbox();
            this.txtYMax = new FractalDraw.NumericTextbox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panXY = new System.Windows.Forms.ToolStripStatusLabel();
            this.panStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panCoord = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmdExport = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 124;
            this.label1.Text = "YMin";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 122;
            this.label3.Text = "YMax";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 120;
            this.label8.Text = "Iterations";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 118;
            this.label7.Text = "XMin";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 116;
            this.label6.Text = "XMax";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 114;
            this.label5.Text = "Size";
            // 
            // cmdDraw
            // 
            this.cmdDraw.Location = new System.Drawing.Point(59, 167);
            this.cmdDraw.Name = "cmdDraw";
            this.cmdDraw.Size = new System.Drawing.Size(65, 24);
            this.cmdDraw.TabIndex = 6;
            this.cmdDraw.Text = "&Draw";
            this.cmdDraw.Click += new System.EventHandler(this.cmdDraw_Click);
            // 
            // newtonRhapson1
            // 
            this.newtonRhapson1.Location = new System.Drawing.Point(247, 0);
            this.newtonRhapson1.Name = "newtonRhapson1";
            this.newtonRhapson1.Size = new System.Drawing.Size(402, 560);
            this.newtonRhapson1.TabIndex = 126;
            this.newtonRhapson1.TabStop = false;
            // 
            // cmdSave
            // 
            this.cmdSave.Enabled = false;
            this.cmdSave.Location = new System.Drawing.Point(59, 197);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(65, 24);
            this.cmdSave.TabIndex = 7;
            this.cmdSave.Text = "&Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // txtIterations
            // 
            this.txtIterations.CommaFormat = false;
            this.txtIterations.CurrencyFormat = false;
            this.txtIterations.DecimalPrecision = 0;
            this.txtIterations.DisableFormat = false;
            this.txtIterations.Location = new System.Drawing.Point(74, 12);
            this.txtIterations.MaxValue = 1000;
            this.txtIterations.MinValue = 0;
            this.txtIterations.Name = "txtIterations";
            this.txtIterations.PercentFormat = false;
            this.txtIterations.ReadOnly = false;
            this.txtIterations.Size = new System.Drawing.Size(50, 20);
            this.txtIterations.TabIndex = 0;
            this.txtIterations.UseMaxMin = true;
            // 
            // txtSize
            // 
            this.txtSize.CommaFormat = false;
            this.txtSize.CurrencyFormat = false;
            this.txtSize.DecimalPrecision = 0;
            this.txtSize.DisableFormat = false;
            this.txtSize.Location = new System.Drawing.Point(74, 37);
            this.txtSize.MaxValue = 25;
            this.txtSize.MinValue = 0;
            this.txtSize.Name = "txtSize";
            this.txtSize.PercentFormat = false;
            this.txtSize.ReadOnly = false;
            this.txtSize.Size = new System.Drawing.Size(50, 20);
            this.txtSize.TabIndex = 1;
            this.txtSize.UseMaxMin = false;
            // 
            // txtXMax
            // 
            this.txtXMax.CommaFormat = false;
            this.txtXMax.CurrencyFormat = false;
            this.txtXMax.DecimalPrecision = 3;
            this.txtXMax.DisableFormat = true;
            this.txtXMax.Location = new System.Drawing.Point(74, 63);
            this.txtXMax.MaxValue = 25;
            this.txtXMax.MinValue = 0;
            this.txtXMax.Name = "txtXMax";
            this.txtXMax.PercentFormat = false;
            this.txtXMax.ReadOnly = false;
            this.txtXMax.Size = new System.Drawing.Size(50, 20);
            this.txtXMax.TabIndex = 2;
            this.txtXMax.UseMaxMin = false;
            // 
            // txtXMin
            // 
            this.txtXMin.CommaFormat = false;
            this.txtXMin.CurrencyFormat = false;
            this.txtXMin.DecimalPrecision = 3;
            this.txtXMin.DisableFormat = true;
            this.txtXMin.Location = new System.Drawing.Point(74, 89);
            this.txtXMin.MaxValue = 25;
            this.txtXMin.MinValue = 0;
            this.txtXMin.Name = "txtXMin";
            this.txtXMin.PercentFormat = false;
            this.txtXMin.ReadOnly = false;
            this.txtXMin.Size = new System.Drawing.Size(50, 20);
            this.txtXMin.TabIndex = 3;
            this.txtXMin.UseMaxMin = false;
            // 
            // txtYMin
            // 
            this.txtYMin.CommaFormat = false;
            this.txtYMin.CurrencyFormat = false;
            this.txtYMin.DecimalPrecision = 3;
            this.txtYMin.DisableFormat = true;
            this.txtYMin.Location = new System.Drawing.Point(74, 141);
            this.txtYMin.MaxValue = 25;
            this.txtYMin.MinValue = 0;
            this.txtYMin.Name = "txtYMin";
            this.txtYMin.PercentFormat = false;
            this.txtYMin.ReadOnly = false;
            this.txtYMin.Size = new System.Drawing.Size(50, 20);
            this.txtYMin.TabIndex = 5;
            this.txtYMin.UseMaxMin = false;
            // 
            // txtYMax
            // 
            this.txtYMax.CommaFormat = false;
            this.txtYMax.CurrencyFormat = false;
            this.txtYMax.DecimalPrecision = 3;
            this.txtYMax.DisableFormat = true;
            this.txtYMax.Location = new System.Drawing.Point(74, 115);
            this.txtYMax.MaxValue = 25;
            this.txtYMax.MinValue = 0;
            this.txtYMax.Name = "txtYMax";
            this.txtYMax.PercentFormat = false;
            this.txtYMax.ReadOnly = false;
            this.txtYMax.Size = new System.Drawing.Size(50, 20);
            this.txtYMax.TabIndex = 4;
            this.txtYMax.UseMaxMin = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panXY,
            this.panStatus,
            this.panCoord});
            this.statusStrip1.Location = new System.Drawing.Point(0, 563);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(649, 22);
            this.statusStrip1.TabIndex = 170;
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
            this.cmdExport.Location = new System.Drawing.Point(59, 227);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.Size = new System.Drawing.Size(65, 24);
            this.cmdExport.TabIndex = 8;
            this.cmdExport.Text = "&Export";
            this.cmdExport.UseVisualStyleBackColor = true;
            this.cmdExport.Click += new System.EventHandler(this.cmdExport_Click);
            // 
            // NewtonRhapsonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 585);
            this.Controls.Add(this.cmdExport);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtYMax);
            this.Controls.Add(this.txtYMin);
            this.Controls.Add(this.txtXMin);
            this.Controls.Add(this.txtXMax);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtIterations);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.newtonRhapson1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdDraw);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewtonRhapsonForm";
            this.Text = "Newton-Rhapson";
            this.Load += new System.EventHandler(this.NewtonRhapsonForm_Load);
            this.Resize += new System.EventHandler(this.NewtonRhapsonForm_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdDraw;
        private FractalDraw.NewtonRhapson newtonRhapson1;
        private System.Windows.Forms.Button cmdSave;
        private FractalDraw.NumericTextbox txtIterations;
        private FractalDraw.NumericTextbox txtSize;
        private FractalDraw.NumericTextbox txtXMax;
        private FractalDraw.NumericTextbox txtXMin;
        private FractalDraw.NumericTextbox txtYMin;
        private FractalDraw.NumericTextbox txtYMax;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel panXY;
        private System.Windows.Forms.ToolStripStatusLabel panStatus;
        private System.Windows.Forms.ToolStripStatusLabel panCoord;
        private System.Windows.Forms.Button cmdExport;
    }
}
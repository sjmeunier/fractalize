namespace Fractalize
{
    partial class MandelbrotForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MandelbrotForm));
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboPower2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPower = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdDraw = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panXY = new System.Windows.Forms.ToolStripStatusLabel();
            this.panStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panCoord = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmdZoomIn = new System.Windows.Forms.Button();
            this.cmdZoomOut = new System.Windows.Forms.Button();
            this.txtYOffset = new FractalDraw.NumericTextbox();
            this.txtXOffset = new FractalDraw.NumericTextbox();
            this.txtSize = new FractalDraw.NumericTextbox();
            this.txtIterations = new FractalDraw.NumericTextbox();
            this.mandelbrot1 = new FractalDraw.Mandelbrot();
            this.cmdExport = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 97;
            this.label8.Text = "Iterations";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 95;
            this.label7.Text = "YOffset";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 93;
            this.label6.Text = "XOffset";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 91;
            this.label5.Text = "Size";
            // 
            // cboPower2
            // 
            this.cboPower2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPower2.ItemHeight = 13;
            this.cboPower2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cboPower2.Location = new System.Drawing.Point(76, 33);
            this.cboPower2.Name = "cboPower2";
            this.cboPower2.Size = new System.Drawing.Size(40, 21);
            this.cboPower2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 89;
            this.label3.Text = "Power:";
            // 
            // cboPower
            // 
            this.cboPower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPower.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cboPower.Location = new System.Drawing.Point(76, 9);
            this.cboPower.Name = "cboPower";
            this.cboPower.Size = new System.Drawing.Size(40, 21);
            this.cboPower.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 87;
            this.label4.Text = "Power:";
            // 
            // cmdDraw
            // 
            this.cmdDraw.Location = new System.Drawing.Point(51, 163);
            this.cmdDraw.Name = "cmdDraw";
            this.cmdDraw.Size = new System.Drawing.Size(65, 24);
            this.cmdDraw.TabIndex = 6;
            this.cmdDraw.Text = "&Draw";
            this.cmdDraw.Click += new System.EventHandler(this.cmdDraw_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Enabled = false;
            this.cmdSave.Location = new System.Drawing.Point(51, 193);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(65, 24);
            this.cmdSave.TabIndex = 7;
            this.cmdSave.Text = "&Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panXY,
            this.panStatus,
            this.panCoord});
            this.statusStrip1.Location = new System.Drawing.Point(0, 489);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(766, 22);
            this.statusStrip1.TabIndex = 166;
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
            // cmdZoomIn
            // 
            this.cmdZoomIn.Enabled = false;
            this.cmdZoomIn.Location = new System.Drawing.Point(51, 266);
            this.cmdZoomIn.Name = "cmdZoomIn";
            this.cmdZoomIn.Size = new System.Drawing.Size(65, 24);
            this.cmdZoomIn.TabIndex = 9;
            this.cmdZoomIn.Text = "&Zoom In";
            this.cmdZoomIn.UseVisualStyleBackColor = true;
            this.cmdZoomIn.Click += new System.EventHandler(this.cmdZoomIn_Click);
            // 
            // cmdZoomOut
            // 
            this.cmdZoomOut.Enabled = false;
            this.cmdZoomOut.Location = new System.Drawing.Point(51, 296);
            this.cmdZoomOut.Name = "cmdZoomOut";
            this.cmdZoomOut.Size = new System.Drawing.Size(65, 24);
            this.cmdZoomOut.TabIndex = 10;
            this.cmdZoomOut.Text = "&Zoom Out";
            this.cmdZoomOut.UseVisualStyleBackColor = true;
            this.cmdZoomOut.Click += new System.EventHandler(this.cmdZoomOut_Click);
            // 
            // txtYOffset
            // 
            this.txtYOffset.CommaFormat = false;
            this.txtYOffset.CurrencyFormat = false;
            this.txtYOffset.DecimalPrecision = 3;
            this.txtYOffset.DisableFormat = true;
            this.txtYOffset.Location = new System.Drawing.Point(66, 137);
            this.txtYOffset.MaxValue = 25;
            this.txtYOffset.MinValue = 0;
            this.txtYOffset.Name = "txtYOffset";
            this.txtYOffset.PercentFormat = false;
            this.txtYOffset.ReadOnly = false;
            this.txtYOffset.Size = new System.Drawing.Size(50, 20);
            this.txtYOffset.TabIndex = 5;
            this.txtYOffset.UseMaxMin = false;
            // 
            // txtXOffset
            // 
            this.txtXOffset.CommaFormat = false;
            this.txtXOffset.CurrencyFormat = false;
            this.txtXOffset.DecimalPrecision = 3;
            this.txtXOffset.DisableFormat = true;
            this.txtXOffset.Location = new System.Drawing.Point(66, 111);
            this.txtXOffset.MaxValue = 25;
            this.txtXOffset.MinValue = 0;
            this.txtXOffset.Name = "txtXOffset";
            this.txtXOffset.PercentFormat = false;
            this.txtXOffset.ReadOnly = false;
            this.txtXOffset.Size = new System.Drawing.Size(50, 20);
            this.txtXOffset.TabIndex = 4;
            this.txtXOffset.UseMaxMin = false;
            // 
            // txtSize
            // 
            this.txtSize.CommaFormat = false;
            this.txtSize.CurrencyFormat = false;
            this.txtSize.DecimalPrecision = 0;
            this.txtSize.DisableFormat = false;
            this.txtSize.Location = new System.Drawing.Point(66, 85);
            this.txtSize.MaxValue = 25;
            this.txtSize.MinValue = 0;
            this.txtSize.Name = "txtSize";
            this.txtSize.PercentFormat = false;
            this.txtSize.ReadOnly = false;
            this.txtSize.Size = new System.Drawing.Size(50, 20);
            this.txtSize.TabIndex = 3;
            this.txtSize.UseMaxMin = false;
            // 
            // txtIterations
            // 
            this.txtIterations.CommaFormat = false;
            this.txtIterations.CurrencyFormat = false;
            this.txtIterations.DecimalPrecision = 0;
            this.txtIterations.DisableFormat = false;
            this.txtIterations.Location = new System.Drawing.Point(66, 60);
            this.txtIterations.MaxValue = 10000;
            this.txtIterations.MinValue = 0;
            this.txtIterations.Name = "txtIterations";
            this.txtIterations.PercentFormat = false;
            this.txtIterations.ReadOnly = false;
            this.txtIterations.Size = new System.Drawing.Size(50, 20);
            this.txtIterations.TabIndex = 2;
            this.txtIterations.UseMaxMin = true;
            // 
            // mandelbrot1
            // 
            this.mandelbrot1.Location = new System.Drawing.Point(246, 0);
            this.mandelbrot1.Name = "mandelbrot1";
            this.mandelbrot1.Size = new System.Drawing.Size(520, 486);
            this.mandelbrot1.TabIndex = 99;
            this.mandelbrot1.TabStop = false;
            // 
            // cmdExport
            // 
            this.cmdExport.Location = new System.Drawing.Point(51, 223);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.Size = new System.Drawing.Size(65, 24);
            this.cmdExport.TabIndex = 8;
            this.cmdExport.Text = "&Export";
            this.cmdExport.UseVisualStyleBackColor = true;
            this.cmdExport.Click += new System.EventHandler(this.cmdExport_Click);
            // 
            // MandelbrotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 511);
            this.Controls.Add(this.cmdExport);
            this.Controls.Add(this.cmdZoomOut);
            this.Controls.Add(this.cmdZoomIn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtYOffset);
            this.Controls.Add(this.txtXOffset);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtIterations);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.mandelbrot1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboPower2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboPower);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdDraw);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MandelbrotForm";
            this.Text = "Mandelbrot";
            this.Load += new System.EventHandler(this.MandelbrotForm_Load);
            this.Resize += new System.EventHandler(this.MandelbrotForm_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboPower2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPower;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdDraw;
        private FractalDraw.Mandelbrot mandelbrot1;
        private System.Windows.Forms.Button cmdSave;
        private FractalDraw.NumericTextbox txtYOffset;
        private FractalDraw.NumericTextbox txtXOffset;
        private FractalDraw.NumericTextbox txtSize;
        private FractalDraw.NumericTextbox txtIterations;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel panXY;
        private System.Windows.Forms.ToolStripStatusLabel panStatus;
        private System.Windows.Forms.ToolStripStatusLabel panCoord;
        private System.Windows.Forms.Button cmdZoomIn;
        private System.Windows.Forms.Button cmdZoomOut;
        private System.Windows.Forms.Button cmdExport;
    }
}
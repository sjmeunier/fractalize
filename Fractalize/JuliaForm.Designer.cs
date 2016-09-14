namespace Fractalize
{
    partial class JuliaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JuliaForm));
            this.cboPower2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLobes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdDraw = new System.Windows.Forms.Button();
            this.julia1 = new FractalDraw.Julia();
            this.cmdSave = new System.Windows.Forms.Button();
            this.txtYOffset = new FractalDraw.NumericTextbox();
            this.txtXOffset = new FractalDraw.NumericTextbox();
            this.txtSize = new FractalDraw.NumericTextbox();
            this.txtIterations = new FractalDraw.NumericTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLamdaRE = new FractalDraw.NumericTextbox();
            this.txtLamdaIM = new FractalDraw.NumericTextbox();
            this.cmdZoomOut = new System.Windows.Forms.Button();
            this.cmdZoomIn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panXY = new System.Windows.Forms.ToolStripStatusLabel();
            this.panStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panCoord = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmdExport = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboPower2
            // 
            this.cboPower2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.label3.TabIndex = 98;
            this.label3.Text = "Power:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 97;
            this.label2.Text = "Lamda";
            // 
            // cboLobes
            // 
            this.cboLobes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLobes.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cboLobes.Location = new System.Drawing.Point(76, 9);
            this.cboLobes.Name = "cboLobes";
            this.cboLobes.Size = new System.Drawing.Size(40, 21);
            this.cboLobes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 95;
            this.label1.Text = "Power:";
            // 
            // cmdDraw
            // 
            this.cmdDraw.Location = new System.Drawing.Point(50, 216);
            this.cmdDraw.Name = "cmdDraw";
            this.cmdDraw.Size = new System.Drawing.Size(66, 24);
            this.cmdDraw.TabIndex = 8;
            this.cmdDraw.Text = "&Draw";
            this.cmdDraw.Click += new System.EventHandler(this.cmdDraw_Click);
            // 
            // julia1
            // 
            this.julia1.Location = new System.Drawing.Point(178, 0);
            this.julia1.Name = "julia1";
            this.julia1.Size = new System.Drawing.Size(743, 584);
            this.julia1.TabIndex = 110;
            // 
            // cmdSave
            // 
            this.cmdSave.Enabled = false;
            this.cmdSave.Location = new System.Drawing.Point(51, 246);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(65, 24);
            this.cmdSave.TabIndex = 9;
            this.cmdSave.Text = "&Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // txtYOffset
            // 
            this.txtYOffset.CommaFormat = false;
            this.txtYOffset.CurrencyFormat = false;
            this.txtYOffset.DecimalPrecision = 3;
            this.txtYOffset.DisableFormat = true;
            this.txtYOffset.Location = new System.Drawing.Point(66, 138);
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
            this.txtXOffset.Location = new System.Drawing.Point(66, 112);
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
            this.txtSize.Location = new System.Drawing.Point(66, 86);
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
            this.txtIterations.Location = new System.Drawing.Point(66, 61);
            this.txtIterations.MaxValue = 10000;
            this.txtIterations.MinValue = 0;
            this.txtIterations.Name = "txtIterations";
            this.txtIterations.PercentFormat = false;
            this.txtIterations.ReadOnly = false;
            this.txtIterations.Size = new System.Drawing.Size(50, 20);
            this.txtIterations.TabIndex = 2;
            this.txtIterations.UseMaxMin = true;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 169;
            this.label8.Text = "Iterations";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 168;
            this.label7.Text = "YOffset";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 167;
            this.label6.Text = "XOffset";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 166;
            this.label5.Text = "Size";
            // 
            // txtLamdaRE
            // 
            this.txtLamdaRE.CommaFormat = false;
            this.txtLamdaRE.CurrencyFormat = false;
            this.txtLamdaRE.DecimalPrecision = 3;
            this.txtLamdaRE.DisableFormat = true;
            this.txtLamdaRE.Location = new System.Drawing.Point(66, 164);
            this.txtLamdaRE.MaxValue = 25;
            this.txtLamdaRE.MinValue = 0;
            this.txtLamdaRE.Name = "txtLamdaRE";
            this.txtLamdaRE.PercentFormat = false;
            this.txtLamdaRE.ReadOnly = false;
            this.txtLamdaRE.Size = new System.Drawing.Size(50, 20);
            this.txtLamdaRE.TabIndex = 6;
            this.txtLamdaRE.UseMaxMin = false;
            // 
            // txtLamdaIM
            // 
            this.txtLamdaIM.CommaFormat = false;
            this.txtLamdaIM.CurrencyFormat = false;
            this.txtLamdaIM.DecimalPrecision = 3;
            this.txtLamdaIM.DisableFormat = true;
            this.txtLamdaIM.Location = new System.Drawing.Point(66, 190);
            this.txtLamdaIM.MaxValue = 25;
            this.txtLamdaIM.MinValue = 0;
            this.txtLamdaIM.Name = "txtLamdaIM";
            this.txtLamdaIM.PercentFormat = false;
            this.txtLamdaIM.ReadOnly = false;
            this.txtLamdaIM.Size = new System.Drawing.Size(50, 20);
            this.txtLamdaIM.TabIndex = 7;
            this.txtLamdaIM.UseMaxMin = false;
            // 
            // cmdZoomOut
            // 
            this.cmdZoomOut.Enabled = false;
            this.cmdZoomOut.Location = new System.Drawing.Point(51, 345);
            this.cmdZoomOut.Name = "cmdZoomOut";
            this.cmdZoomOut.Size = new System.Drawing.Size(65, 24);
            this.cmdZoomOut.TabIndex = 12;
            this.cmdZoomOut.Text = "&Zoom Out";
            this.cmdZoomOut.UseVisualStyleBackColor = true;
            this.cmdZoomOut.Click += new System.EventHandler(this.cmdZoomOut_Click);
            // 
            // cmdZoomIn
            // 
            this.cmdZoomIn.Enabled = false;
            this.cmdZoomIn.Location = new System.Drawing.Point(51, 315);
            this.cmdZoomIn.Name = "cmdZoomIn";
            this.cmdZoomIn.Size = new System.Drawing.Size(65, 24);
            this.cmdZoomIn.TabIndex = 11;
            this.cmdZoomIn.Text = "&Zoom In";
            this.cmdZoomIn.UseVisualStyleBackColor = true;
            this.cmdZoomIn.Click += new System.EventHandler(this.cmdZoomIn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panXY,
            this.panStatus,
            this.panCoord});
            this.statusStrip1.Location = new System.Drawing.Point(0, 587);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(921, 22);
            this.statusStrip1.TabIndex = 178;
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
            this.cmdExport.Location = new System.Drawing.Point(51, 276);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.Size = new System.Drawing.Size(65, 24);
            this.cmdExport.TabIndex = 10;
            this.cmdExport.Text = "&Export";
            this.cmdExport.UseVisualStyleBackColor = true;
            this.cmdExport.Click += new System.EventHandler(this.cmdExport_Click);
            // 
            // JuliaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 609);
            this.Controls.Add(this.cmdExport);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cmdZoomOut);
            this.Controls.Add(this.cmdZoomIn);
            this.Controls.Add(this.txtLamdaIM);
            this.Controls.Add(this.txtLamdaRE);
            this.Controls.Add(this.txtYOffset);
            this.Controls.Add(this.txtXOffset);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtIterations);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.julia1);
            this.Controls.Add(this.cboPower2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboLobes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdDraw);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JuliaForm";
            this.Text = "Julia";
            this.Load += new System.EventHandler(this.JuliaForm_Load);
            this.Resize += new System.EventHandler(this.JuliaForm_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPower2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLobes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdDraw;
        private FractalDraw.Julia julia1;
        private System.Windows.Forms.Button cmdSave;
        private FractalDraw.NumericTextbox txtYOffset;
        private FractalDraw.NumericTextbox txtXOffset;
        private FractalDraw.NumericTextbox txtSize;
        private FractalDraw.NumericTextbox txtIterations;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private FractalDraw.NumericTextbox txtLamdaRE;
        private FractalDraw.NumericTextbox txtLamdaIM;
        private System.Windows.Forms.Button cmdZoomOut;
        private System.Windows.Forms.Button cmdZoomIn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel panXY;
        private System.Windows.Forms.ToolStripStatusLabel panStatus;
        private System.Windows.Forms.ToolStripStatusLabel panCoord;
        private System.Windows.Forms.Button cmdExport;
    }
}
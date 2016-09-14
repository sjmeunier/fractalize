namespace Fractalize
{
    partial class SierpinskiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SierpinskiForm));
            this.cboType = new System.Windows.Forms.ComboBox();
            this.cmdDraw = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panXY = new System.Windows.Forms.ToolStripStatusLabel();
            this.panStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panCoord = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmdExport = new System.Windows.Forms.Button();
            this.txtIterations = new FractalDraw.NumericTextbox();
            this.txtCol2 = new FractalDraw.NumericTextbox();
            this.txtCol0 = new FractalDraw.NumericTextbox();
            this.txtCol1 = new FractalDraw.NumericTextbox();
            this.sierpinski1 = new FractalDraw.Sierpinski();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.ItemHeight = 13;
            this.cboType.Items.AddRange(new object[] {
            "Triangle",
            "Square"});
            this.cboType.Location = new System.Drawing.Point(12, 12);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(109, 21);
            this.cboType.TabIndex = 0;
            // 
            // cmdDraw
            // 
            this.cmdDraw.Location = new System.Drawing.Point(56, 117);
            this.cmdDraw.Name = "cmdDraw";
            this.cmdDraw.Size = new System.Drawing.Size(65, 24);
            this.cmdDraw.TabIndex = 5;
            this.cmdDraw.Text = "&Draw";
            this.cmdDraw.Click += new System.EventHandler(this.cmdDraw_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(56, 147);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(65, 24);
            this.cmdSave.TabIndex = 6;
            this.cmdSave.Text = "&Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(9, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 159;
            this.label7.Text = "Color";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(9, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 158;
            this.label8.Text = "Iterations";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panXY,
            this.panStatus,
            this.panCoord});
            this.statusStrip1.Location = new System.Drawing.Point(0, 501);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(665, 22);
            this.statusStrip1.TabIndex = 169;
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
            this.cmdExport.Location = new System.Drawing.Point(56, 177);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.Size = new System.Drawing.Size(65, 24);
            this.cmdExport.TabIndex = 7;
            this.cmdExport.Text = "&Export";
            this.cmdExport.UseVisualStyleBackColor = true;
            this.cmdExport.Click += new System.EventHandler(this.cmdExport_Click);
            // 
            // txtIterations
            // 
            this.txtIterations.CommaFormat = false;
            this.txtIterations.CurrencyFormat = false;
            this.txtIterations.DecimalPrecision = 0;
            this.txtIterations.DisableFormat = false;
            this.txtIterations.Location = new System.Drawing.Point(71, 39);
            this.txtIterations.MaxValue = 25;
            this.txtIterations.MinValue = 0;
            this.txtIterations.Name = "txtIterations";
            this.txtIterations.PercentFormat = false;
            this.txtIterations.ReadOnly = false;
            this.txtIterations.Size = new System.Drawing.Size(50, 20);
            this.txtIterations.TabIndex = 1;
            this.txtIterations.UseMaxMin = true;
            // 
            // txtCol2
            // 
            this.txtCol2.CommaFormat = false;
            this.txtCol2.CurrencyFormat = false;
            this.txtCol2.DecimalPrecision = 0;
            this.txtCol2.DisableFormat = false;
            this.txtCol2.Location = new System.Drawing.Point(88, 91);
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
            this.txtCol0.Location = new System.Drawing.Point(11, 91);
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
            this.txtCol1.Location = new System.Drawing.Point(50, 91);
            this.txtCol1.MaxValue = 255;
            this.txtCol1.MinValue = 0;
            this.txtCol1.Name = "txtCol1";
            this.txtCol1.PercentFormat = false;
            this.txtCol1.ReadOnly = false;
            this.txtCol1.Size = new System.Drawing.Size(32, 20);
            this.txtCol1.TabIndex = 3;
            this.txtCol1.UseMaxMin = true;
            // 
            // sierpinski1
            // 
            this.sierpinski1.Location = new System.Drawing.Point(201, 0);
            this.sierpinski1.Name = "sierpinski1";
            this.sierpinski1.Size = new System.Drawing.Size(464, 498);
            this.sierpinski1.TabIndex = 0;
            this.sierpinski1.TabStop = false;
            // 
            // SierpinskiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 523);
            this.Controls.Add(this.cmdExport);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtIterations);
            this.Controls.Add(this.txtCol2);
            this.Controls.Add(this.txtCol0);
            this.Controls.Add(this.txtCol1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.cmdDraw);
            this.Controls.Add(this.sierpinski1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SierpinskiForm";
            this.Text = "SierpinskiForm";
            this.Load += new System.EventHandler(this.SierpinskiForm_Load);
            this.Resize += new System.EventHandler(this.SierpinskiForm_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FractalDraw.Sierpinski sierpinski1;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Button cmdDraw;
        private System.Windows.Forms.Button cmdSave;
        private FractalDraw.NumericTextbox txtIterations;
        private FractalDraw.NumericTextbox txtCol2;
        private FractalDraw.NumericTextbox txtCol0;
        private FractalDraw.NumericTextbox txtCol1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel panXY;
        private System.Windows.Forms.ToolStripStatusLabel panStatus;
        private System.Windows.Forms.ToolStripStatusLabel panCoord;
        private System.Windows.Forms.Button cmdExport;
    }
}
namespace Fractalize
{
    partial class PlasmaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlasmaForm));
            this.label6 = new System.Windows.Forms.Label();
            this.cmdDraw = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plasma1 = new FractalDraw.Plasma();
            this.txtRoughness = new FractalDraw.NumericTextbox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panXY = new System.Windows.Forms.ToolStripStatusLabel();
            this.panStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panCoord = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmdExport = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 108;
            this.label6.Text = "Rough";
            // 
            // cmdDraw
            // 
            this.cmdDraw.Location = new System.Drawing.Point(58, 70);
            this.cmdDraw.Name = "cmdDraw";
            this.cmdDraw.Size = new System.Drawing.Size(66, 24);
            this.cmdDraw.TabIndex = 2;
            this.cmdDraw.Text = "&Draw";
            this.cmdDraw.Click += new System.EventHandler(this.cmdDraw_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Enabled = false;
            this.cmdSave.Location = new System.Drawing.Point(58, 100);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(65, 24);
            this.cmdSave.TabIndex = 3;
            this.cmdSave.Text = "&Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Plasma",
            "Cloud",
            "Grey"});
            this.cboType.Location = new System.Drawing.Point(58, 35);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(66, 21);
            this.cboType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 114;
            this.label1.Text = "Type";
            // 
            // plasma1
            // 
            this.plasma1.Location = new System.Drawing.Point(129, 0);
            this.plasma1.Name = "plasma1";
            this.plasma1.Size = new System.Drawing.Size(536, 529);
            this.plasma1.TabIndex = 0;
            this.plasma1.TabStop = false;
            // 
            // txtRoughness
            // 
            this.txtRoughness.CommaFormat = false;
            this.txtRoughness.CurrencyFormat = false;
            this.txtRoughness.DecimalPrecision = 3;
            this.txtRoughness.DisableFormat = true;
            this.txtRoughness.Location = new System.Drawing.Point(58, 9);
            this.txtRoughness.MaxValue = 100;
            this.txtRoughness.MinValue = 1;
            this.txtRoughness.Name = "txtRoughness";
            this.txtRoughness.PercentFormat = false;
            this.txtRoughness.ReadOnly = false;
            this.txtRoughness.Size = new System.Drawing.Size(65, 20);
            this.txtRoughness.TabIndex = 0;
            this.txtRoughness.UseMaxMin = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panXY,
            this.panStatus,
            this.panCoord});
            this.statusStrip1.Location = new System.Drawing.Point(0, 532);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(665, 22);
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
            this.cmdExport.Location = new System.Drawing.Point(58, 130);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.Size = new System.Drawing.Size(65, 24);
            this.cmdExport.TabIndex = 4;
            this.cmdExport.Text = "&Export";
            this.cmdExport.UseVisualStyleBackColor = true;
            this.cmdExport.Click += new System.EventHandler(this.cmdExport_Click);
            // 
            // PlasmaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 554);
            this.Controls.Add(this.cmdExport);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtRoughness);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmdDraw);
            this.Controls.Add(this.plasma1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlasmaForm";
            this.Text = "Plasma";
            this.Load += new System.EventHandler(this.PlasmaForm_Load);
            this.Resize += new System.EventHandler(this.PlasmaForm_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FractalDraw.Plasma plasma1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdDraw;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label1;
        private FractalDraw.NumericTextbox txtRoughness;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel panXY;
        private System.Windows.Forms.ToolStripStatusLabel panStatus;
        private System.Windows.Forms.ToolStripStatusLabel panCoord;
        private System.Windows.Forms.Button cmdExport;
    }
}
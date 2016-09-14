namespace Fractalize
{
    partial class AboutBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelURL = new System.Windows.Forms.Label();
            this.cmdOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(253, 10);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(302, 102);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 25;
            this.logoPictureBox.TabStop = false;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(12, 118);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescription.Size = new System.Drawing.Size(543, 137);
            this.textBoxDescription.TabIndex = 26;
            this.textBoxDescription.TabStop = false;
            this.textBoxDescription.Text = "Description";
            // 
            // labelProductName
            // 
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(12, 9);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(235, 24);
            this.labelProductName.TabIndex = 28;
            this.labelProductName.Text = "Product Name";
            // 
            // labelVersion
            // 
            this.labelVersion.Location = new System.Drawing.Point(13, 33);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(142, 16);
            this.labelVersion.TabIndex = 29;
            this.labelVersion.Text = "Version";
            // 
            // labelCopyright
            // 
            this.labelCopyright.Location = new System.Drawing.Point(12, 77);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(235, 16);
            this.labelCopyright.TabIndex = 30;
            this.labelCopyright.Text = "Copyright";
            // 
            // labelURL
            // 
            this.labelURL.Location = new System.Drawing.Point(13, 93);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(234, 16);
            this.labelURL.TabIndex = 31;
            this.labelURL.Text = "www.sergemeunier.com";
            // 
            // cmdOk
            // 
            this.cmdOk.Location = new System.Drawing.Point(476, 261);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(79, 29);
            this.cmdOk.TabIndex = 32;
            this.cmdOk.Text = "&Ok";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 301);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.labelURL);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.textBoxDescription);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "AboutBox";
            this.Load += new System.EventHandler(this.AboutBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.Button cmdOk;
    }
}
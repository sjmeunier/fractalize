namespace FractalDraw
{
    partial class Julia
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picFractal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFractal)).BeginInit();
            this.SuspendLayout();
            // 
            // picFractal
            // 
            this.picFractal.BackColor = System.Drawing.Color.Black;
            this.picFractal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFractal.Location = new System.Drawing.Point(0, 0);
            this.picFractal.Name = "picFractal";
            this.picFractal.Size = new System.Drawing.Size(272, 286);
            this.picFractal.TabIndex = 5;
            this.picFractal.TabStop = false;
            this.picFractal.MouseLeave += new System.EventHandler(this.picFractal_MouseLeave);
            this.picFractal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picFractal_MouseMove);
            this.picFractal.Click += new System.EventHandler(this.picFractal_Click);
            this.picFractal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picFractal_MouseDown);
            this.picFractal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picFractal_MouseUp);
            // 
            // Julia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picFractal);
            this.Name = "Julia";
            this.Size = new System.Drawing.Size(272, 286);
            this.Load += new System.EventHandler(this.Julia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFractal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picFractal;
    }
}

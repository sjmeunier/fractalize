namespace FractalDraw
{
    partial class Plasma
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
            this.picFractal.Size = new System.Drawing.Size(359, 327);
            this.picFractal.TabIndex = 1;
            this.picFractal.TabStop = false;
            this.picFractal.MouseLeave += new System.EventHandler(this.picFractal_MouseLeave);
            this.picFractal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picFractal_MouseMove);
            // 
            // Plasma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picFractal);
            this.Name = "Plasma";
            this.Size = new System.Drawing.Size(359, 327);
            this.Load += new System.EventHandler(this.Plasma_Load);
            this.Resize += new System.EventHandler(this.Plasma_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picFractal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picFractal;
    }
}

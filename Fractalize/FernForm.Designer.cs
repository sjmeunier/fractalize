namespace Fractalize
{
    partial class FernForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FernForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdDraw = new System.Windows.Forms.Button();
            this.fern1 = new FractalDraw.Fern();
            this.cmdSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtScale = new FractalDraw.NumericTextbox();
            this.txtIterations = new FractalDraw.NumericTextbox();
            this.txtCol2 = new FractalDraw.NumericTextbox();
            this.txtCol0 = new FractalDraw.NumericTextbox();
            this.txtCol1 = new FractalDraw.NumericTextbox();
            this.txtA0 = new FractalDraw.NumericTextbox();
            this.txtA1 = new FractalDraw.NumericTextbox();
            this.txtB0 = new FractalDraw.NumericTextbox();
            this.txtB1 = new FractalDraw.NumericTextbox();
            this.txtB2 = new FractalDraw.NumericTextbox();
            this.txtB5 = new FractalDraw.NumericTextbox();
            this.txtB4 = new FractalDraw.NumericTextbox();
            this.txtB3 = new FractalDraw.NumericTextbox();
            this.txtC5 = new FractalDraw.NumericTextbox();
            this.txtC4 = new FractalDraw.NumericTextbox();
            this.txtC3 = new FractalDraw.NumericTextbox();
            this.txtC2 = new FractalDraw.NumericTextbox();
            this.txtC1 = new FractalDraw.NumericTextbox();
            this.txtC0 = new FractalDraw.NumericTextbox();
            this.txtD5 = new FractalDraw.NumericTextbox();
            this.txtD4 = new FractalDraw.NumericTextbox();
            this.txtD3 = new FractalDraw.NumericTextbox();
            this.txtD2 = new FractalDraw.NumericTextbox();
            this.txtD1 = new FractalDraw.NumericTextbox();
            this.txtD0 = new FractalDraw.NumericTextbox();
            this.txtRand0 = new FractalDraw.NumericTextbox();
            this.txtRand1 = new FractalDraw.NumericTextbox();
            this.txtRand2 = new FractalDraw.NumericTextbox();
            this.txtRand3 = new FractalDraw.NumericTextbox();
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
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 108;
            this.label1.Text = "Scale";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 106;
            this.label8.Text = "Iterations";
            // 
            // cmdDraw
            // 
            this.cmdDraw.Location = new System.Drawing.Point(59, 463);
            this.cmdDraw.Name = "cmdDraw";
            this.cmdDraw.Size = new System.Drawing.Size(65, 24);
            this.cmdDraw.TabIndex = 29;
            this.cmdDraw.Text = "&Draw";
            this.cmdDraw.Click += new System.EventHandler(this.cmdDraw_Click);
            // 
            // fern1
            // 
            this.fern1.Location = new System.Drawing.Point(195, 0);
            this.fern1.Name = "fern1";
            this.fern1.Size = new System.Drawing.Size(518, 551);
            this.fern1.TabIndex = 110;
            this.fern1.TabStop = false;
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(59, 493);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(65, 24);
            this.cmdSave.TabIndex = 30;
            this.cmdSave.Text = "&Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 112;
            this.label2.Text = "A";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 116;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 123;
            this.label4.Text = "C";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 130;
            this.label5.Text = "D";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 137;
            this.label6.Text = "Random";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 142;
            this.label7.Text = "Color";
            // 
            // txtScale
            // 
            this.txtScale.CommaFormat = false;
            this.txtScale.CurrencyFormat = false;
            this.txtScale.DecimalPrecision = 0;
            this.txtScale.DisableFormat = false;
            this.txtScale.Location = new System.Drawing.Point(74, 30);
            this.txtScale.MaxValue = 25;
            this.txtScale.MinValue = 0;
            this.txtScale.Name = "txtScale";
            this.txtScale.PercentFormat = false;
            this.txtScale.ReadOnly = false;
            this.txtScale.Size = new System.Drawing.Size(50, 20);
            this.txtScale.TabIndex = 1;
            this.txtScale.UseMaxMin = false;
            // 
            // txtIterations
            // 
            this.txtIterations.CommaFormat = false;
            this.txtIterations.CurrencyFormat = false;
            this.txtIterations.DecimalPrecision = 0;
            this.txtIterations.DisableFormat = false;
            this.txtIterations.Location = new System.Drawing.Point(74, 5);
            this.txtIterations.MaxValue = 10000000;
            this.txtIterations.MinValue = 0;
            this.txtIterations.Name = "txtIterations";
            this.txtIterations.PercentFormat = false;
            this.txtIterations.ReadOnly = false;
            this.txtIterations.Size = new System.Drawing.Size(50, 20);
            this.txtIterations.TabIndex = 0;
            this.txtIterations.UseMaxMin = true;
            // 
            // txtCol2
            // 
            this.txtCol2.CommaFormat = false;
            this.txtCol2.CurrencyFormat = false;
            this.txtCol2.DecimalPrecision = 0;
            this.txtCol2.DisableFormat = false;
            this.txtCol2.Location = new System.Drawing.Point(92, 437);
            this.txtCol2.MaxValue = 255;
            this.txtCol2.MinValue = 0;
            this.txtCol2.Name = "txtCol2";
            this.txtCol2.PercentFormat = false;
            this.txtCol2.ReadOnly = false;
            this.txtCol2.Size = new System.Drawing.Size(32, 20);
            this.txtCol2.TabIndex = 28;
            this.txtCol2.UseMaxMin = true;
            // 
            // txtCol0
            // 
            this.txtCol0.CommaFormat = false;
            this.txtCol0.CurrencyFormat = false;
            this.txtCol0.DecimalPrecision = 0;
            this.txtCol0.DisableFormat = false;
            this.txtCol0.Location = new System.Drawing.Point(15, 437);
            this.txtCol0.MaxValue = 255;
            this.txtCol0.MinValue = 0;
            this.txtCol0.Name = "txtCol0";
            this.txtCol0.PercentFormat = false;
            this.txtCol0.ReadOnly = false;
            this.txtCol0.Size = new System.Drawing.Size(32, 20);
            this.txtCol0.TabIndex = 26;
            this.txtCol0.UseMaxMin = true;
            // 
            // txtCol1
            // 
            this.txtCol1.CommaFormat = false;
            this.txtCol1.CurrencyFormat = false;
            this.txtCol1.DecimalPrecision = 0;
            this.txtCol1.DisableFormat = false;
            this.txtCol1.Location = new System.Drawing.Point(54, 437);
            this.txtCol1.MaxValue = 255;
            this.txtCol1.MinValue = 0;
            this.txtCol1.Name = "txtCol1";
            this.txtCol1.PercentFormat = false;
            this.txtCol1.ReadOnly = false;
            this.txtCol1.Size = new System.Drawing.Size(32, 20);
            this.txtCol1.TabIndex = 27;
            this.txtCol1.UseMaxMin = true;
            // 
            // txtA0
            // 
            this.txtA0.CommaFormat = false;
            this.txtA0.CurrencyFormat = false;
            this.txtA0.DecimalPrecision = 3;
            this.txtA0.DisableFormat = true;
            this.txtA0.Location = new System.Drawing.Point(15, 78);
            this.txtA0.MaxValue = 0;
            this.txtA0.MinValue = 0;
            this.txtA0.Name = "txtA0";
            this.txtA0.PercentFormat = false;
            this.txtA0.ReadOnly = false;
            this.txtA0.Size = new System.Drawing.Size(32, 20);
            this.txtA0.TabIndex = 2;
            this.txtA0.UseMaxMin = false;
            // 
            // txtA1
            // 
            this.txtA1.CommaFormat = false;
            this.txtA1.CurrencyFormat = false;
            this.txtA1.DecimalPrecision = 3;
            this.txtA1.DisableFormat = true;
            this.txtA1.Location = new System.Drawing.Point(53, 78);
            this.txtA1.MaxValue = 0;
            this.txtA1.MinValue = 0;
            this.txtA1.Name = "txtA1";
            this.txtA1.PercentFormat = false;
            this.txtA1.ReadOnly = false;
            this.txtA1.Size = new System.Drawing.Size(32, 20);
            this.txtA1.TabIndex = 3;
            this.txtA1.UseMaxMin = false;
            // 
            // txtB0
            // 
            this.txtB0.CommaFormat = false;
            this.txtB0.CurrencyFormat = false;
            this.txtB0.DecimalPrecision = 3;
            this.txtB0.DisableFormat = true;
            this.txtB0.Location = new System.Drawing.Point(15, 129);
            this.txtB0.MaxValue = 0;
            this.txtB0.MinValue = 0;
            this.txtB0.Name = "txtB0";
            this.txtB0.PercentFormat = false;
            this.txtB0.ReadOnly = false;
            this.txtB0.Size = new System.Drawing.Size(32, 20);
            this.txtB0.TabIndex = 4;
            this.txtB0.UseMaxMin = false;
            // 
            // txtB1
            // 
            this.txtB1.CommaFormat = false;
            this.txtB1.CurrencyFormat = false;
            this.txtB1.DecimalPrecision = 3;
            this.txtB1.DisableFormat = true;
            this.txtB1.Location = new System.Drawing.Point(54, 129);
            this.txtB1.MaxValue = 0;
            this.txtB1.MinValue = 0;
            this.txtB1.Name = "txtB1";
            this.txtB1.PercentFormat = false;
            this.txtB1.ReadOnly = false;
            this.txtB1.Size = new System.Drawing.Size(32, 20);
            this.txtB1.TabIndex = 5;
            this.txtB1.UseMaxMin = false;
            // 
            // txtB2
            // 
            this.txtB2.CommaFormat = false;
            this.txtB2.CurrencyFormat = false;
            this.txtB2.DecimalPrecision = 3;
            this.txtB2.DisableFormat = true;
            this.txtB2.Location = new System.Drawing.Point(92, 129);
            this.txtB2.MaxValue = 0;
            this.txtB2.MinValue = 0;
            this.txtB2.Name = "txtB2";
            this.txtB2.PercentFormat = false;
            this.txtB2.ReadOnly = false;
            this.txtB2.Size = new System.Drawing.Size(32, 20);
            this.txtB2.TabIndex = 6;
            this.txtB2.UseMaxMin = false;
            // 
            // txtB5
            // 
            this.txtB5.CommaFormat = false;
            this.txtB5.CurrencyFormat = false;
            this.txtB5.DecimalPrecision = 3;
            this.txtB5.DisableFormat = true;
            this.txtB5.Location = new System.Drawing.Point(92, 155);
            this.txtB5.MaxValue = 0;
            this.txtB5.MinValue = 0;
            this.txtB5.Name = "txtB5";
            this.txtB5.PercentFormat = false;
            this.txtB5.ReadOnly = false;
            this.txtB5.Size = new System.Drawing.Size(32, 20);
            this.txtB5.TabIndex = 9;
            this.txtB5.UseMaxMin = false;
            // 
            // txtB4
            // 
            this.txtB4.CommaFormat = false;
            this.txtB4.CurrencyFormat = false;
            this.txtB4.DecimalPrecision = 3;
            this.txtB4.DisableFormat = true;
            this.txtB4.Location = new System.Drawing.Point(54, 155);
            this.txtB4.MaxValue = 0;
            this.txtB4.MinValue = 0;
            this.txtB4.Name = "txtB4";
            this.txtB4.PercentFormat = false;
            this.txtB4.ReadOnly = false;
            this.txtB4.Size = new System.Drawing.Size(32, 20);
            this.txtB4.TabIndex = 8;
            this.txtB4.UseMaxMin = false;
            // 
            // txtB3
            // 
            this.txtB3.CommaFormat = false;
            this.txtB3.CurrencyFormat = false;
            this.txtB3.DecimalPrecision = 3;
            this.txtB3.DisableFormat = true;
            this.txtB3.Location = new System.Drawing.Point(15, 155);
            this.txtB3.MaxValue = 0;
            this.txtB3.MinValue = 0;
            this.txtB3.Name = "txtB3";
            this.txtB3.PercentFormat = false;
            this.txtB3.ReadOnly = false;
            this.txtB3.Size = new System.Drawing.Size(32, 20);
            this.txtB3.TabIndex = 7;
            this.txtB3.UseMaxMin = false;
            // 
            // txtC5
            // 
            this.txtC5.CommaFormat = false;
            this.txtC5.CurrencyFormat = false;
            this.txtC5.DecimalPrecision = 3;
            this.txtC5.DisableFormat = true;
            this.txtC5.Location = new System.Drawing.Point(92, 232);
            this.txtC5.MaxValue = 0;
            this.txtC5.MinValue = 0;
            this.txtC5.Name = "txtC5";
            this.txtC5.PercentFormat = false;
            this.txtC5.ReadOnly = false;
            this.txtC5.Size = new System.Drawing.Size(32, 20);
            this.txtC5.TabIndex = 15;
            this.txtC5.UseMaxMin = false;
            // 
            // txtC4
            // 
            this.txtC4.CommaFormat = false;
            this.txtC4.CurrencyFormat = false;
            this.txtC4.DecimalPrecision = 3;
            this.txtC4.DisableFormat = true;
            this.txtC4.Location = new System.Drawing.Point(54, 232);
            this.txtC4.MaxValue = 0;
            this.txtC4.MinValue = 0;
            this.txtC4.Name = "txtC4";
            this.txtC4.PercentFormat = false;
            this.txtC4.ReadOnly = false;
            this.txtC4.Size = new System.Drawing.Size(32, 20);
            this.txtC4.TabIndex = 14;
            this.txtC4.UseMaxMin = false;
            // 
            // txtC3
            // 
            this.txtC3.CommaFormat = false;
            this.txtC3.CurrencyFormat = false;
            this.txtC3.DecimalPrecision = 3;
            this.txtC3.DisableFormat = true;
            this.txtC3.Location = new System.Drawing.Point(15, 232);
            this.txtC3.MaxValue = 0;
            this.txtC3.MinValue = 0;
            this.txtC3.Name = "txtC3";
            this.txtC3.PercentFormat = false;
            this.txtC3.ReadOnly = false;
            this.txtC3.Size = new System.Drawing.Size(32, 20);
            this.txtC3.TabIndex = 13;
            this.txtC3.UseMaxMin = false;
            // 
            // txtC2
            // 
            this.txtC2.CommaFormat = false;
            this.txtC2.CurrencyFormat = false;
            this.txtC2.DecimalPrecision = 3;
            this.txtC2.DisableFormat = true;
            this.txtC2.Location = new System.Drawing.Point(92, 206);
            this.txtC2.MaxValue = 0;
            this.txtC2.MinValue = 0;
            this.txtC2.Name = "txtC2";
            this.txtC2.PercentFormat = false;
            this.txtC2.ReadOnly = false;
            this.txtC2.Size = new System.Drawing.Size(32, 20);
            this.txtC2.TabIndex = 12;
            this.txtC2.UseMaxMin = false;
            // 
            // txtC1
            // 
            this.txtC1.CommaFormat = false;
            this.txtC1.CurrencyFormat = false;
            this.txtC1.DecimalPrecision = 3;
            this.txtC1.DisableFormat = true;
            this.txtC1.Location = new System.Drawing.Point(54, 206);
            this.txtC1.MaxValue = 0;
            this.txtC1.MinValue = 0;
            this.txtC1.Name = "txtC1";
            this.txtC1.PercentFormat = false;
            this.txtC1.ReadOnly = false;
            this.txtC1.Size = new System.Drawing.Size(32, 20);
            this.txtC1.TabIndex = 11;
            this.txtC1.UseMaxMin = false;
            // 
            // txtC0
            // 
            this.txtC0.CommaFormat = false;
            this.txtC0.CurrencyFormat = false;
            this.txtC0.DecimalPrecision = 3;
            this.txtC0.DisableFormat = true;
            this.txtC0.Location = new System.Drawing.Point(15, 206);
            this.txtC0.MaxValue = 0;
            this.txtC0.MinValue = 0;
            this.txtC0.Name = "txtC0";
            this.txtC0.PercentFormat = false;
            this.txtC0.ReadOnly = false;
            this.txtC0.Size = new System.Drawing.Size(32, 20);
            this.txtC0.TabIndex = 10;
            this.txtC0.UseMaxMin = false;
            // 
            // txtD5
            // 
            this.txtD5.CommaFormat = false;
            this.txtD5.CurrencyFormat = false;
            this.txtD5.DecimalPrecision = 3;
            this.txtD5.DisableFormat = true;
            this.txtD5.Location = new System.Drawing.Point(92, 309);
            this.txtD5.MaxValue = 0;
            this.txtD5.MinValue = 0;
            this.txtD5.Name = "txtD5";
            this.txtD5.PercentFormat = false;
            this.txtD5.ReadOnly = false;
            this.txtD5.Size = new System.Drawing.Size(32, 20);
            this.txtD5.TabIndex = 21;
            this.txtD5.UseMaxMin = false;
            // 
            // txtD4
            // 
            this.txtD4.CommaFormat = false;
            this.txtD4.CurrencyFormat = false;
            this.txtD4.DecimalPrecision = 3;
            this.txtD4.DisableFormat = true;
            this.txtD4.Location = new System.Drawing.Point(54, 309);
            this.txtD4.MaxValue = 0;
            this.txtD4.MinValue = 0;
            this.txtD4.Name = "txtD4";
            this.txtD4.PercentFormat = false;
            this.txtD4.ReadOnly = false;
            this.txtD4.Size = new System.Drawing.Size(32, 20);
            this.txtD4.TabIndex = 20;
            this.txtD4.UseMaxMin = false;
            // 
            // txtD3
            // 
            this.txtD3.CommaFormat = false;
            this.txtD3.CurrencyFormat = false;
            this.txtD3.DecimalPrecision = 3;
            this.txtD3.DisableFormat = true;
            this.txtD3.Location = new System.Drawing.Point(15, 309);
            this.txtD3.MaxValue = 0;
            this.txtD3.MinValue = 0;
            this.txtD3.Name = "txtD3";
            this.txtD3.PercentFormat = false;
            this.txtD3.ReadOnly = false;
            this.txtD3.Size = new System.Drawing.Size(32, 20);
            this.txtD3.TabIndex = 19;
            this.txtD3.UseMaxMin = false;
            // 
            // txtD2
            // 
            this.txtD2.CommaFormat = false;
            this.txtD2.CurrencyFormat = false;
            this.txtD2.DecimalPrecision = 3;
            this.txtD2.DisableFormat = true;
            this.txtD2.Location = new System.Drawing.Point(92, 283);
            this.txtD2.MaxValue = 0;
            this.txtD2.MinValue = 0;
            this.txtD2.Name = "txtD2";
            this.txtD2.PercentFormat = false;
            this.txtD2.ReadOnly = false;
            this.txtD2.Size = new System.Drawing.Size(32, 20);
            this.txtD2.TabIndex = 18;
            this.txtD2.UseMaxMin = false;
            // 
            // txtD1
            // 
            this.txtD1.CommaFormat = false;
            this.txtD1.CurrencyFormat = false;
            this.txtD1.DecimalPrecision = 3;
            this.txtD1.DisableFormat = true;
            this.txtD1.Location = new System.Drawing.Point(54, 283);
            this.txtD1.MaxValue = 0;
            this.txtD1.MinValue = 0;
            this.txtD1.Name = "txtD1";
            this.txtD1.PercentFormat = false;
            this.txtD1.ReadOnly = false;
            this.txtD1.Size = new System.Drawing.Size(32, 20);
            this.txtD1.TabIndex = 17;
            this.txtD1.UseMaxMin = false;
            // 
            // txtD0
            // 
            this.txtD0.CommaFormat = false;
            this.txtD0.CurrencyFormat = false;
            this.txtD0.DecimalPrecision = 3;
            this.txtD0.DisableFormat = true;
            this.txtD0.Location = new System.Drawing.Point(15, 283);
            this.txtD0.MaxValue = 0;
            this.txtD0.MinValue = 0;
            this.txtD0.Name = "txtD0";
            this.txtD0.PercentFormat = false;
            this.txtD0.ReadOnly = false;
            this.txtD0.Size = new System.Drawing.Size(32, 20);
            this.txtD0.TabIndex = 16;
            this.txtD0.UseMaxMin = false;
            // 
            // txtRand0
            // 
            this.txtRand0.CommaFormat = false;
            this.txtRand0.CurrencyFormat = false;
            this.txtRand0.DecimalPrecision = 0;
            this.txtRand0.DisableFormat = false;
            this.txtRand0.Location = new System.Drawing.Point(15, 360);
            this.txtRand0.MaxValue = 10000000;
            this.txtRand0.MinValue = 0;
            this.txtRand0.Name = "txtRand0";
            this.txtRand0.PercentFormat = false;
            this.txtRand0.ReadOnly = false;
            this.txtRand0.Size = new System.Drawing.Size(32, 20);
            this.txtRand0.TabIndex = 22;
            this.txtRand0.UseMaxMin = true;
            // 
            // txtRand1
            // 
            this.txtRand1.CommaFormat = false;
            this.txtRand1.CurrencyFormat = false;
            this.txtRand1.DecimalPrecision = 0;
            this.txtRand1.DisableFormat = false;
            this.txtRand1.Location = new System.Drawing.Point(54, 360);
            this.txtRand1.MaxValue = 10000000;
            this.txtRand1.MinValue = 0;
            this.txtRand1.Name = "txtRand1";
            this.txtRand1.PercentFormat = false;
            this.txtRand1.ReadOnly = false;
            this.txtRand1.Size = new System.Drawing.Size(32, 20);
            this.txtRand1.TabIndex = 23;
            this.txtRand1.UseMaxMin = true;
            // 
            // txtRand2
            // 
            this.txtRand2.CommaFormat = false;
            this.txtRand2.CurrencyFormat = false;
            this.txtRand2.DecimalPrecision = 0;
            this.txtRand2.DisableFormat = false;
            this.txtRand2.Location = new System.Drawing.Point(92, 360);
            this.txtRand2.MaxValue = 10000000;
            this.txtRand2.MinValue = 0;
            this.txtRand2.Name = "txtRand2";
            this.txtRand2.PercentFormat = false;
            this.txtRand2.ReadOnly = false;
            this.txtRand2.Size = new System.Drawing.Size(32, 20);
            this.txtRand2.TabIndex = 24;
            this.txtRand2.UseMaxMin = true;
            // 
            // txtRand3
            // 
            this.txtRand3.CommaFormat = false;
            this.txtRand3.CurrencyFormat = false;
            this.txtRand3.DecimalPrecision = 0;
            this.txtRand3.DisableFormat = false;
            this.txtRand3.Location = new System.Drawing.Point(15, 386);
            this.txtRand3.MaxValue = 10000000;
            this.txtRand3.MinValue = 0;
            this.txtRand3.Name = "txtRand3";
            this.txtRand3.PercentFormat = false;
            this.txtRand3.ReadOnly = false;
            this.txtRand3.Size = new System.Drawing.Size(32, 20);
            this.txtRand3.TabIndex = 25;
            this.txtRand3.UseMaxMin = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panXY,
            this.panStatus,
            this.panCoord});
            this.statusStrip1.Location = new System.Drawing.Point(0, 554);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(714, 22);
            this.statusStrip1.TabIndex = 193;
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
            this.cmdExport.Location = new System.Drawing.Point(59, 523);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.Size = new System.Drawing.Size(65, 24);
            this.cmdExport.TabIndex = 31;
            this.cmdExport.Text = "&Export";
            this.cmdExport.UseVisualStyleBackColor = true;
            this.cmdExport.Click += new System.EventHandler(this.cmdExport_Click);
            // 
            // FernForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 576);
            this.Controls.Add(this.cmdExport);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtRand3);
            this.Controls.Add(this.txtRand2);
            this.Controls.Add(this.txtRand1);
            this.Controls.Add(this.txtRand0);
            this.Controls.Add(this.txtD5);
            this.Controls.Add(this.txtD4);
            this.Controls.Add(this.txtD3);
            this.Controls.Add(this.txtD2);
            this.Controls.Add(this.txtD1);
            this.Controls.Add(this.txtD0);
            this.Controls.Add(this.txtC5);
            this.Controls.Add(this.txtC4);
            this.Controls.Add(this.txtC3);
            this.Controls.Add(this.txtC2);
            this.Controls.Add(this.txtC1);
            this.Controls.Add(this.txtC0);
            this.Controls.Add(this.txtB5);
            this.Controls.Add(this.txtB4);
            this.Controls.Add(this.txtB3);
            this.Controls.Add(this.txtB2);
            this.Controls.Add(this.txtB1);
            this.Controls.Add(this.txtB0);
            this.Controls.Add(this.txtA1);
            this.Controls.Add(this.txtA0);
            this.Controls.Add(this.txtCol2);
            this.Controls.Add(this.txtCol0);
            this.Controls.Add(this.txtCol1);
            this.Controls.Add(this.txtScale);
            this.Controls.Add(this.txtIterations);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.fern1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmdDraw);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FernForm";
            this.Text = "Fern";
            this.Load += new System.EventHandler(this.FernForm_Load);
            this.Resize += new System.EventHandler(this.FernForm_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cmdDraw;
        private FractalDraw.Fern fern1;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private FractalDraw.NumericTextbox txtScale;
        private FractalDraw.NumericTextbox txtIterations;
        private FractalDraw.NumericTextbox txtCol2;
        private FractalDraw.NumericTextbox txtCol0;
        private FractalDraw.NumericTextbox txtCol1;
        private FractalDraw.NumericTextbox txtA0;
        private FractalDraw.NumericTextbox txtA1;
        private FractalDraw.NumericTextbox txtB0;
        private FractalDraw.NumericTextbox txtB1;
        private FractalDraw.NumericTextbox txtB2;
        private FractalDraw.NumericTextbox txtB5;
        private FractalDraw.NumericTextbox txtB4;
        private FractalDraw.NumericTextbox txtB3;
        private FractalDraw.NumericTextbox txtC5;
        private FractalDraw.NumericTextbox txtC4;
        private FractalDraw.NumericTextbox txtC3;
        private FractalDraw.NumericTextbox txtC2;
        private FractalDraw.NumericTextbox txtC1;
        private FractalDraw.NumericTextbox txtC0;
        private FractalDraw.NumericTextbox txtD5;
        private FractalDraw.NumericTextbox txtD4;
        private FractalDraw.NumericTextbox txtD3;
        private FractalDraw.NumericTextbox txtD2;
        private FractalDraw.NumericTextbox txtD1;
        private FractalDraw.NumericTextbox txtD0;
        private FractalDraw.NumericTextbox txtRand0;
        private FractalDraw.NumericTextbox txtRand1;
        private FractalDraw.NumericTextbox txtRand2;
        private FractalDraw.NumericTextbox txtRand3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel panXY;
        private System.Windows.Forms.ToolStripStatusLabel panStatus;
        private System.Windows.Forms.ToolStripStatusLabel panCoord;
        private System.Windows.Forms.Button cmdExport;
    }
}
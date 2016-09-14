using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace FractalDraw
{
    /// <summary>
    /// Custom control that handles numeric values.
    /// Supports comma formatting, percentages, currency, adn decimal precision.
    /// Author: Cody Powell
    /// Contact: cody@codypowell.com
    /// </summary>

    /// <license>
    /// This library is free software; you can redistribute it and/or modify
    /// it under the terms fo the GNU General Public License as published by 
    /// the Free Software Foundation.
    /// 
    /// This program is distributed in the hope that it will be useful, but
    /// without any warranty.
    /// </license>
    public class NumericTextbox : System.Windows.Forms.UserControl
    {
        private System.Windows.Forms.TextBox txtNumeric;
        protected bool nonNumberEntered;
        protected bool commaFormat;
        protected bool percentFormat;
        protected bool currencyFormat;
        protected bool disableFormat;
        protected char prefix;
        protected char suffix;
        protected int maxValue;
        protected int minValue;
        protected bool useMaxMin;

        protected int decimalPrecision;

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        /// <summary>
        /// Constructor is largely blank.
        /// </summary>
        public NumericTextbox()
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();

            //makes the blanks easier to spot.
            prefix = char.MinValue;
            suffix = char.MinValue;
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.txtNumeric = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNumeric
            // 
            this.txtNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeric.Location = new System.Drawing.Point(0, 0);
            this.txtNumeric.Name = "txtNumeric";
            this.txtNumeric.Size = new System.Drawing.Size(100, 20);
            this.txtNumeric.TabIndex = 0;
            this.txtNumeric.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeric_KeyDown);
            this.txtNumeric.Leave += new System.EventHandler(this.txtNumeric_Leave);
            this.txtNumeric.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeric_KeyPress);
            // 
            // NumericTextbox
            // 
            this.Controls.Add(this.txtNumeric);
            this.Name = "NumericTextbox";
            this.Size = new System.Drawing.Size(100, 20);
            this.Load += new System.EventHandler(this.NumericTextbox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Check Methods
        /// <summary>
        /// minus can only be at the start of the number, and there can only be one.
        /// </summary>
        /// <returns>If it's a bad minus, we return true.</returns>
        protected bool CheckMinus()
        {
            return (txtNumeric.Text.IndexOf("-") > -1) || (txtNumeric.SelectionStart > 0);
        }

        /// <summary>
        /// period can only occur once in number.
        /// </summary>
        /// <returns>If it's a bad period, we return true.</returns>
        protected bool CheckPeriod()
        {
            return (txtNumeric.Text.IndexOf(".") > -1);
        }
        #endregion

        #region UI Logic
        /// <summary>
        /// A good deal of this specific method is taken from an MSDN article (no link onhand).
        /// Basically, this is the method that determines whether or not the user has entered
        /// a valid input (number, or appropriate mark-up sign).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void txtNumeric_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            //If a non number is entered, we don't want to recognize it as valid input.
            //thus, we need a flag we can track.
            nonNumberEntered = false;

            // Determine whether the keystroke is a number from the top of the keyboard.
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    //there are certain rules for determining if it's valid to use a period or a minus.
                    //we need to check those rules.
                    if (e.KeyCode == Keys.OemMinus)
                        nonNumberEntered = CheckMinus();
                    else if (e.KeyCode == Keys.OemPeriod)
                        nonNumberEntered = CheckPeriod();
                    else if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                    }
                }
            }
        }

        /// <summary>
        /// Checks to see if we caught any bad characters.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void txtNumeric_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                // If bad, mark it as handled so it doesn't show up.
                e.Handled = true;
            }
        }

        /// <summary>
        /// Makes sure the number is pretty for the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void txtNumeric_Leave(object sender, System.EventArgs e)
        {
            try
            {
                //if our number field has some text in it, let's apply our formatting
                //rules so they get something purty.
                txtNumeric.Text = FormatNumberForDisplay(txtNumeric.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Accessors
        /// <summary>
        /// Allows the user to get/set the value fo the textbox.
        /// </summary>
        public override string Text
        {
            get
            {
                //our format for output is a little bit different than our
                //format for display.
                return FormatNumberForOutput(txtNumeric.Text);
            }
            set
            {
                //If the user supplies a val, let's apply our formatting rules to it.
                txtNumeric.Text = FormatNumberForDisplay(value);
            }
        }

        /// <summary>
        /// Allows the user to get/set the readonly status of the textbox.
        /// </summary>
        public bool ReadOnly
        {
            get
            {
                return txtNumeric.ReadOnly;
            }
            set
            {
                txtNumeric.ReadOnly = value;
            }
        }

        /// <summary>
        /// Allows the user to get/set the DisableFormat status.
        /// </summary>
        public bool DisableFormat
        {
            get
            {
                return disableFormat;
            }
            set
            {
                disableFormat = value;
            }
        }

        /// <summary>
        /// Allows the user to get/set the MaxValue status.
        /// </summary>
        public int MaxValue
        {
            get
            {
                return maxValue;
            }
            set
            {
                maxValue = value;
            }
        }

        /// <summary>
        /// Allows the user to get/set the MinValue status.
        /// </summary>
        public int MinValue
        {
            get
            {
                return minValue;
            }
            set
            {
                minValue = value;
            }
        }

        /// <summary>
        /// Allows the user to get/set the useMaxMin status.
        /// </summary>
        public bool UseMaxMin
        {
            get
            {
                return useMaxMin;
            }
            set
            {
                useMaxMin = value;
            }
        }

        /// <summary>
        /// Allows the user to get/set the CommaFormat status.
        /// </summary>
        public bool CommaFormat
        {
            get
            {
                return commaFormat;
            }
            set
            {
                commaFormat = value;
            }
        }

        /// <summary>
        /// Allows the user to get/set percent formatting.
        /// </summary>
        public bool PercentFormat
        {
            get
            {
                return percentFormat;
            }

            set
            {
                percentFormat = value;

                if (percentFormat)
                {
                    suffix = '%';
                    currencyFormat = false;
                    decimalPrecision = 2;
                }
            }
        }

        /// <summary>
        /// Allows the user to get/set currency formatting.
        /// </summary>
        public bool CurrencyFormat
        {
            get
            {
                return currencyFormat;
            }

            set
            {
                currencyFormat = value;

                if (currencyFormat)
                {
                    prefix = '$';
                    percentFormat = false;
                    decimalPrecision = 2;
                    commaFormat = true;
                }
            }
        }

        /// <summary>
        /// Allows the user to get/set decimal precision
        /// </summary>
        public int DecimalPrecision
        {
            get
            {
                return decimalPrecision;
            }
            set
            {
                decimalPrecision = value;
            }
        }
        #endregion

        #region Formatting
        /// <summary>
        /// Formatting the number for display means we apply our rules
        /// so that the user gets something like 10,000 or 5.30% 
        /// (depending on settings)
        /// </summary>
        /// <param name="val">the number to mark-up</param>
        /// <returns>mark-uped number</returns>
        protected string FormatNumberForDisplay(string val)
        {
            if (val.Length == 0)
                return null;

            if (useMaxMin == true)
            {
                if (Convert.ToDouble(val) > maxValue)
                {
                    val = maxValue.ToString();
                }
                if (Convert.ToDouble(val) < minValue)
                {
                    val = minValue.ToString();
                }
            }
            if (disableFormat == true)
                return val;
            
            string returnVal;
            string decimalPlaces = "";

            val = StripPrefixSuffix(val);

            for (int i = 0; i < decimalPrecision; i++)
            {
                decimalPlaces += "0";
            }

            //format provider for comma formatting.
            string commaFormatString = "#,##0." + decimalPlaces + ";(#,##0." + decimalPlaces + ");0";
            string regFormatString = "###0." + decimalPlaces + ";(###0." + decimalPlaces + ");0";

            double myVal = Double.Parse(val);

            if (commaFormat)
            {
                //if comma formatting is enabled, we apply our format
                //provider.
                returnVal = myVal.ToString(commaFormatString);
            }
            else
            {
                returnVal = myVal.ToString(regFormatString);
            }

            //if there's a prefix ($) or suffix (%), let's apply those.
            if (prefix != char.MinValue)
                returnVal = prefix + returnVal;

            if (suffix != char.MinValue)
                returnVal += suffix;

            return returnVal;
        }

        /// <summary>
        /// If we're formatting for output (that is to say, formatting
        /// to return this as a variable, we need to strip some of our
        /// characters, like % and $.
        /// </summary>
        /// <param name="val">number to strip mark-up</param>
        /// <returns>stripped number</returns>
        protected string FormatNumberForOutput(string val)
        {
            string retVal = StripPrefixSuffix(val);

            //if it's a percent, divide it by 100, since we display things
            //as 5.00%, isntead of .05.
            if (percentFormat)
                retVal = (Double.Parse(retVal) / 100).ToString();

            return retVal;
        }

        protected string StripPrefixSuffix(string val)
        {
            if (val.Length == 0)
                return null;

            int start = val.IndexOf(prefix);
            int end = val.IndexOf(suffix);

            string retVal = "";

            if (start < 0)
                start = -1;

            start++;

            if (end < 0)
                end = val.Length;

            //get the portion of the string without the prefix or suffix.
            retVal = val.Substring(start, end - start);

            return retVal;
        }
        #endregion

        private void NumericTextbox_Load(object sender, EventArgs e)
        {

        }
    }
}

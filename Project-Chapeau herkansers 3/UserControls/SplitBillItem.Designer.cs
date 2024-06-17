namespace Project_Chapeau_herkansers_3.UserControls
{
    partial class SplitBillItem
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
            this.comboPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.inputPayAmount = new System.Windows.Forms.TextBox();
            this.lblPaymentAmount = new System.Windows.Forms.Label();
            this.lblTipAmount = new System.Windows.Forms.Label();
            this.inputTipAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboPaymentMethod
            // 
            this.comboPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPaymentMethod.FormattingEnabled = true;
            this.comboPaymentMethod.Items.AddRange(new object[] {
            "Debit Card",
            "VISA/AMEX",
            "Cash"});
            this.comboPaymentMethod.Location = new System.Drawing.Point(18, 31);
            this.comboPaymentMethod.Name = "comboPaymentMethod";
            this.comboPaymentMethod.Size = new System.Drawing.Size(97, 23);
            this.comboPaymentMethod.TabIndex = 0;
            this.comboPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.comboPaymentMethod_SelectedIndexChanged);
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(16, 13);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(99, 15);
            this.lblMethod.TabIndex = 1;
            this.lblMethod.Text = "Payment Method";
            // 
            // inputPayAmount
            // 
            this.inputPayAmount.Location = new System.Drawing.Point(130, 31);
            this.inputPayAmount.Name = "inputPayAmount";
            this.inputPayAmount.Size = new System.Drawing.Size(81, 23);
            this.inputPayAmount.TabIndex = 2;
            this.inputPayAmount.Text = "0.00";
            this.inputPayAmount.TextChanged += new System.EventHandler(this.inputPayAmount_TextChanged);
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.AutoSize = true;
            this.lblPaymentAmount.Location = new System.Drawing.Point(130, 13);
            this.lblPaymentAmount.Name = "lblPaymentAmount";
            this.lblPaymentAmount.Size = new System.Drawing.Size(81, 15);
            this.lblPaymentAmount.TabIndex = 3;
            this.lblPaymentAmount.Text = "Amount (in €)";
            // 
            // lblTipAmount
            // 
            this.lblTipAmount.AutoSize = true;
            this.lblTipAmount.Location = new System.Drawing.Point(225, 13);
            this.lblTipAmount.Name = "lblTipAmount";
            this.lblTipAmount.Size = new System.Drawing.Size(53, 15);
            this.lblTipAmount.TabIndex = 5;
            this.lblTipAmount.Text = "Tip (in €)";
            // 
            // inputTipAmount
            // 
            this.inputTipAmount.Location = new System.Drawing.Point(225, 31);
            this.inputTipAmount.Name = "inputTipAmount";
            this.inputTipAmount.Size = new System.Drawing.Size(81, 23);
            this.inputTipAmount.TabIndex = 4;
            this.inputTipAmount.Text = "0.00";
            this.inputTipAmount.TextChanged += new System.EventHandler(this.inputTipAmount_TextChanged);
            // 
            // SplitBillItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.Controls.Add(this.lblTipAmount);
            this.Controls.Add(this.inputTipAmount);
            this.Controls.Add(this.lblPaymentAmount);
            this.Controls.Add(this.inputPayAmount);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.comboPaymentMethod);
            this.Name = "SplitBillItem";
            this.Size = new System.Drawing.Size(321, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboPaymentMethod;
        private Label lblMethod;
        private TextBox inputPayAmount;
        private Label lblPaymentAmount;
        private Label lblTipAmount;
        private TextBox inputTipAmount;
    }
}

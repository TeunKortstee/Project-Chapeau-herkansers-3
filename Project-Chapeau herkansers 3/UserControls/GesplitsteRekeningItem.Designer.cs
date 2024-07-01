namespace Project_Chapeau_herkansers_3.UserControls
{
    partial class GesplitsteRekeningItem
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
            this.comboBetaalMethode = new System.Windows.Forms.ComboBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.inputBetaalHoeveelheid = new System.Windows.Forms.TextBox();
            this.lblPaymentAmount = new System.Windows.Forms.Label();
            this.lblTipAmount = new System.Windows.Forms.Label();
            this.inputFooiHoeveelheid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboPaymentMethod
            // 
            this.comboBetaalMethode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBetaalMethode.FormattingEnabled = true;
            this.comboBetaalMethode.Items.AddRange(new object[] {
            "Debitkaart",
            "VISA/AMEX",
            "Contant"});
            this.comboBetaalMethode.Location = new System.Drawing.Point(18, 31);
            this.comboBetaalMethode.Name = "comboPaymentMethod";
            this.comboBetaalMethode.Size = new System.Drawing.Size(97, 23);
            this.comboBetaalMethode.TabIndex = 0;
            this.comboBetaalMethode.SelectedIndexChanged += new System.EventHandler(this.comboPaymentMethod_SelectedIndexChanged);
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(16, 13);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(55, 15);
            this.lblMethod.TabIndex = 1;
            this.lblMethod.Text = "Methode";
            // 
            // inputPayAmount
            // 
            this.inputBetaalHoeveelheid.Location = new System.Drawing.Point(130, 31);
            this.inputBetaalHoeveelheid.Name = "inputPayAmount";
            this.inputBetaalHoeveelheid.Size = new System.Drawing.Size(81, 23);
            this.inputBetaalHoeveelheid.TabIndex = 2;
            this.inputBetaalHoeveelheid.Text = "0.00";
            this.inputBetaalHoeveelheid.TextChanged += new System.EventHandler(this.inputPayAmount_TextChanged);
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.AutoSize = true;
            this.lblPaymentAmount.Location = new System.Drawing.Point(130, 13);
            this.lblPaymentAmount.Name = "lblPaymentAmount";
            this.lblPaymentAmount.Size = new System.Drawing.Size(76, 15);
            this.lblPaymentAmount.TabIndex = 3;
            this.lblPaymentAmount.Text = "Betaald (in €)";
            // 
            // lblTipAmount
            // 
            this.lblTipAmount.AutoSize = true;
            this.lblTipAmount.Location = new System.Drawing.Point(225, 13);
            this.lblTipAmount.Name = "lblTipAmount";
            this.lblTipAmount.Size = new System.Drawing.Size(60, 15);
            this.lblTipAmount.TabIndex = 5;
            this.lblTipAmount.Text = "Fooi (in €)";
            // 
            // inputTipAmount
            // 
            this.inputFooiHoeveelheid.Location = new System.Drawing.Point(225, 31);
            this.inputFooiHoeveelheid.Name = "inputTipAmount";
            this.inputFooiHoeveelheid.Size = new System.Drawing.Size(81, 23);
            this.inputFooiHoeveelheid.TabIndex = 4;
            this.inputFooiHoeveelheid.Text = "0.00";
            this.inputFooiHoeveelheid.TextChanged += new System.EventHandler(this.inputTipAmount_TextChanged);
            // 
            // SplitBillItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.Controls.Add(this.lblTipAmount);
            this.Controls.Add(this.inputFooiHoeveelheid);
            this.Controls.Add(this.lblPaymentAmount);
            this.Controls.Add(this.inputBetaalHoeveelheid);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.comboBetaalMethode);
            this.Name = "SplitBillItem";
            this.Size = new System.Drawing.Size(321, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBetaalMethode;
        private Label lblMethod;
        private TextBox inputBetaalHoeveelheid;
        private Label lblPaymentAmount;
        private Label lblTipAmount;
        private TextBox inputFooiHoeveelheid;
    }
}

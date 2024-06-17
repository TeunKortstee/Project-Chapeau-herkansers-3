namespace Project_Chapeau_herkansers_3
{
    partial class BetalingScherm
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
            this.payementsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.inputSplitAmount = new System.Windows.Forms.TextBox();
            this.lblSplitAmount = new System.Windows.Forms.Label();
            this.btnConfirmSplit = new System.Windows.Forms.Button();
            this.lblAmountTitle = new System.Windows.Forms.Label();
            this.lblAmountToBePaid = new System.Windows.Forms.Label();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.lblAmountTitle2 = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblTipTitle = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblSplitAmountErrorText = new System.Windows.Forms.Label();
            this.lblPaymentErrorText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // payementsPanel
            // 
            this.payementsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.payementsPanel.AutoScroll = true;
            this.payementsPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.payementsPanel.Location = new System.Drawing.Point(25, 114);
            this.payementsPanel.Name = "payementsPanel";
            this.payementsPanel.Size = new System.Drawing.Size(355, 297);
            this.payementsPanel.TabIndex = 0;
            // 
            // inputSplitAmount
            // 
            this.inputSplitAmount.Location = new System.Drawing.Point(25, 67);
            this.inputSplitAmount.Name = "inputSplitAmount";
            this.inputSplitAmount.Size = new System.Drawing.Size(273, 23);
            this.inputSplitAmount.TabIndex = 1;
            this.inputSplitAmount.Text = "1";
            this.inputSplitAmount.TextChanged += new System.EventHandler(this.inputSplitAmount_TextChanged);
            // 
            // lblSplitAmount
            // 
            this.lblSplitAmount.AutoSize = true;
            this.lblSplitAmount.Location = new System.Drawing.Point(21, 43);
            this.lblSplitAmount.Name = "lblSplitAmount";
            this.lblSplitAmount.Size = new System.Drawing.Size(155, 15);
            this.lblSplitAmount.TabIndex = 2;
            this.lblSplitAmount.Text = "Hoeveel mensen betalen er?";
            // 
            // btnConfirmSplit
            // 
            this.btnConfirmSplit.Location = new System.Drawing.Point(304, 67);
            this.btnConfirmSplit.Name = "btnConfirmSplit";
            this.btnConfirmSplit.Size = new System.Drawing.Size(79, 23);
            this.btnConfirmSplit.TabIndex = 3;
            this.btnConfirmSplit.Text = "OK";
            this.btnConfirmSplit.UseVisualStyleBackColor = true;
            this.btnConfirmSplit.Click += new System.EventHandler(this.btnConfirmSplit_Click);
            // 
            // lblAmountTitle
            // 
            this.lblAmountTitle.AutoSize = true;
            this.lblAmountTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAmountTitle.Location = new System.Drawing.Point(25, 450);
            this.lblAmountTitle.Name = "lblAmountTitle";
            this.lblAmountTitle.Size = new System.Drawing.Size(198, 15);
            this.lblAmountTitle.TabIndex = 4;
            this.lblAmountTitle.Text = "Hoeveel er betaald moet worden: ";
            // 
            // lblAmountToBePaid
            // 
            this.lblAmountToBePaid.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAmountToBePaid.Location = new System.Drawing.Point(221, 446);
            this.lblAmountToBePaid.Name = "lblAmountToBePaid";
            this.lblAmountToBePaid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAmountToBePaid.Size = new System.Drawing.Size(159, 25);
            this.lblAmountToBePaid.TabIndex = 5;
            this.lblAmountToBePaid.Text = "€  0.00\r\n";
            this.lblAmountToBePaid.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAmountPaid.Location = new System.Drawing.Point(221, 421);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAmountPaid.Size = new System.Drawing.Size(159, 25);
            this.lblAmountPaid.TabIndex = 7;
            this.lblAmountPaid.Text = "€  0.00\r\n";
            this.lblAmountPaid.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAmountTitle2
            // 
            this.lblAmountTitle2.AutoSize = true;
            this.lblAmountTitle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAmountTitle2.Location = new System.Drawing.Point(25, 425);
            this.lblAmountTitle2.Name = "lblAmountTitle2";
            this.lblAmountTitle2.Size = new System.Drawing.Size(55, 15);
            this.lblAmountTitle2.TabIndex = 6;
            this.lblAmountTitle2.Text = "Betaald: ";
            // 
            // lblChange
            // 
            this.lblChange.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChange.Location = new System.Drawing.Point(221, 471);
            this.lblChange.Name = "lblChange";
            this.lblChange.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblChange.Size = new System.Drawing.Size(159, 25);
            this.lblChange.TabIndex = 9;
            this.lblChange.Text = "€  0.00\r\n";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Wisselgeld: ";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.SandyBrown;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPay.Location = new System.Drawing.Point(25, 544);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(358, 49);
            this.btnPay.TabIndex = 10;
            this.btnPay.Text = "Betaal";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblTipTitle
            // 
            this.lblTipTitle.AutoSize = true;
            this.lblTipTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTipTitle.Location = new System.Drawing.Point(25, 500);
            this.lblTipTitle.Name = "lblTipTitle";
            this.lblTipTitle.Size = new System.Drawing.Size(31, 15);
            this.lblTipTitle.TabIndex = 11;
            this.lblTipTitle.Text = "Fooi:";
            // 
            // lblTip
            // 
            this.lblTip.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTip.Location = new System.Drawing.Point(221, 496);
            this.lblTip.Name = "lblTip";
            this.lblTip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTip.Size = new System.Drawing.Size(159, 25);
            this.lblTip.TabIndex = 12;
            this.lblTip.Text = "€  0.00\r\n";
            this.lblTip.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSplitAmountErrorText
            // 
            this.lblSplitAmountErrorText.AutoSize = true;
            this.lblSplitAmountErrorText.ForeColor = System.Drawing.Color.Red;
            this.lblSplitAmountErrorText.Location = new System.Drawing.Point(25, 93);
            this.lblSplitAmountErrorText.Name = "lblSplitAmountErrorText";
            this.lblSplitAmountErrorText.Size = new System.Drawing.Size(0, 15);
            this.lblSplitAmountErrorText.TabIndex = 13;
            // 
            // lblPaymentErrorText
            // 
            this.lblPaymentErrorText.AutoSize = true;
            this.lblPaymentErrorText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPaymentErrorText.ForeColor = System.Drawing.Color.Red;
            this.lblPaymentErrorText.Location = new System.Drawing.Point(28, 597);
            this.lblPaymentErrorText.Name = "lblPaymentErrorText";
            this.lblPaymentErrorText.Size = new System.Drawing.Size(0, 15);
            this.lblPaymentErrorText.TabIndex = 14;
            // 
            // BetalingScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblPaymentErrorText);
            this.Controls.Add(this.lblSplitAmountErrorText);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblTipTitle);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAmountPaid);
            this.Controls.Add(this.lblAmountTitle2);
            this.Controls.Add(this.lblAmountToBePaid);
            this.Controls.Add(this.lblAmountTitle);
            this.Controls.Add(this.btnConfirmSplit);
            this.Controls.Add(this.lblSplitAmount);
            this.Controls.Add(this.inputSplitAmount);
            this.Controls.Add(this.payementsPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BetalingScherm";
            this.Size = new System.Drawing.Size(407, 631);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel payementsPanel;
        private TextBox inputSplitAmount;
        private Label lblSplitAmount;
        private Button btnConfirmSplit;
        private Label lblAmountTitle;
        private Label lblAmountToBePaid;
        private Label lblAmountPaid;
        private Label lblAmountTitle2;
        private Label lblChange;
        private Label label2;
        private Button btnPay;
        private Label lblTipTitle;
        private Label lblTip;
        private Label lblSplitAmountErrorText;
        private Label lblPaymentErrorText;
    }
}

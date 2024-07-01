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
            this.betalingenPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.inputSplitAmount = new System.Windows.Forms.TextBox();
            this.lblSplitAmount = new System.Windows.Forms.Label();
            this.btnConfirmSplit = new System.Windows.Forms.Button();
            this.lblAmountTitle = new System.Windows.Forms.Label();
            this.labelHoeveelheidOmTeBetalen = new System.Windows.Forms.Label();
            this.labelHoeveelheidBetaald = new System.Windows.Forms.Label();
            this.lblAmountTitle2 = new System.Windows.Forms.Label();
            this.labelWisselgeld = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblTipTitle = new System.Windows.Forms.Label();
            this.labelFooi = new System.Windows.Forms.Label();
            this.lblSplitAmountErrorText = new System.Windows.Forms.Label();
            this.lblPaymentErrorText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // betalingenPanel
            // 
            this.betalingenPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.betalingenPanel.AutoScroll = true;
            this.betalingenPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.betalingenPanel.Location = new System.Drawing.Point(25, 114);
            this.betalingenPanel.Name = "betalingenPanel";
            this.betalingenPanel.Size = new System.Drawing.Size(355, 297);
            this.betalingenPanel.TabIndex = 0;
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
            // labelHoeveelheidOmTeBetalen
            // 
            this.labelHoeveelheidOmTeBetalen.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHoeveelheidOmTeBetalen.Location = new System.Drawing.Point(221, 446);
            this.labelHoeveelheidOmTeBetalen.Name = "labelHoeveelheidOmTeBetalen";
            this.labelHoeveelheidOmTeBetalen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelHoeveelheidOmTeBetalen.Size = new System.Drawing.Size(159, 25);
            this.labelHoeveelheidOmTeBetalen.TabIndex = 5;
            this.labelHoeveelheidOmTeBetalen.Text = "€  0.00\r\n";
            this.labelHoeveelheidOmTeBetalen.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelHoeveelheidBetaald
            // 
            this.labelHoeveelheidBetaald.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHoeveelheidBetaald.Location = new System.Drawing.Point(221, 421);
            this.labelHoeveelheidBetaald.Name = "labelHoeveelheidBetaald";
            this.labelHoeveelheidBetaald.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelHoeveelheidBetaald.Size = new System.Drawing.Size(159, 25);
            this.labelHoeveelheidBetaald.TabIndex = 7;
            this.labelHoeveelheidBetaald.Text = "€  0.00\r\n";
            this.labelHoeveelheidBetaald.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAmountTitle2
            // 
            this.lblAmountTitle2.AutoSize = true;
            this.lblAmountTitle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAmountTitle2.Location = new System.Drawing.Point(25, 425);
            this.lblAmountTitle2.Name = "lblAmountTitle2";
            this.lblAmountTitle2.Size = new System.Drawing.Size(117, 15);
            this.lblAmountTitle2.TabIndex = 6;
            this.lblAmountTitle2.Text = "Betaald (excl. fooi): ";
            // 
            // labelWisselgeld
            // 
            this.labelWisselgeld.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWisselgeld.Location = new System.Drawing.Point(221, 471);
            this.labelWisselgeld.Name = "labelWisselgeld";
            this.labelWisselgeld.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelWisselgeld.Size = new System.Drawing.Size(159, 25);
            this.labelWisselgeld.TabIndex = 9;
            this.labelWisselgeld.Text = "€  0.00\r\n";
            this.labelWisselgeld.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            // labelFooi
            // 
            this.labelFooi.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFooi.Location = new System.Drawing.Point(221, 496);
            this.labelFooi.Name = "labelFooi";
            this.labelFooi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelFooi.Size = new System.Drawing.Size(159, 25);
            this.labelFooi.TabIndex = 12;
            this.labelFooi.Text = "€  0.00\r\n";
            this.labelFooi.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.Controls.Add(this.labelFooi);
            this.Controls.Add(this.lblTipTitle);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.labelWisselgeld);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelHoeveelheidBetaald);
            this.Controls.Add(this.lblAmountTitle2);
            this.Controls.Add(this.labelHoeveelheidOmTeBetalen);
            this.Controls.Add(this.lblAmountTitle);
            this.Controls.Add(this.btnConfirmSplit);
            this.Controls.Add(this.lblSplitAmount);
            this.Controls.Add(this.inputSplitAmount);
            this.Controls.Add(this.betalingenPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BetalingScherm";
            this.Size = new System.Drawing.Size(407, 631);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel betalingenPanel;
        private TextBox inputSplitAmount;
        private Label lblSplitAmount;
        private Button btnConfirmSplit;
        private Label lblAmountTitle;
        private Label labelHoeveelheidOmTeBetalen;
        private Label labelHoeveelheidBetaald;
        private Label lblAmountTitle2;
        private Label labelWisselgeld;
        private Label label2;
        private Button btnPay;
        private Label lblTipTitle;
        private Label labelFooi;
        private Label lblSplitAmountErrorText;
        private Label lblPaymentErrorText;
    }
}

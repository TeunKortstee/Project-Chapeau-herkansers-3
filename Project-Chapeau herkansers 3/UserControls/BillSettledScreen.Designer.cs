namespace Project_Chapeau_herkansers_3.UserControls
{
    partial class BillSettledScreen
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
            this.lblBillSettled = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.lblTipAmount = new System.Windows.Forms.Label();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.lblOrderPrice = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBillSettled
            // 
            this.lblBillSettled.AutoSize = true;
            this.lblBillSettled.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBillSettled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblBillSettled.Location = new System.Drawing.Point(33, 149);
            this.lblBillSettled.Name = "lblBillSettled";
            this.lblBillSettled.Size = new System.Drawing.Size(347, 32);
            this.lblBillSettled.TabIndex = 0;
            this.lblBillSettled.Text = "THE BILL HAS BEEN SETTLED!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ORDER PRICE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "AMOUNT PAID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "TIP AMOUNT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "VAT:";
            // 
            // lblVat
            // 
            this.lblVat.Location = new System.Drawing.Point(199, 390);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(119, 15);
            this.lblVat.TabIndex = 8;
            this.lblVat.Text = "€ 0";
            this.lblVat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTipAmount
            // 
            this.lblTipAmount.Location = new System.Drawing.Point(199, 343);
            this.lblTipAmount.Name = "lblTipAmount";
            this.lblTipAmount.Size = new System.Drawing.Size(119, 15);
            this.lblTipAmount.TabIndex = 7;
            this.lblTipAmount.Text = "€ 0";
            this.lblTipAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.Location = new System.Drawing.Point(199, 291);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(119, 15);
            this.lblAmountPaid.TabIndex = 6;
            this.lblAmountPaid.Text = "€ 0";
            this.lblAmountPaid.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblOrderPrice
            // 
            this.lblOrderPrice.Location = new System.Drawing.Point(198, 245);
            this.lblOrderPrice.Name = "lblOrderPrice";
            this.lblOrderPrice.Size = new System.Drawing.Size(120, 15);
            this.lblOrderPrice.TabIndex = 5;
            this.lblOrderPrice.Text = "€ 0";
            this.lblOrderPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(156, 496);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 44);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // BillSettledScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblVat);
            this.Controls.Add(this.lblTipAmount);
            this.Controls.Add(this.lblAmountPaid);
            this.Controls.Add(this.lblOrderPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBillSettled);
            this.Name = "BillSettledScreen";
            this.Size = new System.Drawing.Size(407, 631);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblBillSettled;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblVat;
        private Label lblTipAmount;
        private Label lblAmountPaid;
        private Label lblOrderPrice;
        private Button btnBack;
    }
}

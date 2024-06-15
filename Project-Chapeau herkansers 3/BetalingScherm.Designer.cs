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
            // 
            // lblSplitAmount
            // 
            this.lblSplitAmount.AutoSize = true;
            this.lblSplitAmount.Location = new System.Drawing.Point(21, 43);
            this.lblSplitAmount.Name = "lblSplitAmount";
            this.lblSplitAmount.Size = new System.Drawing.Size(167, 15);
            this.lblSplitAmount.TabIndex = 2;
            this.lblSplitAmount.Text = "How many people are paying?";
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
            this.lblAmountTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAmountTitle.Location = new System.Drawing.Point(25, 450);
            this.lblAmountTitle.Name = "lblAmountTitle";
            this.lblAmountTitle.Size = new System.Drawing.Size(190, 25);
            this.lblAmountTitle.TabIndex = 4;
            this.lblAmountTitle.Text = "Amount to be paid: ";
            // 
            // lblAmountToBePaid
            // 
            this.lblAmountToBePaid.AutoSize = true;
            this.lblAmountToBePaid.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAmountToBePaid.Location = new System.Drawing.Point(309, 450);
            this.lblAmountToBePaid.Name = "lblAmountToBePaid";
            this.lblAmountToBePaid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAmountToBePaid.Size = new System.Drawing.Size(71, 25);
            this.lblAmountToBePaid.TabIndex = 5;
            this.lblAmountToBePaid.Text = "€  0.00\r\n";
            this.lblAmountToBePaid.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.AutoSize = true;
            this.lblAmountPaid.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAmountPaid.Location = new System.Drawing.Point(309, 425);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAmountPaid.Size = new System.Drawing.Size(71, 25);
            this.lblAmountPaid.TabIndex = 7;
            this.lblAmountPaid.Text = "€  0.00\r\n";
            this.lblAmountPaid.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAmountTitle2
            // 
            this.lblAmountTitle2.AutoSize = true;
            this.lblAmountTitle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAmountTitle2.Location = new System.Drawing.Point(25, 425);
            this.lblAmountTitle2.Name = "lblAmountTitle2";
            this.lblAmountTitle2.Size = new System.Drawing.Size(139, 25);
            this.lblAmountTitle2.TabIndex = 6;
            this.lblAmountTitle2.Text = "Amount paid: ";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChange.Location = new System.Drawing.Point(309, 475);
            this.lblChange.Name = "lblChange";
            this.lblChange.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblChange.Size = new System.Drawing.Size(71, 25);
            this.lblChange.TabIndex = 9;
            this.lblChange.Text = "€  0.00\r\n";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Change: ";
            // 
            // BetalingScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
    }
}

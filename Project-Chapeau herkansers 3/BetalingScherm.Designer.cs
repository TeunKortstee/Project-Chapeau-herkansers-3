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
            this.SuspendLayout();
            // 
            // payementsPanel
            // 
            this.payementsPanel.Location = new System.Drawing.Point(25, 114);
            this.payementsPanel.Name = "payementsPanel";
            this.payementsPanel.Size = new System.Drawing.Size(358, 371);
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
            // 
            // BetalingScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnConfirmSplit);
            this.Controls.Add(this.lblSplitAmount);
            this.Controls.Add(this.inputSplitAmount);
            this.Controls.Add(this.payementsPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BetalingScherm";
            this.Size = new System.Drawing.Size(407, 519);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel payementsPanel;
        private TextBox inputSplitAmount;
        private Label lblSplitAmount;
        private Button btnConfirmSplit;
    }
}

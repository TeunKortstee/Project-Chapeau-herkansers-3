﻿namespace Project_Chapeau_herkansers_3.UserControls
{
    partial class UserControlInkomen
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
            lsvPaidBills = new ListView();
            lblSales = new Label();
            btnReturn = new Button();
            lblTotalIncome = new Label();
            btnBar = new Button();
            btnKeuken = new Button();
            SuspendLayout();
            // 
            // lsvPaidBills
            // 
            lsvPaidBills.FullRowSelect = true;
            lsvPaidBills.Location = new Point(14, 251);
            lsvPaidBills.Margin = new Padding(3, 4, 3, 4);
            lsvPaidBills.MultiSelect = false;
            lsvPaidBills.Name = "lsvPaidBills";
            lsvPaidBills.Size = new Size(380, 380);
            lsvPaidBills.TabIndex = 0;
            lsvPaidBills.UseCompatibleStateImageBehavior = false;
            lsvPaidBills.View = View.Details;
            // 
            // lblSales
            // 
            lblSales.AutoSize = true;
            lblSales.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblSales.Location = new Point(118, 14);
            lblSales.Name = "lblSales";
            lblSales.Size = new Size(162, 46);
            lblSales.TabIndex = 1;
            lblSales.Text = "Inkomen";
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.FromArgb(255, 179, 71);
            btnReturn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.Location = new Point(326, 20);
            btnReturn.Margin = new Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(68, 48);
            btnReturn.TabIndex = 28;
            btnReturn.Text = "Terug";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.AutoSize = true;
            lblTotalIncome.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalIncome.Location = new Point(14, 108);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new Size(134, 38);
            lblTotalIncome.TabIndex = 32;
            lblTotalIncome.Text = "Inkomen";
            // 
            // btnBar
            // 
            btnBar.BackColor = Color.FromArgb(138, 210, 176);
            btnBar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBar.Location = new Point(204, 194);
            btnBar.Name = "btnBar";
            btnBar.Size = new Size(190, 50);
            btnBar.TabIndex = 49;
            btnBar.Text = "Bar";
            btnBar.UseVisualStyleBackColor = false;
            btnBar.Click += btnBar_Click;
            // 
            // btnKeuken
            // 
            btnKeuken.BackColor = Color.FromArgb(138, 210, 176);
            btnKeuken.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKeuken.Location = new Point(14, 194);
            btnKeuken.Name = "btnKeuken";
            btnKeuken.Size = new Size(190, 50);
            btnKeuken.TabIndex = 48;
            btnKeuken.Text = "Keuken";
            btnKeuken.UseVisualStyleBackColor = false;
            btnKeuken.Click += btnKeuken_Click;
            // 
            // UserControlInkomen
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnBar);
            Controls.Add(btnKeuken);
            Controls.Add(lblTotalIncome);
            Controls.Add(btnReturn);
            Controls.Add(lblSales);
            Controls.Add(lsvPaidBills);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlInkomen";
            Size = new Size(414, 736);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lsvPaidBills;
        private Label lblSales;
        private Button btnReturn;
        private Label lblTotalIncome;
        private Button btnBar;
        private Button btnKeuken;
    }
}

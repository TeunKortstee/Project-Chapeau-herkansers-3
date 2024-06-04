namespace Project_Chapeau_herkansers_3.UserControls
{
    partial class UserControlSalesOverview
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
            lsvDatabaseItems = new ListView();
            lblOverview = new Label();
            btnReturn = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            lblTotalIncome = new Label();
            SuspendLayout();
            // 
            // lsvDatabaseItems
            // 
            lsvDatabaseItems.FullRowSelect = true;
            lsvDatabaseItems.Location = new Point(14, 251);
            lsvDatabaseItems.Margin = new Padding(3, 4, 3, 4);
            lsvDatabaseItems.MultiSelect = false;
            lsvDatabaseItems.Name = "lsvDatabaseItems";
            lsvDatabaseItems.Size = new Size(380, 380);
            lsvDatabaseItems.TabIndex = 0;
            lsvDatabaseItems.UseCompatibleStateImageBehavior = false;
            lsvDatabaseItems.View = View.Details;
            // 
            // lblOverview
            // 
            lblOverview.AutoSize = true;
            lblOverview.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblOverview.Location = new Point(118, 14);
            lblOverview.Name = "lblOverview";
            lblOverview.Size = new Size(177, 46);
            lblOverview.TabIndex = 1;
            lblOverview.Text = "Inkomens";
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
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(138, 210, 176);
            btn1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(14, 638);
            btn1.Name = "btn1";
            btn1.Size = new Size(123, 50);
            btn1.TabIndex = 29;
            btn1.Text = "Optie 1";
            btn1.UseVisualStyleBackColor = false;
            btn1.EnabledChanged += btn1_EnabledChanged;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(138, 210, 176);
            btn2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(143, 638);
            btn2.Name = "btn2";
            btn2.Size = new Size(123, 50);
            btn2.TabIndex = 30;
            btn2.Text = "Optie 2";
            btn2.UseVisualStyleBackColor = false;
            btn2.EnabledChanged += btn2_EnabledChanged;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(138, 210, 176);
            btn3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(271, 638);
            btn3.Name = "btn3";
            btn3.Size = new Size(123, 50);
            btn3.TabIndex = 31;
            btn3.Text = "Optie 3";
            btn3.UseVisualStyleBackColor = false;
            btn3.EnabledChanged += btn3_EnabledChanged;
            btn3.Click += btn3_Click;
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.AutoSize = true;
            lblTotalIncome.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalIncome.Location = new Point(14, 108);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new Size(126, 46);
            lblTotalIncome.TabIndex = 32;
            lblTotalIncome.Text = "Totaal:";
            // 
            // UserControlSalesOverview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTotalIncome);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnReturn);
            Controls.Add(lblOverview);
            Controls.Add(lsvDatabaseItems);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlSalesOverview";
            Size = new Size(414, 736);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lsvDatabaseItems;
        private Label lblOverview;
        private Button btnReturn;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Label lblTotalIncome;
    }
}

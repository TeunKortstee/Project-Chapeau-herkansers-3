namespace Project_Chapeau_herkansers_3.UserControls
{
    partial class UserControlDashboardManager
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
            btnTableView = new Button();
            btnEmployee = new Button();
            btnMenu = new Button();
            txtManager = new TextBox();
            SuspendLayout();
            // 
            // btnTableView
            // 
            btnTableView.BackColor = Color.FromArgb(138, 210, 176);
            btnTableView.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnTableView.Location = new Point(51, 189);
            btnTableView.Margin = new Padding(3, 2, 3, 2);
            btnTableView.Name = "btnTableView";
            btnTableView.Size = new Size(256, 50);
            btnTableView.TabIndex = 0;
            btnTableView.Text = "Tafeloverzicht";
            btnTableView.UseVisualStyleBackColor = false;
            btnTableView.Click += btnTableView_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.FromArgb(138, 210, 176);
            btnEmployee.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmployee.Location = new Point(51, 274);
            btnEmployee.Margin = new Padding(3, 2, 3, 2);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(256, 50);
            btnEmployee.TabIndex = 3;
            btnEmployee.Text = "Personeel Management";
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(138, 210, 176);
            btnMenu.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.Location = new Point(51, 367);
            btnMenu.Margin = new Padding(3, 2, 3, 2);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(256, 50);
            btnMenu.TabIndex = 4;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // txtManager
            // 
            txtManager.BackColor = Color.FromArgb(255, 179, 71);
            txtManager.Enabled = false;
            txtManager.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtManager.Location = new Point(244, 16);
            txtManager.Name = "txtManager";
            txtManager.Size = new Size(91, 35);
            txtManager.TabIndex = 5;
            txtManager.Text = "Manager";
            // 
            // UserControlDashboardManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtManager);
            Controls.Add(btnMenu);
            Controls.Add(btnEmployee);
            Controls.Add(btnTableView);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserControlDashboardManager";
            Size = new Size(362, 552);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTableView;
        private Button btnEmployee;
        private Button btnMenu;
        private TextBox txtManager;
    }

}
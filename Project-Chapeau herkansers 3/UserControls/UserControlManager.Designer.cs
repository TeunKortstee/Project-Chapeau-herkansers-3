namespace Project_Chapeau_herkansers_3.UserControls
{
    partial class UserControlManager
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
            btnTableView.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnTableView.Location = new Point(47, 224);
            btnTableView.Name = "btnTableView";
            btnTableView.Size = new Size(335, 67);
            btnTableView.TabIndex = 0;
            btnTableView.Text = "Tafeloverzicht";
            btnTableView.UseVisualStyleBackColor = false;
            btnTableView.Click += btnTableView_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.FromArgb(138, 210, 176);
            btnEmployee.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployee.Location = new Point(47, 340);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(335, 67);
            btnEmployee.TabIndex = 3;
            btnEmployee.Text = "Personeel Management";
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(138, 210, 176);
            btnMenu.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenu.Location = new Point(47, 461);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(335, 67);
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
            txtManager.Location = new Point(279, 21);
            txtManager.Margin = new Padding(3, 4, 3, 4);
            txtManager.Name = "txtManager";
            txtManager.Size = new Size(103, 42);
            txtManager.TabIndex = 5;
            txtManager.Text = "Manager";
            // 
            // UserControlDashboardManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtManager);
            Controls.Add(btnMenu);
            Controls.Add(btnEmployee);
            Controls.Add(btnTableView);
            Name = "UserControlDashboardManager";
            Size = new Size(414, 736);
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
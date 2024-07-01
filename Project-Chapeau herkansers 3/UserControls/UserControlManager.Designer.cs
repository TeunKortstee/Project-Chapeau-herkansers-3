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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlManager));
            btnEmployee = new Button();
            btnMenu = new Button();
            btnSales = new Button();
            pictureBox1 = new PictureBox();
            btnStock = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.FromArgb(138, 210, 176);
            btnEmployee.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployee.Location = new Point(41, 378);
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
            btnMenu.Location = new Point(41, 499);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(335, 67);
            btnMenu.TabIndex = 4;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnSales
            // 
            btnSales.BackColor = Color.FromArgb(138, 210, 176);
            btnSales.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSales.Location = new Point(41, 257);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(335, 67);
            btnSales.TabIndex = 6;
            btnSales.Text = "Inkomens";
            btnSales.UseVisualStyleBackColor = false;
            btnSales.Click += btnSales_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(56, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 171);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnStock
            // 
            btnStock.BackColor = Color.FromArgb(138, 210, 176);
            btnStock.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnStock.Location = new Point(41, 620);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(335, 67);
            btnStock.TabIndex = 8;
            btnStock.Text = "Voorraad";
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += btnStock_Click;
            // 
            // UserControlManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnStock);
            Controls.Add(pictureBox1);
            Controls.Add(btnSales);
            Controls.Add(btnMenu);
            Controls.Add(btnEmployee);
            Name = "UserControlManager";
            Size = new Size(414, 736);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnEmployee;
        private Button btnMenu;
        private Button btnSales;
        private PictureBox pictureBox1;
        private Button btnStock;
    }

}
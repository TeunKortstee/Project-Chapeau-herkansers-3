namespace Project_Chapeau_herkansers_3.UserControls
{
    partial class UserControlVoorraadEdit
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
            lblStock = new Label();
            btnConfirm = new Button();
            picName = new PictureBox();
            txtStock = new TextBox();
            btnAdd = new Button();
            btnSubtract = new Button();
            lblNewStock = new Label();
            btnCancel = new Button();
            lblAdjustItem = new Label();
            lblErrorVoorraad = new Label();
            ((System.ComponentModel.ISupportInitialize)picName).BeginInit();
            SuspendLayout();
            // 
            // lblStock
            // 
            lblStock.AutoEllipsis = true;
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblStock.Location = new Point(27, 170);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(168, 46);
            lblStock.TabIndex = 1;
            lblStock.Text = "Voorraad";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(138, 210, 176);
            btnConfirm.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirm.Location = new Point(30, 653);
            btnConfirm.Margin = new Padding(3, 4, 3, 4);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(111, 52);
            btnConfirm.TabIndex = 3;
            btnConfirm.Text = "Bevestig";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // picName
            // 
            picName.BackColor = Color.FromArgb(196, 196, 196);
            picName.Location = new Point(27, 226);
            picName.Name = "picName";
            picName.Size = new Size(285, 62);
            picName.TabIndex = 6;
            picName.TabStop = false;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(238, 244);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(31, 27);
            txtStock.TabIndex = 10;
            txtStock.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(275, 244);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(24, 29);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubtract.Location = new Point(208, 244);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(24, 29);
            btnSubtract.TabIndex = 12;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // lblNewStock
            // 
            lblNewStock.AutoSize = true;
            lblNewStock.BackColor = Color.FromArgb(196, 196, 196);
            lblNewStock.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNewStock.Location = new Point(43, 246);
            lblNewStock.Name = "lblNewStock";
            lblNewStock.Size = new Size(112, 25);
            lblNewStock.TabIndex = 13;
            lblNewStock.Text = "In Voorraad";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(245, 108, 117);
            btnCancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(147, 653);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(111, 52);
            btnCancel.TabIndex = 30;
            btnCancel.Text = "Annuleer";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblAdjustItem
            // 
            lblAdjustItem.AutoSize = true;
            lblAdjustItem.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdjustItem.Location = new Point(64, 14);
            lblAdjustItem.Name = "lblAdjustItem";
            lblAdjustItem.Size = new Size(286, 46);
            lblAdjustItem.TabIndex = 31;
            lblAdjustItem.Text = "Aanpassing Item";
            // 
            // lblErrorVoorraad
            // 
            lblErrorVoorraad.AutoSize = true;
            lblErrorVoorraad.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrorVoorraad.ForeColor = Color.Red;
            lblErrorVoorraad.Location = new Point(27, 300);
            lblErrorVoorraad.Name = "lblErrorVoorraad";
            lblErrorVoorraad.Size = new Size(120, 25);
            lblErrorVoorraad.TabIndex = 37;
            lblErrorVoorraad.Text = "Error Bericht";
            lblErrorVoorraad.Visible = false;
            // 
            // UserControlVoorraadEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblErrorVoorraad);
            Controls.Add(lblAdjustItem);
            Controls.Add(btnCancel);
            Controls.Add(lblNewStock);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(txtStock);
            Controls.Add(picName);
            Controls.Add(btnConfirm);
            Controls.Add(lblStock);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlVoorraadEdit";
            Size = new Size(414, 736);
            ((System.ComponentModel.ISupportInitialize)picName).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblStock;
        private Button btnConfirm;
        private PictureBox pictureBox1;
        private PictureBox picName;
        private PictureBox pictureBox5;
        private TextBox txtStock;
        private Button btnAdd;
        private Button btnSubtract;
        private Label lblNewStock;
        private Button btnCancel;
        private Label lblAdjustItem;
        private Label lblErrorVoorraad;
    }
}

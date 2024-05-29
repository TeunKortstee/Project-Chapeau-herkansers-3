namespace Project_Chapeau_herkansers_3.UserControls
{
    partial class UserControlAddNewMenuItem
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
            lblMenuItem = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            picName = new PictureBox();
            textBox1 = new TextBox();
            btnAdd = new Button();
            btnSubtract = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picName).BeginInit();
            SuspendLayout();
            // 
            // lblMenuItem
            // 
            lblMenuItem.AutoSize = true;
            lblMenuItem.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblMenuItem.Location = new Point(28, 187);
            lblMenuItem.Name = "lblMenuItem";
            lblMenuItem.Size = new Size(168, 46);
            lblMenuItem.TabIndex = 1;
            lblMenuItem.Text = "Voorraad";
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
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(245, 108, 117);
            btnCancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(147, 653);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(111, 52);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Annuleer";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // picName
            // 
            picName.BackColor = Color.FromArgb(196, 196, 196);
            picName.Location = new Point(46, 271);
            picName.Name = "picName";
            picName.Size = new Size(285, 62);
            picName.TabIndex = 6;
            picName.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(261, 292);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(31, 27);
            textBox1.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(298, 292);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(24, 29);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSubtract
            // 
            btnSubtract.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubtract.Location = new Point(231, 292);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(24, 29);
            btnSubtract.TabIndex = 12;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(196, 196, 196);
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(65, 292);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 13;
            label1.Text = "Name";
            // 
            // UserControlAddNewMenuItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(textBox1);
            Controls.Add(picName);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(lblMenuItem);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlAddNewMenuItem";
            Size = new Size(414, 736);
            ((System.ComponentModel.ISupportInitialize)picName).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblMenuItem;
        private Button btnConfirm;
        private Button btnCancel;
        private PictureBox pictureBox1;
        private PictureBox picName;
        private PictureBox pictureBox5;
        private TextBox textBox1;
        private Button btnAdd;
        private Button btnSubtract;
        private Label label1;
    }
}

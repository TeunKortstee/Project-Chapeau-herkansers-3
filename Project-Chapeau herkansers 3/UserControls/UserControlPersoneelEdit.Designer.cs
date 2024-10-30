namespace Project_Chapeau_herkansers_3.UserControls
{
    partial class UserControlPersoneelEdit
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
            lblObject = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            field2 = new PictureBox();
            txt2 = new TextBox();
            lbl2 = new Label();
            lblEnum = new Label();
            field3 = new PictureBox();
            lbl1 = new Label();
            txt1 = new TextBox();
            field1 = new PictureBox();
            cmbType = new ComboBox();
            lblErrorNewObject = new Label();
            ((System.ComponentModel.ISupportInitialize)field2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)field3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)field1).BeginInit();
            SuspendLayout();
            // 
            // lblObject
            // 
            lblObject.AutoSize = true;
            lblObject.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblObject.Location = new Point(27, 170);
            lblObject.Name = "lblObject";
            lblObject.Size = new Size(132, 46);
            lblObject.TabIndex = 1;
            lblObject.Text = "Nieuw ";
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
            btnCancel.Click += btnCancel_Click;
            // 
            // field2
            // 
            field2.BackColor = Color.FromArgb(196, 196, 196);
            field2.Location = new Point(30, 295);
            field2.Name = "field2";
            field2.Size = new Size(352, 62);
            field2.TabIndex = 6;
            field2.TabStop = false;
            // 
            // txt2
            // 
            txt2.Location = new Point(177, 312);
            txt2.Name = "txt2";
            txt2.Size = new Size(187, 27);
            txt2.TabIndex = 10;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.BackColor = Color.FromArgb(196, 196, 196);
            lbl2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl2.Location = new Point(49, 314);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(58, 25);
            lbl2.TabIndex = 13;
            lbl2.Text = "Email";
            // 
            // lblEnum
            // 
            lblEnum.AutoSize = true;
            lblEnum.BackColor = Color.FromArgb(196, 196, 196);
            lblEnum.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblEnum.Location = new Point(49, 378);
            lblEnum.Name = "lblEnum";
            lblEnum.Size = new Size(74, 25);
            lblEnum.TabIndex = 30;
            lblEnum.Text = "Functie";
            // 
            // field3
            // 
            field3.BackColor = Color.FromArgb(196, 196, 196);
            field3.Location = new Point(30, 359);
            field3.Name = "field3";
            field3.Size = new Size(352, 62);
            field3.TabIndex = 28;
            field3.TabStop = false;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.FromArgb(196, 196, 196);
            lbl1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.Location = new Point(49, 246);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(116, 25);
            lbl1.TabIndex = 34;
            lbl1.Text = "Achternaam";
            // 
            // txt1
            // 
            txt1.Location = new Point(177, 244);
            txt1.Name = "txt1";
            txt1.Size = new Size(187, 27);
            txt1.TabIndex = 33;
            // 
            // field1
            // 
            field1.BackColor = Color.Silver;
            field1.Location = new Point(30, 227);
            field1.Name = "field1";
            field1.Size = new Size(352, 62);
            field1.TabIndex = 32;
            field1.TabStop = false;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(177, 379);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(187, 28);
            cmbType.TabIndex = 35;
            // 
            // lblErrorNewObject
            // 
            lblErrorNewObject.AutoSize = true;
            lblErrorNewObject.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrorNewObject.ForeColor = Color.Red;
            lblErrorNewObject.Location = new Point(30, 424);
            lblErrorNewObject.Name = "lblErrorNewObject";
            lblErrorNewObject.Size = new Size(120, 25);
            lblErrorNewObject.TabIndex = 36;
            lblErrorNewObject.Text = "Error Bericht";
            lblErrorNewObject.Visible = false;
            // 
            // UserControlPersoneelEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblErrorNewObject);
            Controls.Add(cmbType);
            Controls.Add(lbl1);
            Controls.Add(txt1);
            Controls.Add(field1);
            Controls.Add(lblEnum);
            Controls.Add(field3);
            Controls.Add(lbl2);
            Controls.Add(txt2);
            Controls.Add(field2);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(lblObject);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlPersoneelEdit";
            Size = new Size(414, 736);
            ((System.ComponentModel.ISupportInitialize)field2).EndInit();
            ((System.ComponentModel.ISupportInitialize)field3).EndInit();
            ((System.ComponentModel.ISupportInitialize)field1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblObject;
        private Button btnConfirm;
        private Button btnCancel;
        private PictureBox field2;
        private PictureBox pictureBox5;
        private TextBox txt2;
        private Label lbl2;
        private Label lblEnum;
        private PictureBox field3;
        private Label lbl1;
        private TextBox txt1;
        private PictureBox field1;
        private ComboBox cmbType;
        private Label lblErrorNewObject;
    }
}

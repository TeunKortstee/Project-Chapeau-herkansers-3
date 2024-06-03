namespace Project_Chapeau_herkansers_3.UserControls
{
    partial class UserControlNewObject
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
            picName = new PictureBox();
            txt1 = new TextBox();
            lbl1 = new Label();
            pictureBox1 = new PictureBox();
            lbl2 = new Label();
            txt2 = new TextBox();
            chkAlcoholisch = new CheckBox();
            cmbType = new ComboBox();
            lblType = new Label();
            lbl3 = new Label();
            txt3 = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            btnConfirm.Click += btnConfirm_Click;
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
            // picName
            // 
            picName.BackColor = Color.FromArgb(196, 196, 196);
            picName.Location = new Point(30, 295);
            picName.Name = "picName";
            picName.Size = new Size(285, 62);
            picName.TabIndex = 6;
            picName.TabStop = false;
            // 
            // txt1
            // 
            txt1.Location = new Point(177, 314);
            txt1.Name = "txt1";
            txt1.Size = new Size(121, 27);
            txt1.TabIndex = 10;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.FromArgb(196, 196, 196);
            lbl1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.Location = new Point(49, 314);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(59, 25);
            lbl1.TabIndex = 13;
            lbl1.Text = "Veld1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(196, 196, 196);
            pictureBox1.Location = new Point(30, 363);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 62);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.BackColor = Color.FromArgb(196, 196, 196);
            lbl2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl2.Location = new Point(49, 382);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(59, 25);
            lbl2.TabIndex = 17;
            lbl2.Text = "Veld2";
            // 
            // txt2
            // 
            txt2.Location = new Point(177, 382);
            txt2.Name = "txt2";
            txt2.Size = new Size(121, 27);
            txt2.TabIndex = 16;
            // 
            // chkAlcoholisch
            // 
            chkAlcoholisch.AutoSize = true;
            chkAlcoholisch.Location = new Point(27, 499);
            chkAlcoholisch.Name = "chkAlcoholisch";
            chkAlcoholisch.Size = new Size(107, 24);
            chkAlcoholisch.TabIndex = 21;
            chkAlcoholisch.Text = "Alcoholisch";
            chkAlcoholisch.UseVisualStyleBackColor = true;
            chkAlcoholisch.Visible = false;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(30, 261);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(151, 28);
            cmbType.TabIndex = 26;
            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.BackColor = SystemColors.Control;
            lblType.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblType.Location = new Point(30, 233);
            lblType.Name = "lblType";
            lblType.Size = new Size(60, 25);
            lblType.TabIndex = 27;
            lblType.Text = "Enum";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.BackColor = Color.FromArgb(196, 196, 196);
            lbl3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl3.Location = new Point(49, 450);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(59, 25);
            lbl3.TabIndex = 30;
            lbl3.Text = "Veld3";
            // 
            // txt3
            // 
            txt3.Location = new Point(177, 450);
            txt3.Name = "txt3";
            txt3.Size = new Size(121, 27);
            txt3.TabIndex = 29;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(196, 196, 196);
            pictureBox2.Location = new Point(30, 431);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(285, 62);
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // UserControlNewObject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl3);
            Controls.Add(txt3);
            Controls.Add(pictureBox2);
            Controls.Add(lblType);
            Controls.Add(cmbType);
            Controls.Add(chkAlcoholisch);
            Controls.Add(lbl2);
            Controls.Add(txt2);
            Controls.Add(pictureBox1);
            Controls.Add(lbl1);
            Controls.Add(txt1);
            Controls.Add(picName);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(lblObject);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlNewObject";
            Size = new Size(414, 736);
            ((System.ComponentModel.ISupportInitialize)picName).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblObject;
        private Button btnConfirm;
        private Button btnCancel;
        private PictureBox pictureBox1;
        private PictureBox picName;
        private PictureBox pictureBox5;
        private TextBox txt1;
        private Label lbl1;
        private Label lbl2;
        private TextBox txt2;
        private CheckBox chkAlcoholisch;
        private ComboBox cmbType;
        private Label lblType;
        private Label lbl3;
        private TextBox txt3;
        private PictureBox pictureBox2;
    }
}

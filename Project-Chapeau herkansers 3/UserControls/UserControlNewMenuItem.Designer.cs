namespace Project_Chapeau_herkansers_3.UserControls
{
    partial class UserControlNewMenuItem
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
            txtNaam = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtPrijs = new TextBox();
            chkAlcoholisch = new CheckBox();
            cmbMenuType = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)picName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblMenuItem
            // 
            lblMenuItem.AutoSize = true;
            lblMenuItem.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblMenuItem.Location = new Point(27, 170);
            lblMenuItem.Name = "lblMenuItem";
            lblMenuItem.Size = new Size(298, 46);
            lblMenuItem.TabIndex = 1;
            lblMenuItem.Text = "Nieuw MenuItem";
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
            picName.Location = new Point(30, 295);
            picName.Name = "picName";
            picName.Size = new Size(285, 62);
            picName.TabIndex = 6;
            picName.TabStop = false;
            // 
            // txtNaam
            // 
            txtNaam.Location = new Point(177, 314);
            txtNaam.Name = "txtNaam";
            txtNaam.Size = new Size(121, 27);
            txtNaam.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(196, 196, 196);
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(49, 314);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 13;
            label1.Text = "Naam";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(196, 196, 196);
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(49, 382);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 17;
            label2.Text = "Prijs";
            // 
            // txtPrijs
            // 
            txtPrijs.Location = new Point(177, 382);
            txtPrijs.Name = "txtPrijs";
            txtPrijs.Size = new Size(121, 27);
            txtPrijs.TabIndex = 16;
            // 
            // chkAlcoholisch
            // 
            chkAlcoholisch.AutoSize = true;
            chkAlcoholisch.Location = new Point(30, 431);
            chkAlcoholisch.Name = "chkAlcoholisch";
            chkAlcoholisch.Size = new Size(107, 24);
            chkAlcoholisch.TabIndex = 21;
            chkAlcoholisch.Text = "Alcoholisch";
            chkAlcoholisch.UseVisualStyleBackColor = true;
            chkAlcoholisch.Visible = false;
            // 
            // cmbMenuType
            // 
            cmbMenuType.FormattingEnabled = true;
            cmbMenuType.Location = new Point(30, 261);
            cmbMenuType.Name = "cmbMenuType";
            cmbMenuType.Size = new Size(151, 28);
            cmbMenuType.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(30, 233);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 27;
            label3.Text = "Menu";
            // 
            // UserControlAddNewMenuItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(cmbMenuType);
            Controls.Add(chkAlcoholisch);
            Controls.Add(label2);
            Controls.Add(txtPrijs);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtNaam);
            Controls.Add(picName);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(lblMenuItem);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlAddNewMenuItem";
            Size = new Size(414, 736);
            ((System.ComponentModel.ISupportInitialize)picName).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private TextBox txtNaam;
        private Label label1;
        private Label label2;
        private TextBox txtPrijs;
        private CheckBox chkAlcoholisch;
        private ComboBox cmbMenuType;
        private Label label3;
    }
}

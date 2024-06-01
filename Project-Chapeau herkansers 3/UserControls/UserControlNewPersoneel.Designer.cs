namespace Project_Chapeau_herkansers_3.UserControls
{
    partial class UserControlNewPersoneel
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
            lblPersoneel = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            label1 = new Label();
            txtNaam = new TextBox();
            picName = new PictureBox();
            label2 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            textBox2 = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblPersoneel
            // 
            lblPersoneel.AutoSize = true;
            lblPersoneel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblPersoneel.Location = new Point(27, 170);
            lblPersoneel.Name = "lblPersoneel";
            lblPersoneel.Size = new Size(287, 46);
            lblPersoneel.TabIndex = 1;
            lblPersoneel.Text = "Nieuw Personeel";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(196, 196, 196);
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(46, 256);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 20;
            label1.Text = "Voornaam";
            // 
            // txtNaam
            // 
            txtNaam.Location = new Point(174, 254);
            txtNaam.Name = "txtNaam";
            txtNaam.Size = new Size(121, 27);
            txtNaam.TabIndex = 19;
            // 
            // picName
            // 
            picName.BackColor = Color.FromArgb(196, 196, 196);
            picName.Location = new Point(27, 235);
            picName.Name = "picName";
            picName.Size = new Size(285, 62);
            picName.TabIndex = 18;
            picName.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(196, 196, 196);
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(46, 324);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 23;
            label2.Text = "Achternaam";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 322);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 27);
            textBox1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(196, 196, 196);
            pictureBox1.Location = new Point(27, 303);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 62);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(196, 196, 196);
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(46, 392);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 26;
            label3.Text = "Email";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(174, 390);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 27);
            textBox2.TabIndex = 25;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(196, 196, 196);
            pictureBox2.Location = new Point(27, 371);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(285, 62);
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // UserControlAddNewPersoneel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtNaam);
            Controls.Add(picName);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(lblPersoneel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlAddNewPersoneel";
            Size = new Size(414, 736);
            ((System.ComponentModel.ISupportInitialize)picName).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPersoneel;
        private Button btnConfirm;
        private Button btnCancel;
        private PictureBox pictureBox5;
        private Label label1;
        private TextBox txtNaam;
        private PictureBox picName;
        private Label label2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox textBox2;
        private PictureBox pictureBox2;
    }
}

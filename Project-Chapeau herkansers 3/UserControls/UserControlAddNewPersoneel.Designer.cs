namespace Project_Chapeau_herkansers_3.UserControls
{
    partial class UserControlAddNewPersoneel
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
            picName = new PictureBox();
            picDropdown = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDropdown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // lblPersoneel
            // 
            lblPersoneel.AutoSize = true;
            lblPersoneel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblPersoneel.Location = new Point(28, 187);
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
            // picName
            // 
            picName.BackColor = Color.FromArgb(196, 196, 196);
            picName.Location = new Point(46, 271);
            picName.Name = "picName";
            picName.Size = new Size(285, 62);
            picName.TabIndex = 6;
            picName.TabStop = false;
            // 
            // picDropdown
            // 
            picDropdown.BackColor = Color.FromArgb(196, 196, 196);
            picDropdown.Location = new Point(46, 339);
            picDropdown.Name = "picDropdown";
            picDropdown.Size = new Size(285, 62);
            picDropdown.TabIndex = 7;
            picDropdown.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(196, 196, 196);
            pictureBox3.Location = new Point(46, 407);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(285, 62);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(196, 196, 196);
            pictureBox4.Location = new Point(46, 475);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(285, 62);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // UserControlAddNew
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(picDropdown);
            Controls.Add(picName);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(lblPersoneel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlAddNew";
            Size = new Size(414, 736);
            ((System.ComponentModel.ISupportInitialize)picName).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDropdown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPersoneel;
        private Button btnConfirm;
        private Button btnCancel;
        private PictureBox pictureBox1;
        private PictureBox picName;
        private PictureBox picDropdown;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}

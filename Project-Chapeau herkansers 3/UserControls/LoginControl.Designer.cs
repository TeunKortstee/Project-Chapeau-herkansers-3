namespace Project_Chapeau_herkansers_3
{
    partial class LoginControl
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
            EmailTxt = new TextBox();
            PasswordTxt = new TextBox();
            LoginBtn = new Button();
            ErrorLbl = new Label();
            ChangePasswordTxt = new TextBox();
            Changepasswordbtn = new Button();
            ChangePasswordCheck = new CheckBox();
            ChangePasswordErrorlbl = new Label();
            Succeslbl = new Label();
            SuspendLayout();
            // 
            // EmailTxt
            // 
            EmailTxt.Location = new Point(127, 49);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.Size = new Size(150, 31);
            EmailTxt.TabIndex = 0;
            // 
            // PasswordTxt
            // 
            PasswordTxt.Location = new Point(127, 125);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.PasswordChar = '*';
            PasswordTxt.Size = new Size(150, 31);
            PasswordTxt.TabIndex = 1;
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(56, 338);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(112, 34);
            LoginBtn.TabIndex = 3;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // ErrorLbl
            // 
            ErrorLbl.AutoSize = true;
            ErrorLbl.ForeColor = Color.Red;
            ErrorLbl.Location = new Point(127, 159);
            ErrorLbl.Name = "ErrorLbl";
            ErrorLbl.Size = new Size(0, 25);
            ErrorLbl.TabIndex = 4;
            // 
            // ChangePasswordTxt
            // 
            ChangePasswordTxt.Location = new Point(127, 198);
            ChangePasswordTxt.Name = "ChangePasswordTxt";
            ChangePasswordTxt.PasswordChar = '*';
            ChangePasswordTxt.Size = new Size(150, 31);
            ChangePasswordTxt.TabIndex = 5;
            // 
            // Changepasswordbtn
            // 
            Changepasswordbtn.Location = new Point(214, 338);
            Changepasswordbtn.Name = "Changepasswordbtn";
            Changepasswordbtn.Size = new Size(168, 34);
            Changepasswordbtn.TabIndex = 6;
            Changepasswordbtn.Text = "Change password";
            Changepasswordbtn.UseVisualStyleBackColor = true;
            Changepasswordbtn.Click += Changepasswordbtn_Click;
            // 
            // ChangePasswordCheck
            // 
            ChangePasswordCheck.AutoSize = true;
            ChangePasswordCheck.Location = new Point(56, 288);
            ChangePasswordCheck.Name = "ChangePasswordCheck";
            ChangePasswordCheck.Size = new Size(186, 29);
            ChangePasswordCheck.TabIndex = 7;
            ChangePasswordCheck.Text = "Change Password?";
            ChangePasswordCheck.UseVisualStyleBackColor = true;
            ChangePasswordCheck.CheckedChanged += ChangePasswordCheck_CheckedChanged;
            // 
            // ChangePasswordErrorlbl
            // 
            ChangePasswordErrorlbl.AutoSize = true;
            ChangePasswordErrorlbl.ForeColor = Color.Red;
            ChangePasswordErrorlbl.Location = new Point(127, 232);
            ChangePasswordErrorlbl.Name = "ChangePasswordErrorlbl";
            ChangePasswordErrorlbl.Size = new Size(0, 25);
            ChangePasswordErrorlbl.TabIndex = 8;
            // 
            // Succeslbl
            // 
            Succeslbl.AutoSize = true;
            Succeslbl.Location = new Point(129, 235);
            Succeslbl.Name = "Succeslbl";
            Succeslbl.Size = new Size(0, 25);
            Succeslbl.TabIndex = 9;
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Succeslbl);
            Controls.Add(ChangePasswordErrorlbl);
            Controls.Add(ChangePasswordCheck);
            Controls.Add(Changepasswordbtn);
            Controls.Add(ChangePasswordTxt);
            Controls.Add(ErrorLbl);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordTxt);
            Controls.Add(EmailTxt);
            Name = "LoginControl";
            Size = new Size(411, 500);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EmailTxt;
        private TextBox PasswordTxt;
        private Button LoginBtn;
        private Label ErrorLbl;
        private TextBox ChangePasswordTxt;
        private Button Changepasswordbtn;
        private CheckBox ChangePasswordCheck;
        private Label ChangePasswordErrorlbl;
        private Label Succeslbl;
    }
}

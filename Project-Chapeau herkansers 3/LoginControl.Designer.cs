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
            CreateUserCheck = new CheckBox();
            LoginBtn = new Button();
            SuspendLayout();
            // 
            // EmailTxt
            // 
            EmailTxt.Location = new Point(130, 118);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.Size = new Size(150, 31);
            EmailTxt.TabIndex = 0;
            // 
            // PasswordTxt
            // 
            PasswordTxt.Location = new Point(130, 194);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.Size = new Size(150, 31);
            PasswordTxt.TabIndex = 1;
            // 
            // CreateUserCheck
            // 
            CreateUserCheck.AutoSize = true;
            CreateUserCheck.Location = new Point(130, 277);
            CreateUserCheck.Name = "CreateUserCheck";
            CreateUserCheck.Size = new Size(163, 29);
            CreateUserCheck.TabIndex = 2;
            CreateUserCheck.Text = "Create new user";
            CreateUserCheck.UseVisualStyleBackColor = true;
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(139, 343);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(112, 34);
            LoginBtn.TabIndex = 3;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LoginBtn);
            Controls.Add(CreateUserCheck);
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
        private CheckBox CreateUserCheck;
        private Button LoginBtn;
    }
}

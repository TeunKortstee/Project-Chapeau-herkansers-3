namespace Project_Chapeau_herkansers_3
{
    partial class LogoutControl
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
            label1 = new Label();
            AchternaamLbl = new Label();
            label3 = new Label();
            EmailLbl = new Label();
            label5 = new Label();
            FunctieLbl = new Label();
            UitlogBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 64);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 0;
            label1.Text = "Achternaam:";
            // 
            // AchternaamLbl
            // 
            AchternaamLbl.AutoSize = true;
            AchternaamLbl.Location = new Point(56, 89);
            AchternaamLbl.Name = "AchternaamLbl";
            AchternaamLbl.Size = new Size(0, 25);
            AchternaamLbl.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 151);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // EmailLbl
            // 
            EmailLbl.AutoSize = true;
            EmailLbl.Location = new Point(56, 176);
            EmailLbl.Name = "EmailLbl";
            EmailLbl.Size = new Size(0, 25);
            EmailLbl.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 229);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 4;
            label5.Text = "Functie";
            // 
            // FunctieLbl
            // 
            FunctieLbl.AutoSize = true;
            FunctieLbl.Location = new Point(56, 254);
            FunctieLbl.Name = "FunctieLbl";
            FunctieLbl.Size = new Size(0, 25);
            FunctieLbl.TabIndex = 5;
            // 
            // UitlogBtn
            // 
            UitlogBtn.Location = new Point(153, 379);
            UitlogBtn.Name = "UitlogBtn";
            UitlogBtn.Size = new Size(112, 34);
            UitlogBtn.TabIndex = 6;
            UitlogBtn.Text = "Log uit";
            UitlogBtn.UseVisualStyleBackColor = true;
            UitlogBtn.Click += UitlogBtn_Click;
            // 
            // LogoutControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(UitlogBtn);
            Controls.Add(FunctieLbl);
            Controls.Add(label5);
            Controls.Add(EmailLbl);
            Controls.Add(label3);
            Controls.Add(AchternaamLbl);
            Controls.Add(label1);
            Name = "LogoutControl";
            Size = new Size(411, 500);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label AchternaamLbl;
        private Label label3;
        private Label EmailLbl;
        private Label label5;
        private Label FunctieLbl;
        private Button UitlogBtn;
    }
}

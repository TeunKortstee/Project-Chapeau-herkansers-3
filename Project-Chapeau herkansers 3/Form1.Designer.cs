namespace Project_Chapeau_herkansers_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainPanel = new Panel();
            GebruikerBtn = new Button();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.AutoScroll = true;
            mainPanel.Location = new Point(1, 75);
            mainPanel.Margin = new Padding(5, 4, 5, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(646, 1585);
            mainPanel.TabIndex = 0;
            // 
            // GebruikerBtn
            // 
            GebruikerBtn.Location = new Point(15, 15);
            GebruikerBtn.Margin = new Padding(4, 4, 4, 4);
            GebruikerBtn.Name = "GebruikerBtn";
            GebruikerBtn.Size = new Size(211, 42);
            GebruikerBtn.TabIndex = 1;
            GebruikerBtn.Text = "Gebruiker";
            GebruikerBtn.UseVisualStyleBackColor = true;
            GebruikerBtn.Click += GebruikerBtn_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(738, 1319);
            Controls.Add(GebruikerBtn);
            Controls.Add(mainPanel);
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Button GebruikerBtn;
    }
}
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.GebruikerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Location = new System.Drawing.Point(1, 60);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(517, 1268);
            this.mainPanel.TabIndex = 0;
            // 
            // GebruikerBtn
            // 
            this.GebruikerBtn.Location = new System.Drawing.Point(12, 12);
            this.GebruikerBtn.Name = "GebruikerBtn";
            this.GebruikerBtn.Size = new System.Drawing.Size(169, 34);
            this.GebruikerBtn.TabIndex = 1;
            this.GebruikerBtn.Text = "Gebruiker";
            this.GebruikerBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(590, 1055);
            this.Controls.Add(this.GebruikerBtn);
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel mainPanel;
        private Button GebruikerBtn;
    }
}
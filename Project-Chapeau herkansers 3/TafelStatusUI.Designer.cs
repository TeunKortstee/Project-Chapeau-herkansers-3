namespace Project_Chapeau_herkansers_3
{
    partial class TafelStatusUI
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
            this.TafelTitelTag = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.MaakBestellingBtn = new System.Windows.Forms.Button();
            this.TerugBtn = new System.Windows.Forms.Button();
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.AfrekenenBtn = new System.Windows.Forms.Button();
            this.labelBestellingAangemaakt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TafelTitelTag
            // 
            this.TafelTitelTag.AutoSize = true;
            this.TafelTitelTag.Location = new System.Drawing.Point(166, 113);
            this.TafelTitelTag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TafelTitelTag.Name = "TafelTitelTag";
            this.TafelTitelTag.Size = new System.Drawing.Size(40, 20);
            this.TafelTitelTag.TabIndex = 0;
            this.TafelTitelTag.Text = "Tafel";
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Location = new System.Drawing.Point(138, 152);
            this.StatusLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(115, 20);
            this.StatusLbl.TabIndex = 1;
            this.StatusLbl.Text = "Deze tafel is nu ";
            // 
            // MaakBestellingBtn
            // 
            this.MaakBestellingBtn.Location = new System.Drawing.Point(127, 322);
            this.MaakBestellingBtn.Margin = new System.Windows.Forms.Padding(2);
            this.MaakBestellingBtn.Name = "MaakBestellingBtn";
            this.MaakBestellingBtn.Size = new System.Drawing.Size(138, 27);
            this.MaakBestellingBtn.TabIndex = 4;
            this.MaakBestellingBtn.Text = "Maak Bestelling";
            this.MaakBestellingBtn.UseVisualStyleBackColor = true;
            this.MaakBestellingBtn.Click += new System.EventHandler(this.MaakBestellingBtn_Click);
            // 
            // TerugBtn
            // 
            this.TerugBtn.Location = new System.Drawing.Point(36, 408);
            this.TerugBtn.Margin = new System.Windows.Forms.Padding(2);
            this.TerugBtn.Name = "TerugBtn";
            this.TerugBtn.Size = new System.Drawing.Size(90, 27);
            this.TerugBtn.TabIndex = 5;
            this.TerugBtn.Text = "Terug";
            this.TerugBtn.UseVisualStyleBackColor = true;
            this.TerugBtn.Click += new System.EventHandler(this.TerugBtn_Click);
            // 
            // StatusBox
            // 
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Location = new System.Drawing.Point(119, 243);
            this.StatusBox.Margin = new System.Windows.Forms.Padding(2);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(146, 28);
            this.StatusBox.TabIndex = 6;
            // 
            // AfrekenenBtn
            // 
            this.AfrekenenBtn.Location = new System.Drawing.Point(254, 408);
            this.AfrekenenBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AfrekenenBtn.Name = "AfrekenenBtn";
            this.AfrekenenBtn.Size = new System.Drawing.Size(90, 27);
            this.AfrekenenBtn.TabIndex = 7;
            this.AfrekenenBtn.Text = "Afrekenen";
            this.AfrekenenBtn.UseVisualStyleBackColor = true;

            // 
            // labelBestellingAangemaakt
            // 
            this.labelBestellingAangemaakt.AutoSize = true;
            this.labelBestellingAangemaakt.Location = new System.Drawing.Point(166, 187);
            this.labelBestellingAangemaakt.Name = "labelBestellingAangemaakt";
            this.labelBestellingAangemaakt.Size = new System.Drawing.Size(50, 20);
            this.labelBestellingAangemaakt.TabIndex = 8;
            this.labelBestellingAangemaakt.Text = "label1";
            // 
            // TafelStatusUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelBestellingAangemaakt);
            this.Controls.Add(this.AfrekenenBtn);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.TerugBtn);
            this.Controls.Add(this.MaakBestellingBtn);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.TafelTitelTag);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TafelStatusUI";
            this.Size = new System.Drawing.Size(386, 478);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TafelTitelTag;
        private Label StatusLbl;
        private Button MaakBestellingBtn;
        private Button TerugBtn;
        private ComboBox StatusBox;
        private Button AfrekenenBtn;
        private Label labelBestellingAangemaakt;
    }
}

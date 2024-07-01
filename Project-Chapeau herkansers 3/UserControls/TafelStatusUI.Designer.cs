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
            this.BestellingDisplayBtn = new System.Windows.Forms.Button();
            this.labelBestellingAangemaakt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TafelTitelTag
            // 
            this.TafelTitelTag.AutoSize = true;
            this.TafelTitelTag.Location = new System.Drawing.Point(145, 85);
            this.TafelTitelTag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TafelTitelTag.Name = "TafelTitelTag";
            this.TafelTitelTag.Size = new System.Drawing.Size(31, 15);
            this.TafelTitelTag.TabIndex = 0;
            this.TafelTitelTag.Text = "Tafel";
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Location = new System.Drawing.Point(120, 114);
            this.StatusLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(89, 15);
            this.StatusLbl.TabIndex = 1;
            this.StatusLbl.Text = "Deze tafel is nu ";
            // 
            // MaakBestellingBtn
            // 
            this.MaakBestellingBtn.Location = new System.Drawing.Point(111, 242);
            this.MaakBestellingBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaakBestellingBtn.Name = "MaakBestellingBtn";
            this.MaakBestellingBtn.Size = new System.Drawing.Size(120, 28);
            this.MaakBestellingBtn.TabIndex = 4;
            this.MaakBestellingBtn.Text = "Maak Bestelling";
            this.MaakBestellingBtn.UseVisualStyleBackColor = true;
            this.MaakBestellingBtn.Click += MaakBestellingBtn_Click;
            // 
            // TerugBtn
            // 
            this.TerugBtn.Location = new System.Drawing.Point(32, 306);
            this.TerugBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TerugBtn.Name = "TerugBtn";
            this.TerugBtn.Size = new System.Drawing.Size(78, 28);
            this.TerugBtn.TabIndex = 5;
            this.TerugBtn.Text = "Terug";
            this.TerugBtn.UseVisualStyleBackColor = true;
            this.TerugBtn.Click += TerugBtn_Click;
            // 
            // StatusBox
            // 
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Location = new System.Drawing.Point(104, 182);
            this.StatusBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(129, 23);
            this.StatusBox.TabIndex = 6;
            StatusBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // AfrekenenBtn
            // 
            this.AfrekenenBtn.Location = new System.Drawing.Point(223, 306);
            this.AfrekenenBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AfrekenenBtn.Name = "AfrekenenBtn";
            this.AfrekenenBtn.Size = new System.Drawing.Size(78, 28);
            this.AfrekenenBtn.TabIndex = 7;
            this.AfrekenenBtn.Text = "Afrekenen";
            this.AfrekenenBtn.UseVisualStyleBackColor = true;
            this.AfrekenenBtn.Click += AfrekenenBtn_Click;
            // 
            // BestellingDisplayBtn
            // 
            this.BestellingDisplayBtn.Location = new System.Drawing.Point(223, 33);
            this.BestellingDisplayBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BestellingDisplayBtn.Name = "BestellingDisplayBtn";
            this.BestellingDisplayBtn.Size = new System.Drawing.Size(95, 28);
            this.BestellingDisplayBtn.TabIndex = 8;
            this.BestellingDisplayBtn.Text = "Zie Bestelling";
            this.BestellingDisplayBtn.UseVisualStyleBackColor = true;
            // 
            // labelBestellingAangemaakt
            // 
            this.labelBestellingAangemaakt.AutoSize = true;
            this.labelBestellingAangemaakt.Location = new System.Drawing.Point(111, 271);
            this.labelBestellingAangemaakt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBestellingAangemaakt.Name = "labelBestellingAangemaakt";
            this.labelBestellingAangemaakt.Size = new System.Drawing.Size(0, 15);
            this.labelBestellingAangemaakt.TabIndex = 9;
            // 
            // TafelStatusUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelBestellingAangemaakt);
            this.Controls.Add(this.BestellingDisplayBtn);
            this.Controls.Add(this.AfrekenenBtn);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.TerugBtn);
            this.Controls.Add(this.MaakBestellingBtn);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.TafelTitelTag);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TafelStatusUI";
            this.Size = new System.Drawing.Size(338, 359);
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
        private Button BestellingDisplayBtn;
        private Label labelBestellingAangemaakt;
    }
}

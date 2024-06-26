﻿namespace Project_Chapeau_herkansers_3
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
            TafelTitelTag = new Label();
            StatusLbl = new Label();
            MaakBestellingBtn = new Button();
            TerugBtn = new Button();
            StatusBox = new ComboBox();
            AfrekenenBtn = new Button();
            BestellingDisplayBtn = new Button();
            labelBestellingAangemaakt = new Label();
            SuspendLayout();
            // 
            // TafelTitelTag
            // 
            TafelTitelTag.AutoSize = true;
            TafelTitelTag.Location = new Point(166, 113);
            TafelTitelTag.Margin = new Padding(2, 0, 2, 0);
            TafelTitelTag.Name = "TafelTitelTag";
            TafelTitelTag.Size = new Size(40, 20);
            TafelTitelTag.TabIndex = 0;
            TafelTitelTag.Text = "Tafel";
            // 
            // StatusLbl
            // 
            StatusLbl.AutoSize = true;
            StatusLbl.Location = new Point(137, 152);
            StatusLbl.Margin = new Padding(2, 0, 2, 0);
            StatusLbl.Name = "StatusLbl";
            StatusLbl.Size = new Size(115, 20);
            StatusLbl.TabIndex = 1;
            StatusLbl.Text = "Deze tafel is nu ";
            // 
            // MaakBestellingBtn
            // 
            MaakBestellingBtn.Location = new Point(127, 323);
            MaakBestellingBtn.Margin = new Padding(2, 3, 2, 3);
            MaakBestellingBtn.Name = "MaakBestellingBtn";
            MaakBestellingBtn.Size = new Size(137, 37);
            MaakBestellingBtn.TabIndex = 4;
            MaakBestellingBtn.Text = "Maak Bestelling";
            MaakBestellingBtn.UseVisualStyleBackColor = true;
            MaakBestellingBtn.Click += MaakBestellingBtn_Click;
            // 
            // TerugBtn
            // 
            TerugBtn.Location = new Point(37, 408);
            TerugBtn.Margin = new Padding(2, 3, 2, 3);
            TerugBtn.Name = "TerugBtn";
            TerugBtn.Size = new Size(89, 37);
            TerugBtn.TabIndex = 5;
            TerugBtn.Text = "Terug";
            TerugBtn.UseVisualStyleBackColor = true;
            TerugBtn.Click += TerugBtn_Click;
            // 
            // StatusBox
            // 
            StatusBox.FormattingEnabled = true;
            StatusBox.Location = new Point(119, 243);
            StatusBox.Margin = new Padding(2, 3, 2, 3);
            StatusBox.Name = "StatusBox";
            StatusBox.Size = new Size(147, 28);
            StatusBox.TabIndex = 6;
            StatusBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // AfrekenenBtn
            // 
            AfrekenenBtn.Location = new Point(255, 408);
            AfrekenenBtn.Margin = new Padding(2, 3, 2, 3);
            AfrekenenBtn.Name = "AfrekenenBtn";
            AfrekenenBtn.Size = new Size(89, 37);
            AfrekenenBtn.TabIndex = 7;
            AfrekenenBtn.Text = "Afrekenen";
            AfrekenenBtn.UseVisualStyleBackColor = true;
            AfrekenenBtn.Click += AfrekenenBtn_Click;
            // 
            // BestellingDisplayBtn
            // 
            BestellingDisplayBtn.Location = new Point(255, 44);
            BestellingDisplayBtn.Margin = new Padding(2, 3, 2, 3);
            BestellingDisplayBtn.Name = "BestellingDisplayBtn";
            BestellingDisplayBtn.Size = new Size(109, 37);
            BestellingDisplayBtn.TabIndex = 8;
            BestellingDisplayBtn.Text = "Zie Bestelling";
            BestellingDisplayBtn.UseVisualStyleBackColor = true;
            BestellingDisplayBtn.Click += BestellingDisplayBtn_Click;
            // 
            // labelBestellingAangemaakt
            // 
            labelBestellingAangemaakt.AutoSize = true;
            labelBestellingAangemaakt.Location = new Point(127, 361);
            labelBestellingAangemaakt.Margin = new Padding(2, 0, 2, 0);
            labelBestellingAangemaakt.Name = "labelBestellingAangemaakt";
            labelBestellingAangemaakt.Size = new Size(0, 20);
            labelBestellingAangemaakt.TabIndex = 9;
            // 
            // TafelStatusUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelBestellingAangemaakt);
            Controls.Add(BestellingDisplayBtn);
            Controls.Add(AfrekenenBtn);
            Controls.Add(StatusBox);
            Controls.Add(TerugBtn);
            Controls.Add(MaakBestellingBtn);
            Controls.Add(StatusLbl);
            Controls.Add(TafelTitelTag);
            Margin = new Padding(2, 3, 2, 3);
            Name = "TafelStatusUI";
            Size = new Size(386, 479);
            ResumeLayout(false);
            PerformLayout();
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

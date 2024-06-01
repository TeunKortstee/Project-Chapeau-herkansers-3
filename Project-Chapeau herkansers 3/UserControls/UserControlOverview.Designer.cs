namespace Project_Chapeau_herkansers_3.UserControls
{
    partial class UserControlOverview
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
            lsvDatabaseItems = new ListView();
            lblOverview = new Label();
            btnAddNew = new Button();
            btnConfirm = new Button();
            btnCancel = new Button();
            cmbCategorie = new ComboBox();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // lsvDatabaseItems
            // 
            lsvDatabaseItems.Location = new Point(30, 251);
            lsvDatabaseItems.Margin = new Padding(3, 4, 3, 4);
            lsvDatabaseItems.Name = "lsvDatabaseItems";
            lsvDatabaseItems.Size = new Size(340, 393);
            lsvDatabaseItems.TabIndex = 0;
            lsvDatabaseItems.UseCompatibleStateImageBehavior = false;
            lsvDatabaseItems.View = View.Details;
            // 
            // lblOverview
            // 
            lblOverview.AutoSize = true;
            lblOverview.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblOverview.Location = new Point(119, 14);
            lblOverview.Name = "lblOverview";
            lblOverview.Size = new Size(172, 46);
            lblOverview.TabIndex = 1;
            lblOverview.Text = "Overzicht";
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.FromArgb(138, 210, 176);
            btnAddNew.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddNew.Location = new Point(205, 191);
            btnAddNew.Margin = new Padding(3, 4, 3, 4);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(166, 48);
            btnAddNew.TabIndex = 2;
            btnAddNew.Text = "Nieuw Toevoegen";
            btnAddNew.UseVisualStyleBackColor = false;
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
            // cmbCategorie
            // 
            cmbCategorie.FormattingEnabled = true;
            cmbCategorie.Location = new Point(30, 191);
            cmbCategorie.Name = "cmbCategorie";
            cmbCategorie.Size = new Size(151, 28);
            cmbCategorie.TabIndex = 27;
            cmbCategorie.SelectedIndexChanged += cmbCategorie_SelectedIndexChanged;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.FromArgb(255, 179, 71);
            btnReturn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.Location = new Point(303, 20);
            btnReturn.Margin = new Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(68, 48);
            btnReturn.TabIndex = 28;
            btnReturn.Text = "Terug";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // UserControlOverview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnReturn);
            Controls.Add(cmbCategorie);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(btnAddNew);
            Controls.Add(lblOverview);
            Controls.Add(lsvDatabaseItems);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlOverview";
            Size = new Size(414, 736);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lsvDatabaseItems;
        private Label lblOverview;
        private Button btnAddNew;
        private Button btnConfirm;
        private Button btnCancel;
        private ComboBox cmbCategorie;
        private Button btnReturn;
    }
}

namespace Project_Chapeau_herkansers_3.UserControls
{
    partial class UserControlEmployees
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
            Items = new ColumnHeader();
            Voorraad = new ColumnHeader();
            lblPersoneel = new Label();
            btnAddNew = new Button();
            btnConfirm = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lsvDatabaseItems
            // 
            lsvDatabaseItems.Columns.AddRange(new ColumnHeader[] { Items, Voorraad });
            lsvDatabaseItems.Location = new Point(30, 251);
            lsvDatabaseItems.Margin = new Padding(3, 4, 3, 4);
            lsvDatabaseItems.Name = "lsvDatabaseItems";
            lsvDatabaseItems.Size = new Size(340, 393);
            lsvDatabaseItems.TabIndex = 0;
            lsvDatabaseItems.UseCompatibleStateImageBehavior = false;
            // 
            // lblPersoneel
            // 
            lblPersoneel.AutoSize = true;
            lblPersoneel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblPersoneel.Location = new Point(28, 187);
            lblPersoneel.Name = "lblPersoneel";
            lblPersoneel.Size = new Size(175, 46);
            lblPersoneel.TabIndex = 1;
            lblPersoneel.Text = "Personeel";
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
            // UserControlEmployees
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(btnAddNew);
            Controls.Add(lblPersoneel);
            Controls.Add(lsvDatabaseItems);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlEmployees";
            Size = new Size(414, 736);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lsvDatabaseItems;
        private ColumnHeader Items;
        private ColumnHeader Voorraad;
        private Label lblPersoneel;
        private Button btnAddNew;
        private Button btnConfirm;
        private Button btnCancel;
    }
}

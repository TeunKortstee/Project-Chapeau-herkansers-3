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
            label1 = new Label();
            btnAddNew = new Button();
            btnConfirm = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lsvDatabaseItems
            // 
            lsvDatabaseItems.Columns.AddRange(new ColumnHeader[] { Items, Voorraad });
            lsvDatabaseItems.Location = new Point(26, 188);
            lsvDatabaseItems.Name = "lsvDatabaseItems";
            lsvDatabaseItems.Size = new Size(298, 296);
            lsvDatabaseItems.TabIndex = 0;
            lsvDatabaseItems.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 120);
            label1.Name = "label1";
            label1.Size = new Size(129, 65);
            label1.TabIndex = 1;
            label1.Text = "Titel";
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.FromArgb(138, 210, 176);
            btnAddNew.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddNew.Location = new Point(179, 143);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(145, 36);
            btnAddNew.TabIndex = 2;
            btnAddNew.Text = "Nieuw Toevoegen";
            btnAddNew.UseVisualStyleBackColor = false;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(138, 210, 176);
            btnConfirm.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirm.Location = new Point(26, 490);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(97, 39);
            btnConfirm.TabIndex = 3;
            btnConfirm.Text = "Bevestig";
            btnConfirm.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(245, 108, 117);
            btnCancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(129, 490);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 39);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Annuleer";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // UserControlEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(btnAddNew);
            Controls.Add(label1);
            Controls.Add(lsvDatabaseItems);
            Name = "UserControlEmployees";
            Size = new Size(362, 552);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lsvDatabaseItems;
        private ColumnHeader Items;
        private ColumnHeader Voorraad;
        private Label label1;
        private Button btnAddNew;
        private Button btnConfirm;
        private Button btnCancel;
    }
}

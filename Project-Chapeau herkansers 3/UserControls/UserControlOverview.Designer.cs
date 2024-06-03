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
            btnAdjust = new Button();
            btnRemove = new Button();
            btnReturn = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            SuspendLayout();
            // 
            // lsvDatabaseItems
            // 
            lsvDatabaseItems.FullRowSelect = true;
            lsvDatabaseItems.Location = new Point(14, 251);
            lsvDatabaseItems.Margin = new Padding(3, 4, 3, 4);
            lsvDatabaseItems.MultiSelect = false;
            lsvDatabaseItems.Name = "lsvDatabaseItems";
            lsvDatabaseItems.Size = new Size(380, 380);
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
            btnAddNew.Location = new Point(14, 139);
            btnAddNew.Margin = new Padding(3, 4, 3, 4);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(380, 48);
            btnAddNew.TabIndex = 2;
            btnAddNew.Text = "Nieuw Toevoegen";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnAdjust
            // 
            btnAdjust.BackColor = Color.FromArgb(138, 210, 176);
            btnAdjust.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdjust.Location = new Point(14, 651);
            btnAdjust.Margin = new Padding(3, 4, 3, 4);
            btnAdjust.Name = "btnAdjust";
            btnAdjust.Size = new Size(120, 52);
            btnAdjust.TabIndex = 3;
            btnAdjust.Text = "Aanpassen";
            btnAdjust.UseVisualStyleBackColor = false;
            btnAdjust.Click += btnAdjust_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(245, 108, 117);
            btnRemove.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemove.Location = new Point(136, 651);
            btnRemove.Margin = new Padding(3, 4, 3, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(130, 52);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Verwijderen";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.FromArgb(255, 179, 71);
            btnReturn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.Location = new Point(326, 20);
            btnReturn.Margin = new Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(68, 48);
            btnReturn.TabIndex = 28;
            btnReturn.Text = "Terug";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(138, 210, 176);
            btn1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(14, 194);
            btn1.Name = "btn1";
            btn1.Size = new Size(123, 50);
            btn1.TabIndex = 29;
            btn1.Text = "Optie 1";
            btn1.UseVisualStyleBackColor = false;
            btn1.EnabledChanged += btn1_EnabledChanged;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(138, 210, 176);
            btn2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(143, 194);
            btn2.Name = "btn2";
            btn2.Size = new Size(123, 50);
            btn2.TabIndex = 30;
            btn2.Text = "Optie 2";
            btn2.UseVisualStyleBackColor = false;
            btn2.EnabledChanged += btn2_EnabledChanged;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(138, 210, 176);
            btn3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(272, 194);
            btn3.Name = "btn3";
            btn3.Size = new Size(123, 50);
            btn3.TabIndex = 31;
            btn3.Text = "Optie 3";
            btn3.UseVisualStyleBackColor = false;
            btn3.EnabledChanged += btn3_EnabledChanged;
            btn3.Click += btn3_Click;
            // 
            // UserControlOverview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnReturn);
            Controls.Add(btnRemove);
            Controls.Add(btnAdjust);
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
        private Button btnAdjust;
        private Button btnRemove;
        private Button btnReturn;
        private Button btn1;
        private Button btn2;
        private Button btn3;
    }
}

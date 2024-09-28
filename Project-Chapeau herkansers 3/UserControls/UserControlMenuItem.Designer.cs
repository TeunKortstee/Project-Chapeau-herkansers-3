namespace Project_Chapeau_herkansers_3.UserControls
{
    partial class UserControlMenuItem
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
            lblTitel = new Label();
            btnAddNewObject = new Button();
            btnAdjust = new Button();
            btnRemove = new Button();
            btnReturn = new Button();
            lblErrorOverview = new Label();
            btnBar = new Button();
            btnKeuken = new Button();
            SuspendLayout();
            // 
            // lsvDatabaseItems
            // 
            lsvDatabaseItems.FullRowSelect = true;
            lsvDatabaseItems.Location = new Point(14, 233);
            lsvDatabaseItems.Margin = new Padding(3, 4, 3, 4);
            lsvDatabaseItems.MultiSelect = false;
            lsvDatabaseItems.Name = "lsvDatabaseItems";
            lsvDatabaseItems.Size = new Size(380, 380);
            lsvDatabaseItems.TabIndex = 0;
            lsvDatabaseItems.UseCompatibleStateImageBehavior = false;
            lsvDatabaseItems.View = View.Details;
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitel.Location = new Point(119, 14);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(172, 46);
            lblTitel.TabIndex = 1;
            lblTitel.Text = "Overzicht";
            // 
            // btnAddNewObject
            // 
            btnAddNewObject.BackColor = Color.FromArgb(138, 210, 176);
            btnAddNewObject.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddNewObject.Location = new Point(14, 121);
            btnAddNewObject.Margin = new Padding(3, 4, 3, 4);
            btnAddNewObject.Name = "btnAddNewObject";
            btnAddNewObject.Size = new Size(380, 48);
            btnAddNewObject.TabIndex = 2;
            btnAddNewObject.Text = "... Toevoegen";
            btnAddNewObject.UseVisualStyleBackColor = false;
            btnAddNewObject.Visible = false;
            btnAddNewObject.Click += btnAddNew_Click;
            // 
            // btnAdjust
            // 
            btnAdjust.BackColor = Color.FromArgb(138, 210, 176);
            btnAdjust.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdjust.Location = new Point(14, 621);
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
            btnRemove.Location = new Point(136, 621);
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
            // lblErrorOverview
            // 
            lblErrorOverview.AutoSize = true;
            lblErrorOverview.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrorOverview.ForeColor = Color.Red;
            lblErrorOverview.Location = new Point(17, 677);
            lblErrorOverview.Name = "lblErrorOverview";
            lblErrorOverview.Size = new Size(120, 25);
            lblErrorOverview.TabIndex = 37;
            lblErrorOverview.Text = "Error Bericht";
            lblErrorOverview.Visible = false;
            // 
            // btnBar
            // 
            btnBar.BackColor = Color.FromArgb(138, 210, 176);
            btnBar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBar.Location = new Point(204, 176);
            btnBar.Name = "btnBar";
            btnBar.Size = new Size(190, 50);
            btnBar.TabIndex = 51;
            btnBar.Text = "Bar";
            btnBar.UseVisualStyleBackColor = false;
            btnBar.EnabledChanged += BarButtonEnabledChanged;
            // 
            // btnKeuken
            // 
            btnKeuken.BackColor = Color.FromArgb(138, 210, 176);
            btnKeuken.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKeuken.Location = new Point(14, 176);
            btnKeuken.Name = "btnKeuken";
            btnKeuken.Size = new Size(190, 50);
            btnKeuken.TabIndex = 50;
            btnKeuken.Text = "Keuken";
            btnKeuken.UseVisualStyleBackColor = false;
            btnKeuken.EnabledChanged += KeukenButtonEnabledChanged;
            // 
            // UserControlMenuItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnBar);
            Controls.Add(btnKeuken);
            Controls.Add(lblErrorOverview);
            Controls.Add(btnReturn);
            Controls.Add(btnRemove);
            Controls.Add(btnAdjust);
            Controls.Add(btnAddNewObject);
            Controls.Add(lblTitel);
            Controls.Add(lsvDatabaseItems);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlMenuItem";
            Size = new Size(414, 736);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lsvDatabaseItems;
        private Label lblTitel;
        private Button btnAddNewObject;
        private Button btnAdjust;
        private Button btnRemove;
        private Button btnReturn;
        private Label lblErrorOverview;
        private Button btnBar;
        private Button btnKeuken;
    }
}

namespace Project_Chapeau_herkansers_3.UserControls
{
    partial class UserControlPersoneel
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
            btnAddNewObject = new Button();
            btnAdjust = new Button();
            btnRemove = new Button();
            btnReturn = new Button();
            lblErrorOverview = new Label();
            btnBediening = new Button();
            btnKeuken = new Button();
            btnBar = new Button();
            btnManagers = new Button();
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
            // lblOverview
            // 
            lblOverview.AutoSize = true;
            lblOverview.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblOverview.Location = new Point(119, 14);
            lblOverview.Name = "lblOverview";
            lblOverview.Size = new Size(175, 46);
            lblOverview.TabIndex = 1;
            lblOverview.Text = "Personeel";
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
            btnAddNewObject.Text = "Personeel Toevoegen";
            btnAddNewObject.UseVisualStyleBackColor = false;
            btnAddNewObject.Click += btnAddNewObject_Click;
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
            // lblErrorOverview
            // 
            lblErrorOverview.AutoSize = true;
            lblErrorOverview.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrorOverview.ForeColor = Color.Red;
            lblErrorOverview.Location = new Point(17, 707);
            lblErrorOverview.Name = "lblErrorOverview";
            lblErrorOverview.Size = new Size(120, 25);
            lblErrorOverview.TabIndex = 37;
            lblErrorOverview.Text = "Error Bericht";
            lblErrorOverview.Visible = false;
            // 
            // btnBediening
            // 
            btnBediening.BackColor = Color.FromArgb(138, 210, 176);
            btnBediening.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBediening.Location = new Point(14, 176);
            btnBediening.Name = "btnBediening";
            btnBediening.Size = new Size(90, 50);
            btnBediening.TabIndex = 54;
            btnBediening.Text = "Bediening";
            btnBediening.UseVisualStyleBackColor = false;
            btnBediening.EnabledChanged += BedieningButtonEnabledChanged;
            btnBediening.Click += BedieningClick;
            // 
            // btnKeuken
            // 
            btnKeuken.BackColor = Color.FromArgb(138, 210, 176);
            btnKeuken.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKeuken.Location = new Point(110, 176);
            btnKeuken.Name = "btnKeuken";
            btnKeuken.Size = new Size(90, 50);
            btnKeuken.TabIndex = 55;
            btnKeuken.Text = "Keuken";
            btnKeuken.UseVisualStyleBackColor = false;
            btnKeuken.EnabledChanged += KeukenButtonEnabledChanged;
            btnKeuken.Click += KeukenClick;
            // 
            // btnBar
            // 
            btnBar.BackColor = Color.FromArgb(138, 210, 176);
            btnBar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBar.Location = new Point(208, 176);
            btnBar.Name = "btnBar";
            btnBar.Size = new Size(90, 50);
            btnBar.TabIndex = 56;
            btnBar.Text = "Bar";
            btnBar.UseVisualStyleBackColor = false;
            btnBar.EnabledChanged += BarButtonEnabledChanged;
            btnBar.Click += BarClick;
            // 
            // btnManagers
            // 
            btnManagers.BackColor = Color.FromArgb(138, 210, 176);
            btnManagers.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnManagers.Location = new Point(304, 176);
            btnManagers.Name = "btnManagers";
            btnManagers.Size = new Size(90, 50);
            btnManagers.TabIndex = 57;
            btnManagers.Text = "Managers";
            btnManagers.UseVisualStyleBackColor = false;
            btnManagers.EnabledChanged += ManagersButtonEnabledChanged;
            btnManagers.Click += ManagersClick;
            // 
            // UserControlPersoneel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnManagers);
            Controls.Add(btnBar);
            Controls.Add(btnKeuken);
            Controls.Add(btnBediening);
            Controls.Add(lblErrorOverview);
            Controls.Add(btnReturn);
            Controls.Add(btnRemove);
            Controls.Add(btnAdjust);
            Controls.Add(btnAddNewObject);
            Controls.Add(lblOverview);
            Controls.Add(lsvDatabaseItems);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlPersoneel";
            Size = new Size(414, 736);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lsvDatabaseItems;
        private Label lblOverview;
        private Button btnAddNewObject;
        private Button btnAdjust;
        private Button btnRemove;
        private Button btnReturn;
        private Label lblErrorOverview;
        private Button btnBediening;
        private Button btnKeuken;
        private Button btnBar;
        private Button btnManagers;
    }
}

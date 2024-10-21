namespace Project_Chapeau_herkansers_3.UserControls
{
    partial class UserControlMenu
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
            btnDiner = new Button();
            btnLunch = new Button();
            lblTotalIncome = new Label();
            dtpDatumVan = new DateTimePicker();
            btnDrank = new Button();
            dtpDatumTot = new DateTimePicker();
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
            btnRemove.Visible = false;
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
            // btnDiner
            // 
            btnDiner.BackColor = Color.FromArgb(138, 210, 176);
            btnDiner.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiner.Location = new Point(143, 176);
            btnDiner.Name = "btnDiner";
            btnDiner.Size = new Size(123, 50);
            btnDiner.TabIndex = 51;
            btnDiner.Text = "Diner";
            btnDiner.UseVisualStyleBackColor = false;
            btnDiner.EnabledChanged += DinerButtonEnabledChanged;
            // 
            // btnLunch
            // 
            btnLunch.BackColor = Color.FromArgb(138, 210, 176);
            btnLunch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLunch.Location = new Point(14, 176);
            btnLunch.Name = "btnLunch";
            btnLunch.Size = new Size(123, 50);
            btnLunch.TabIndex = 50;
            btnLunch.Text = "Lunch";
            btnLunch.UseVisualStyleBackColor = false;
            btnLunch.EnabledChanged += LunchButtonEnabledChanged;
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.AutoSize = true;
            lblTotalIncome.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalIncome.Location = new Point(14, 108);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new Size(134, 38);
            lblTotalIncome.TabIndex = 52;
            lblTotalIncome.Text = "Inkomen";
            lblTotalIncome.Visible = false;
            // 
            // dtpDatumVan
            // 
            dtpDatumVan.Location = new Point(14, 620);
            dtpDatumVan.Name = "dtpDatumVan";
            dtpDatumVan.Size = new Size(188, 27);
            dtpDatumVan.TabIndex = 53;
            dtpDatumVan.Visible = false;
            dtpDatumVan.ValueChanged += DatumValueChanged;
            // 
            // btnDrank
            // 
            btnDrank.BackColor = Color.FromArgb(138, 210, 176);
            btnDrank.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDrank.Location = new Point(272, 176);
            btnDrank.Name = "btnDrank";
            btnDrank.Size = new Size(123, 50);
            btnDrank.TabIndex = 54;
            btnDrank.Text = "Drank";
            btnDrank.UseVisualStyleBackColor = false;
            btnDrank.EnabledChanged += DrankButtonEnabledChanged;
            // 
            // dtpDatumTot
            // 
            dtpDatumTot.Location = new Point(206, 621);
            dtpDatumTot.Name = "dtpDatumTot";
            dtpDatumTot.Size = new Size(188, 27);
            dtpDatumTot.TabIndex = 55;
            dtpDatumTot.Visible = false;
            dtpDatumTot.ValueChanged += DatumValueChanged;
            // 
            // UserControlMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dtpDatumTot);
            Controls.Add(btnDrank);
            Controls.Add(dtpDatumVan);
            Controls.Add(lblTotalIncome);
            Controls.Add(btnDiner);
            Controls.Add(btnLunch);
            Controls.Add(lblErrorOverview);
            Controls.Add(btnReturn);
            Controls.Add(btnRemove);
            Controls.Add(btnAdjust);
            Controls.Add(btnAddNewObject);
            Controls.Add(lblTitel);
            Controls.Add(lsvDatabaseItems);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControlMenu";
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
        private Button btnDiner;
        private Button btnLunch;
        private Label lblTotalIncome;
        private DateTimePicker dtpDatumVan;
        private Button btnDrank;
        private DateTimePicker dtpDatumTot;
    }
}

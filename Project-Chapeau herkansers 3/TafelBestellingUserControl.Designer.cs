namespace Project_Chapeau_herkansers_3
{
    partial class TafelBestellingUserControl
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
            BereiderBox = new ComboBox();
            StuurTerugBtn = new Button();
            AfrondBtn = new Button();
            TerugBtn = new Button();
            BesteldeItemsListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            ErrorLbl = new Label();
            SuspendLayout();
            // 
            // BereiderBox
            // 
            BereiderBox.FormattingEnabled = true;
            BereiderBox.Location = new Point(90, 104);
            BereiderBox.Name = "BereiderBox";
            BereiderBox.Size = new Size(182, 33);
            BereiderBox.TabIndex = 0;
            BereiderBox.SelectedIndexChanged += BereiderBox_SelectedIndexChanged;
            // 
            // StuurTerugBtn
            // 
            StuurTerugBtn.Location = new Point(41, 336);
            StuurTerugBtn.Name = "StuurTerugBtn";
            StuurTerugBtn.Size = new Size(112, 34);
            StuurTerugBtn.TabIndex = 1;
            StuurTerugBtn.Text = "Stuur terug";
            StuurTerugBtn.UseVisualStyleBackColor = true;
            StuurTerugBtn.Click += StuurTerugBtn_Click;
            // 
            // AfrondBtn
            // 
            AfrondBtn.Location = new Point(214, 336);
            AfrondBtn.Name = "AfrondBtn";
            AfrondBtn.Size = new Size(112, 34);
            AfrondBtn.TabIndex = 2;
            AfrondBtn.Text = "Afronden";
            AfrondBtn.UseVisualStyleBackColor = true;
            AfrondBtn.Click += AfrondBtn_Click;
            // 
            // TerugBtn
            // 
            TerugBtn.Location = new Point(25, 50);
            TerugBtn.Name = "TerugBtn";
            TerugBtn.Size = new Size(112, 34);
            TerugBtn.TabIndex = 6;
            TerugBtn.Text = "Terug";
            TerugBtn.UseVisualStyleBackColor = true;
            TerugBtn.Click += TerugBtn_Click;
            // 
            // BesteldeItemsListView
            // 
            BesteldeItemsListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            BesteldeItemsListView.FullRowSelect = true;
            BesteldeItemsListView.GridLines = true;
            BesteldeItemsListView.Location = new Point(25, 158);
            BesteldeItemsListView.Name = "BesteldeItemsListView";
            BesteldeItemsListView.Size = new Size(334, 162);
            BesteldeItemsListView.TabIndex = 7;
            BesteldeItemsListView.UseCompatibleStateImageBehavior = false;
            BesteldeItemsListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Naam";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Wachttijd";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Status";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Id";
            // 
            // ErrorLbl
            // 
            ErrorLbl.AutoSize = true;
            ErrorLbl.ForeColor = Color.Red;
            ErrorLbl.Location = new Point(37, 405);
            ErrorLbl.Name = "ErrorLbl";
            ErrorLbl.Size = new Size(0, 25);
            ErrorLbl.TabIndex = 8;
            // 
            // TafelBestellingUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ErrorLbl);
            Controls.Add(BesteldeItemsListView);
            Controls.Add(TerugBtn);
            Controls.Add(AfrondBtn);
            Controls.Add(StuurTerugBtn);
            Controls.Add(BereiderBox);
            Name = "TafelBestellingUserControl";
            Size = new Size(373, 722);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox BereiderBox;
        private Button StuurTerugBtn;
        private Button AfrondBtn;
        private Button TerugBtn;
        private ListView BesteldeItemsListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label ErrorLbl;
    }
}

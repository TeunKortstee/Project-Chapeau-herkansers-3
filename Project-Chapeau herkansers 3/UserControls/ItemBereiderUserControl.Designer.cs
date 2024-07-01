namespace Project_Chapeau_herkansers_3.UserControls
{
    partial class ItemBereiderUserControl
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
            this.orderListView = new System.Windows.Forms.ListView();
            this.BesteldItemIdHdr = new System.Windows.Forms.ColumnHeader();
            this.CountHdr = new System.Windows.Forms.ColumnHeader();
            this.DescriptionHdr = new System.Windows.Forms.ColumnHeader();
            this.TitelLbl = new System.Windows.Forms.Label();
            this.ActionsGroupBox = new System.Windows.Forms.GroupBox();
            this.ServedButton = new System.Windows.Forms.Button();
            this.PreparedBtn = new System.Windows.Forms.Button();
            this.InPreparationBtn = new System.Windows.Forms.Button();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.informationTextBox = new System.Windows.Forms.TextBox();
            this.ActionsGroupBox.SuspendLayout();
            this.InfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderListView
            // 
            this.orderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BesteldItemIdHdr,
            this.CountHdr,
            this.DescriptionHdr});
            this.orderListView.Dock = System.Windows.Forms.DockStyle.Top;
            this.orderListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderListView.FullRowSelect = true;
            this.orderListView.GridLines = true;
            this.orderListView.Location = new System.Drawing.Point(0, 0);
            this.orderListView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.orderListView.Name = "orderListView";
            this.orderListView.Size = new System.Drawing.Size(1402, 336);
            this.orderListView.TabIndex = 42;
            this.orderListView.UseCompatibleStateImageBehavior = false;
            this.orderListView.View = System.Windows.Forms.View.Details;
            // 
            // BesteldItemIdHdr
            // 
            this.BesteldItemIdHdr.Tag = "";
            this.BesteldItemIdHdr.Text = "OrderId";
            this.BesteldItemIdHdr.Width = 80;
            // 
            // CountHdr
            // 
            this.CountHdr.Tag = "";
            this.CountHdr.Text = "Count";
            // 
            // DescriptionHdr
            // 
            this.DescriptionHdr.Tag = "";
            this.DescriptionHdr.Text = "Description";
            this.DescriptionHdr.Width = 400;
            // 
            // TitelLbl
            // 
            this.TitelLbl.AutoSize = true;
            this.TitelLbl.Location = new System.Drawing.Point(487, 17);
            this.TitelLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitelLbl.Name = "TitelLbl";
            this.TitelLbl.Size = new System.Drawing.Size(0, 20);
            this.TitelLbl.TabIndex = 41;
            // 
            // ActionsGroupBox
            // 
            this.ActionsGroupBox.Controls.Add(this.ServedButton);
            this.ActionsGroupBox.Controls.Add(this.PreparedBtn);
            this.ActionsGroupBox.Controls.Add(this.InPreparationBtn);
            this.ActionsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ActionsGroupBox.Location = new System.Drawing.Point(0, 336);
            this.ActionsGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ActionsGroupBox.Name = "ActionsGroupBox";
            this.ActionsGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ActionsGroupBox.Size = new System.Drawing.Size(1402, 77);
            this.ActionsGroupBox.TabIndex = 61;
            this.ActionsGroupBox.TabStop = false;
            this.ActionsGroupBox.Text = "Actions";
            // 
            // ServedButton
            // 
            this.ServedButton.BackColor = System.Drawing.Color.LimeGreen;
            this.ServedButton.Location = new System.Drawing.Point(245, 28);
            this.ServedButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ServedButton.Name = "ServedButton";
            this.ServedButton.Size = new System.Drawing.Size(103, 43);
            this.ServedButton.TabIndex = 49;
            this.ServedButton.Text = "Served";
            this.ServedButton.UseVisualStyleBackColor = false;
            // 
            // PreparedBtn
            // 
            this.PreparedBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.PreparedBtn.Location = new System.Drawing.Point(138, 28);
            this.PreparedBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PreparedBtn.Name = "PreparedBtn";
            this.PreparedBtn.Size = new System.Drawing.Size(103, 43);
            this.PreparedBtn.TabIndex = 48;
            this.PreparedBtn.Text = "Prepared";
            this.PreparedBtn.UseVisualStyleBackColor = false;
            // 
            // InPreparationBtn
            // 
            this.InPreparationBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.InPreparationBtn.Location = new System.Drawing.Point(10, 28);
            this.InPreparationBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.InPreparationBtn.Name = "InPreparationBtn";
            this.InPreparationBtn.Size = new System.Drawing.Size(124, 43);
            this.InPreparationBtn.TabIndex = 47;
            this.InPreparationBtn.Text = "In preparation";
            this.InPreparationBtn.UseVisualStyleBackColor = false;
            // 
            // InfoGroupBox
            // 
            this.InfoGroupBox.Controls.Add(this.informationTextBox);
            this.InfoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoGroupBox.Location = new System.Drawing.Point(0, 413);
            this.InfoGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InfoGroupBox.Size = new System.Drawing.Size(1402, 434);
            this.InfoGroupBox.TabIndex = 62;
            this.InfoGroupBox.TabStop = false;
            this.InfoGroupBox.Text = "Info";
            // 
            // informationTextBox
            // 
            this.informationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.informationTextBox.Location = new System.Drawing.Point(3, 24);
            this.informationTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.informationTextBox.Multiline = true;
            this.informationTextBox.Name = "informationTextBox";
            this.informationTextBox.ReadOnly = true;
            this.informationTextBox.Size = new System.Drawing.Size(1396, 406);
            this.informationTextBox.TabIndex = 0;
            // 
            // ItemBereiderUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InfoGroupBox);
            this.Controls.Add(this.ActionsGroupBox);
            this.Controls.Add(this.orderListView);
            this.Controls.Add(this.TitelLbl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ItemBereiderUserControl";
            this.Size = new System.Drawing.Size(1402, 847);
            this.ActionsGroupBox.ResumeLayout(false);
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label NotStartedLbl;
        private Label InPrepLbl;
        private ListView NotStartedListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ListView orderListView;
        private ColumnHeader BesteldItemIdHdr;
        private ColumnHeader CountHdr;
        private ColumnHeader DescriptionHdr;
        private Label TitelLbl;
        private GroupBox ActionsGroupBox;
        private Button PreparedBtn;
        private Button InPreparationBtn;
        private GroupBox InfoGroupBox;
        private TextBox informationTextBox;
        private Button ServedButton;
    }
}

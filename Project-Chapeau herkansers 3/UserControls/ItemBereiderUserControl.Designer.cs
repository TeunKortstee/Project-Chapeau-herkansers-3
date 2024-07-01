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
            orderListView = new ListView();
            BesteldItemIdHdr = new ColumnHeader();
            CountHdr = new ColumnHeader();
            DescriptionHdr = new ColumnHeader();
            TitelLbl = new Label();
            ActionsGroupBox = new GroupBox();
            ServedButton = new Button();
            PreparedBtn = new Button();
            InPreparationBtn = new Button();
            InfoGroupBox = new GroupBox();
            informationTextBox = new TextBox();
            ActionsGroupBox.SuspendLayout();
            InfoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // orderListView
            // 
            orderListView.Columns.AddRange(new ColumnHeader[] { BesteldItemIdHdr, CountHdr, DescriptionHdr });
            orderListView.Dock = DockStyle.Top;
            orderListView.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            orderListView.FullRowSelect = true;
            orderListView.GridLines = true;
            orderListView.Location = new Point(0, 0);
            orderListView.Margin = new Padding(2);
            orderListView.Name = "orderListView";
            orderListView.Size = new Size(1227, 253);
            orderListView.TabIndex = 42;
            orderListView.UseCompatibleStateImageBehavior = false;
            orderListView.View = View.Details;
            orderListView.SelectedIndexChanged += orderListView_SelectedIndexChanged;
            // 
            // BesteldItemIdHdr
            // 
            BesteldItemIdHdr.Tag = "";
            BesteldItemIdHdr.Text = "OrderId";
            BesteldItemIdHdr.Width = 80;
            // 
            // CountHdr
            // 
            CountHdr.Tag = "";
            CountHdr.Text = "Count";
            // 
            // DescriptionHdr
            // 
            DescriptionHdr.Tag = "";
            DescriptionHdr.Text = "Description";
            DescriptionHdr.Width = 400;
            // 
            // TitelLbl
            // 
            TitelLbl.AutoSize = true;
            TitelLbl.Location = new Point(426, 13);
            TitelLbl.Margin = new Padding(2, 0, 2, 0);
            TitelLbl.Name = "TitelLbl";
            TitelLbl.Size = new Size(0, 15);
            TitelLbl.TabIndex = 41;
            // 
            // ActionsGroupBox
            // 
            ActionsGroupBox.Controls.Add(ServedButton);
            ActionsGroupBox.Controls.Add(PreparedBtn);
            ActionsGroupBox.Controls.Add(InPreparationBtn);
            ActionsGroupBox.Dock = DockStyle.Top;
            ActionsGroupBox.Location = new Point(0, 253);
            ActionsGroupBox.Name = "ActionsGroupBox";
            ActionsGroupBox.Size = new Size(1227, 58);
            ActionsGroupBox.TabIndex = 61;
            ActionsGroupBox.TabStop = false;
            ActionsGroupBox.Text = "Actions";
            // 
            // ServedButton
            // 
            ServedButton.BackColor = Color.LimeGreen;
            ServedButton.Location = new Point(201, 21);
            ServedButton.Margin = new Padding(2);
            ServedButton.Name = "ServedButton";
            ServedButton.Size = new Size(90, 32);
            ServedButton.TabIndex = 49;
            ServedButton.Text = "Served";
            ServedButton.UseVisualStyleBackColor = false;
            ServedButton.Click += ServedButton_Click;
            // 
            // PreparedBtn
            // 
            PreparedBtn.BackColor = Color.DarkOrange;
            PreparedBtn.Location = new Point(107, 21);
            PreparedBtn.Margin = new Padding(2);
            PreparedBtn.Name = "PreparedBtn";
            PreparedBtn.Size = new Size(90, 32);
            PreparedBtn.TabIndex = 48;
            PreparedBtn.Text = "Prepared";
            PreparedBtn.UseVisualStyleBackColor = false;
            PreparedBtn.Click += PreparedBtn_Click;
            // 
            // InPreparationBtn
            // 
            InPreparationBtn.BackColor = SystemColors.ControlLightLight;
            InPreparationBtn.Location = new Point(9, 21);
            InPreparationBtn.Margin = new Padding(2);
            InPreparationBtn.Name = "InPreparationBtn";
            InPreparationBtn.Size = new Size(94, 32);
            InPreparationBtn.TabIndex = 47;
            InPreparationBtn.Text = "In preparation";
            InPreparationBtn.UseVisualStyleBackColor = false;
            InPreparationBtn.Click += InPreparationBtn_Click;
            // 
            // InfoGroupBox
            // 
            InfoGroupBox.Controls.Add(informationTextBox);
            InfoGroupBox.Dock = DockStyle.Fill;
            InfoGroupBox.Location = new Point(0, 311);
            InfoGroupBox.Name = "InfoGroupBox";
            InfoGroupBox.Size = new Size(1227, 324);
            InfoGroupBox.TabIndex = 62;
            InfoGroupBox.TabStop = false;
            InfoGroupBox.Text = "Info";
            // 
            // informationTextBox
            // 
            informationTextBox.Dock = DockStyle.Fill;
            informationTextBox.Location = new Point(3, 19);
            informationTextBox.Multiline = true;
            informationTextBox.Name = "informationTextBox";
            informationTextBox.ReadOnly = true;
            informationTextBox.Size = new Size(1221, 302);
            informationTextBox.TabIndex = 0;
            // 
            // ItemBereiderUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(InfoGroupBox);
            Controls.Add(ActionsGroupBox);
            Controls.Add(orderListView);
            Controls.Add(TitelLbl);
            Name = "ItemBereiderUserControl";
            Size = new Size(1227, 635);
            Load += ItemBereiderUserControl_Load;
            ActionsGroupBox.ResumeLayout(false);
            InfoGroupBox.ResumeLayout(false);
            InfoGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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

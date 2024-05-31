namespace Project_Chapeau_herkansers_3
{
    partial class Afrekenen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "2x",
            "Veal Tartare",
            "8,50"}, -1);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.billTitleText = new System.Windows.Forms.Label();
            this.billListView = new System.Windows.Forms.ListView();
            this.billColumnAmount = new System.Windows.Forms.ColumnHeader();
            this.billColumnName = new System.Windows.Forms.ColumnHeader();
            this.billColumnPrice = new System.Windows.Forms.ColumnHeader();
            this.billTotalText = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.billTotalAmountText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Project_Chapeau_herkansers_3.Properties.Resources._13ec534cac352913c97662d176dd3724;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 39);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // billTitleText
            // 
            this.billTitleText.AutoSize = true;
            this.billTitleText.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.billTitleText.Location = new System.Drawing.Point(8, 11);
            this.billTitleText.Name = "billTitleText";
            this.billTitleText.Size = new System.Drawing.Size(96, 50);
            this.billTitleText.TabIndex = 1;
            this.billTitleText.Text = "BILL";
            // 
            // billListView
            // 
            this.billListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.billColumnAmount,
            this.billColumnName,
            this.billColumnPrice});
            this.billListView.FullRowSelect = true;
            this.billListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.billListView.Location = new System.Drawing.Point(8, 64);
            this.billListView.Name = "billListView";
            this.billListView.Size = new System.Drawing.Size(322, 251);
            this.billListView.TabIndex = 2;
            this.billListView.UseCompatibleStateImageBehavior = false;
            this.billListView.View = System.Windows.Forms.View.Details;
            // 
            // billColumnAmount
            // 
            this.billColumnAmount.Text = "Amount";
            this.billColumnAmount.Width = 70;
            // 
            // billColumnName
            // 
            this.billColumnName.Text = "Name";
            this.billColumnName.Width = 200;
            // 
            // billColumnPrice
            // 
            this.billColumnPrice.Text = "Price";
            this.billColumnPrice.Width = 48;
            // 
            // billTotalText
            // 
            this.billTotalText.AutoSize = true;
            this.billTotalText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.billTotalText.Location = new System.Drawing.Point(8, 324);
            this.billTotalText.Name = "billTotalText";
            this.billTotalText.Size = new System.Drawing.Size(82, 30);
            this.billTotalText.TabIndex = 3;
            this.billTotalText.Text = "TOTAL:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(1)))));
            this.pictureBox2.Location = new System.Drawing.Point(8, 311);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(322, 10);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.billTotalAmountText);
            this.panel1.Controls.Add(this.billTitleText);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.billListView);
            this.panel1.Controls.Add(this.billTotalText);
            this.panel1.Location = new System.Drawing.Point(4, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 360);
            this.panel1.TabIndex = 5;
            // 
            // billTotalAmountText
            // 
            this.billTotalAmountText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.billTotalAmountText.AutoSize = true;
            this.billTotalAmountText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.billTotalAmountText.Location = new System.Drawing.Point(239, 324);
            this.billTotalAmountText.Name = "billTotalAmountText";
            this.billTotalAmountText.Size = new System.Drawing.Size(91, 30);
            this.billTotalAmountText.TabIndex = 5;
            this.billTotalAmountText.Text = "€113.00";
            this.billTotalAmountText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Afrekenen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(346, 517);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Afrekenen";
            this.Text = "Afrekenen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Label billTitleText;
        private ListView billListView;
        private ColumnHeader billColumnAmount;
        private ColumnHeader billColumnName;
        private ColumnHeader billColumnPrice;
        private Label billTotalText;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label billTotalAmountText;
    }
}
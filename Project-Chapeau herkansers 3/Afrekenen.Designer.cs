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
            this.totalVatPriceLabel = new System.Windows.Forms.Label();
            this.vatPriceLabel = new System.Windows.Forms.Label();
            this.billTotalAmountText = new System.Windows.Forms.Label();
            this.btnProceedToPayment = new System.Windows.Forms.Button();
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
            this.billTitleText.Size = new System.Drawing.Size(206, 50);
            this.billTitleText.TabIndex = 1;
            this.billTitleText.Text = "REKENING";
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
            this.billColumnAmount.Text = "Quantiteit";
            this.billColumnAmount.Width = 70;
            // 
            // billColumnName
            // 
            this.billColumnName.Text = "Naam";
            this.billColumnName.Width = 200;
            // 
            // billColumnPrice
            // 
            this.billColumnPrice.Text = "Prijs";
            this.billColumnPrice.Width = 70;
            // 
            // billTotalText
            // 
            this.billTotalText.AutoSize = true;
            this.billTotalText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.billTotalText.Location = new System.Drawing.Point(8, 324);
            this.billTotalText.Name = "billTotalText";
            this.billTotalText.Size = new System.Drawing.Size(97, 30);
            this.billTotalText.TabIndex = 3;
            this.billTotalText.Text = "TOTAAL:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(1)))));
            this.pictureBox2.Location = new System.Drawing.Point(8, 314);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(322, 8);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.totalVatPriceLabel);
            this.panel1.Controls.Add(this.vatPriceLabel);
            this.panel1.Controls.Add(this.billTotalAmountText);
            this.panel1.Controls.Add(this.billTitleText);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.billListView);
            this.panel1.Controls.Add(this.billTotalText);
            this.panel1.Location = new System.Drawing.Point(4, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 378);
            this.panel1.TabIndex = 5;
            // 
            // totalVatPriceLabel
            // 
            this.totalVatPriceLabel.AutoSize = true;
            this.totalVatPriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalVatPriceLabel.Location = new System.Drawing.Point(228, 348);
            this.totalVatPriceLabel.Name = "totalVatPriceLabel";
            this.totalVatPriceLabel.Size = new System.Drawing.Size(49, 21);
            this.totalVatPriceLabel.TabIndex = 7;
            this.totalVatPriceLabel.Text = "€0.00";
            // 
            // vatPriceLabel
            // 
            this.vatPriceLabel.AutoSize = true;
            this.vatPriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vatPriceLabel.Location = new System.Drawing.Point(11, 349);
            this.vatPriceLabel.Name = "vatPriceLabel";
            this.vatPriceLabel.Size = new System.Drawing.Size(44, 21);
            this.vatPriceLabel.TabIndex = 6;
            this.vatPriceLabel.Text = "BTW:";
            // 
            // billTotalAmountText
            // 
            this.billTotalAmountText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.billTotalAmountText.AutoSize = true;
            this.billTotalAmountText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.billTotalAmountText.Location = new System.Drawing.Point(224, 323);
            this.billTotalAmountText.Name = "billTotalAmountText";
            this.billTotalAmountText.Size = new System.Drawing.Size(91, 30);
            this.billTotalAmountText.TabIndex = 5;
            this.billTotalAmountText.Text = "€113.00";
            this.billTotalAmountText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnProceedToPayment
            // 
            this.btnProceedToPayment.BackColor = System.Drawing.Color.Lime;
            this.btnProceedToPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProceedToPayment.Location = new System.Drawing.Point(25, 453);
            this.btnProceedToPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProceedToPayment.Name = "btnProceedToPayment";
            this.btnProceedToPayment.Size = new System.Drawing.Size(290, 42);
            this.btnProceedToPayment.TabIndex = 6;
            this.btnProceedToPayment.Text = "VERDER NAAR BETALING";
            this.btnProceedToPayment.UseVisualStyleBackColor = false;
            this.btnProceedToPayment.Click += new System.EventHandler(this.btnProceedToPayment_Click);
            // 
            // Afrekenen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnProceedToPayment);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Afrekenen";
            this.Size = new System.Drawing.Size(346, 517);
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
        private Label vatPriceLabel;
        private Label totalVatPriceLabel;
        private Button btnProceedToPayment;
    }
}
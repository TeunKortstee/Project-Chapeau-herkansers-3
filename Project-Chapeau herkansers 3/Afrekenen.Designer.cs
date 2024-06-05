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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "2x", "Veal Tartare", "8,50" }, -1);
            pictureBox1 = new PictureBox();
            billTitleText = new Label();
            billListView = new ListView();
            billColumnAmount = new ColumnHeader();
            billColumnName = new ColumnHeader();
            billColumnPrice = new ColumnHeader();
            billTotalText = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            totalVatPriceLabel = new Label();
            vatPriceLabel = new Label();
            billTotalAmountText = new Label();
            btnProceedToPayment = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._13ec534cac352913c97662d176dd3724;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(5, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 52);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // billTitleText
            // 
            billTitleText.AutoSize = true;
            billTitleText.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            billTitleText.Location = new Point(9, 15);
            billTitleText.Name = "billTitleText";
            billTitleText.Size = new Size(120, 62);
            billTitleText.TabIndex = 1;
            billTitleText.Text = "BILL";
            // 
            // billListView
            // 
            billListView.Columns.AddRange(new ColumnHeader[] { billColumnAmount, billColumnName, billColumnPrice });
            billListView.FullRowSelect = true;
            billListView.Items.AddRange(new ListViewItem[] { listViewItem1 });
            billListView.Location = new Point(9, 85);
            billListView.Margin = new Padding(3, 4, 3, 4);
            billListView.Name = "billListView";
            billListView.Size = new Size(367, 333);
            billListView.TabIndex = 2;
            billListView.UseCompatibleStateImageBehavior = false;
            billListView.View = View.Details;
            // 
            // billColumnAmount
            // 
            billColumnAmount.Text = "Amount";
            billColumnAmount.Width = 70;
            // 
            // billColumnName
            // 
            billColumnName.Text = "Name";
            billColumnName.Width = 200;
            // 
            // billColumnPrice
            // 
            billColumnPrice.Text = "Price";
            billColumnPrice.Width = 70;
            // 
            // billTotalText
            // 
            billTotalText.AutoSize = true;
            billTotalText.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            billTotalText.Location = new Point(9, 432);
            billTotalText.Name = "billTotalText";
            billTotalText.Size = new Size(105, 37);
            billTotalText.TabIndex = 3;
            billTotalText.Text = "TOTAL:";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(255, 179, 1);
            pictureBox2.Location = new Point(9, 418);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(368, 10);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(totalVatPriceLabel);
            panel1.Controls.Add(vatPriceLabel);
            panel1.Controls.Add(billTotalAmountText);
            panel1.Controls.Add(billTitleText);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(billListView);
            panel1.Controls.Add(billTotalText);
            panel1.Location = new Point(5, 79);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(387, 504);
            panel1.TabIndex = 5;
            // 
            // totalVatPriceLabel
            // 
            totalVatPriceLabel.AutoSize = true;
            totalVatPriceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            totalVatPriceLabel.Location = new Point(260, 464);
            totalVatPriceLabel.Name = "totalVatPriceLabel";
            totalVatPriceLabel.Size = new Size(60, 28);
            totalVatPriceLabel.TabIndex = 7;
            totalVatPriceLabel.Text = "€0.00";
            // 
            // vatPriceLabel
            // 
            vatPriceLabel.AutoSize = true;
            vatPriceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            vatPriceLabel.Location = new Point(13, 465);
            vatPriceLabel.Name = "vatPriceLabel";
            vatPriceLabel.Size = new Size(49, 28);
            vatPriceLabel.TabIndex = 6;
            vatPriceLabel.Text = "VAT:";
            // 
            // billTotalAmountText
            // 
            billTotalAmountText.Anchor = AnchorStyles.Right;
            billTotalAmountText.AutoSize = true;
            billTotalAmountText.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            billTotalAmountText.Location = new Point(256, 431);
            billTotalAmountText.Name = "billTotalAmountText";
            billTotalAmountText.Size = new Size(120, 37);
            billTotalAmountText.TabIndex = 5;
            billTotalAmountText.Text = "€113.00";
            billTotalAmountText.TextAlign = ContentAlignment.TopRight;
            // 
            // btnProceedToPayment
            // 
            btnProceedToPayment.BackColor = Color.Lime;
            btnProceedToPayment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProceedToPayment.Location = new Point(29, 604);
            btnProceedToPayment.Name = "btnProceedToPayment";
            btnProceedToPayment.Size = new Size(331, 56);
            btnProceedToPayment.TabIndex = 6;
            btnProceedToPayment.Text = "PROCEED TO PAYMENT";
            btnProceedToPayment.UseVisualStyleBackColor = false;
            btnProceedToPayment.Click += btnProceedToPayment_Click;
            // 
            // Afrekenen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnProceedToPayment);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Afrekenen";
            Size = new Size(395, 689);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
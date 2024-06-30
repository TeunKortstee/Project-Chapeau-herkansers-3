namespace Project_Chapeau_herkansers_3.UserControls
{
    partial class UserControlVoorraad
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
            btnReturn = new Button();
            lblSales = new Label();
            lsvStockItems = new ListView();
            btnAdjustStock = new Button();
            lblErrorStock = new Label();
            btnOption3 = new Button();
            btnOption2 = new Button();
            btnOption1 = new Button();
            lblKitchen = new Label();
            lblBar = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.FromArgb(255, 179, 71);
            btnReturn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.Location = new Point(328, 30);
            btnReturn.Margin = new Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(68, 48);
            btnReturn.TabIndex = 39;
            btnReturn.Text = "Terug";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // lblSales
            // 
            lblSales.AutoSize = true;
            lblSales.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblSales.Location = new Point(120, 24);
            lblSales.Name = "lblSales";
            lblSales.Size = new Size(168, 46);
            lblSales.TabIndex = 38;
            lblSales.Text = "Voorraad";
            // 
            // lsvStockItems
            // 
            lsvStockItems.FullRowSelect = true;
            lsvStockItems.Location = new Point(14, 233);
            lsvStockItems.Margin = new Padding(3, 4, 3, 4);
            lsvStockItems.MultiSelect = false;
            lsvStockItems.Name = "lsvStockItems";
            lsvStockItems.Size = new Size(380, 380);
            lsvStockItems.TabIndex = 37;
            lsvStockItems.UseCompatibleStateImageBehavior = false;
            lsvStockItems.View = View.Details;
            // 
            // btnAdjustStock
            // 
            btnAdjustStock.BackColor = Color.FromArgb(138, 210, 176);
            btnAdjustStock.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdjustStock.Location = new Point(13, 646);
            btnAdjustStock.Margin = new Padding(3, 4, 3, 4);
            btnAdjustStock.Name = "btnAdjustStock";
            btnAdjustStock.Size = new Size(120, 52);
            btnAdjustStock.TabIndex = 43;
            btnAdjustStock.Text = "Aanpassen";
            btnAdjustStock.UseVisualStyleBackColor = false;
            btnAdjustStock.Click += btnAdjustStock_Click;
            // 
            // lblErrorStock
            // 
            lblErrorStock.AutoSize = true;
            lblErrorStock.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrorStock.ForeColor = Color.Red;
            lblErrorStock.Location = new Point(16, 617);
            lblErrorStock.Name = "lblErrorStock";
            lblErrorStock.Size = new Size(120, 25);
            lblErrorStock.TabIndex = 44;
            lblErrorStock.Text = "Error Bericht";
            lblErrorStock.Visible = false;
            // 
            // btnOption3
            // 
            btnOption3.BackColor = Color.FromArgb(138, 210, 176);
            btnOption3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOption3.Location = new Point(271, 176);
            btnOption3.Name = "btnOption3";
            btnOption3.Size = new Size(123, 50);
            btnOption3.TabIndex = 47;
            btnOption3.Text = "Drank";
            btnOption3.UseVisualStyleBackColor = false;
            btnOption3.Click += btnOption3_Click;
            // 
            // btnOption2
            // 
            btnOption2.BackColor = Color.FromArgb(138, 210, 176);
            btnOption2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOption2.Location = new Point(142, 176);
            btnOption2.Name = "btnOption2";
            btnOption2.Size = new Size(123, 50);
            btnOption2.TabIndex = 46;
            btnOption2.Text = "Diner";
            btnOption2.UseVisualStyleBackColor = false;
            btnOption2.Click += btnOption2_Click;
            // 
            // btnOption1
            // 
            btnOption1.BackColor = Color.FromArgb(138, 210, 176);
            btnOption1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOption1.Location = new Point(13, 176);
            btnOption1.Name = "btnOption1";
            btnOption1.Size = new Size(123, 50);
            btnOption1.TabIndex = 45;
            btnOption1.Text = "Lunch";
            btnOption1.UseVisualStyleBackColor = false;
            btnOption1.Click += btnOption1_Click;
            // 
            // lblKitchen
            // 
            lblKitchen.AutoSize = true;
            lblKitchen.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblKitchen.Location = new Point(83, 118);
            lblKitchen.Name = "lblKitchen";
            lblKitchen.Size = new Size(122, 41);
            lblKitchen.TabIndex = 48;
            lblKitchen.Text = "Keuken";
            // 
            // lblBar
            // 
            lblBar.AutoSize = true;
            lblBar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblBar.Location = new Point(299, 118);
            lblBar.Name = "lblBar";
            lblBar.Size = new Size(65, 41);
            lblBar.TabIndex = 48;
            lblBar.Text = "Bar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(270, 132);
            label2.Name = "label2";
            label2.Size = new Size(126, 41);
            label2.TabIndex = 49;
            label2.Text = "_________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 132);
            label1.Name = "label1";
            label1.Size = new Size(258, 41);
            label1.TabIndex = 50;
            label1.Text = "____________________";
            // 
            // UserControlVoorraad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblBar);
            Controls.Add(lblKitchen);
            Controls.Add(btnOption3);
            Controls.Add(btnOption2);
            Controls.Add(btnOption1);
            Controls.Add(lblErrorStock);
            Controls.Add(btnAdjustStock);
            Controls.Add(btnReturn);
            Controls.Add(lblSales);
            Controls.Add(lsvStockItems);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserControlVoorraad";
            Size = new Size(414, 736);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnReturn;
        private Label lblSales;
        private ListView lsvStockItems;
        private Button btnAdjustStock;
        private Label lblErrorStock;
        private Button btnOption3;
        private Button btnOption2;
        private Button btnOption1;
        private Label lblKitchen;
        private Label lblBar;
        private Label label2;
        private Label label1;
    }
}

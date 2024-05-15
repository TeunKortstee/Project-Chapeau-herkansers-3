namespace Project_Chapeau_herkansers_3
{
    partial class OpnemenBestellen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpnemenBestellen));
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("");
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSelectedTable = new System.Windows.Forms.Label();
            this.btnGebruiker = new System.Windows.Forms.Button();
            this.btnLunchKaart = new System.Windows.Forms.Button();
            this.btnDinerKaart = new System.Windows.Forms.Button();
            this.btnDrankKaart = new System.Windows.Forms.Button();
            this.listViewKaart = new System.Windows.Forms.ListView();
            this.columnHeaderNaam = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPrijs = new System.Windows.Forms.ColumnHeader();
            this.btnToevoegenBestelling = new System.Windows.Forms.Button();
            this.columnHeaderVoorraad = new System.Windows.Forms.ColumnHeader();
            this.labelBestelling = new System.Windows.Forms.Label();
            this.listViewBestelling = new System.Windows.Forms.ListView();
            this.columnHeaderNaamBestelling = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPrijsBestelling = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderComment = new System.Windows.Forms.ColumnHeader();
            this.btnVerwijderEen = new System.Windows.Forms.Button();
            this.btnVerwijderAlles = new System.Windows.Forms.Button();
            this.btnRijVerwijderen = new System.Windows.Forms.Button();
            this.btnComment = new System.Windows.Forms.Button();
            this.btnAfrekenen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 66);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelSelectedTable
            // 
            this.labelSelectedTable.AutoSize = true;
            this.labelSelectedTable.BackColor = System.Drawing.Color.Transparent;
            this.labelSelectedTable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSelectedTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.labelSelectedTable.Location = new System.Drawing.Point(139, 14);
            this.labelSelectedTable.Name = "labelSelectedTable";
            this.labelSelectedTable.Size = new System.Drawing.Size(145, 46);
            this.labelSelectedTable.TabIndex = 1;
            this.labelSelectedTable.Text = "Tafel #1";
            // 
            // btnGebruiker
            // 
            this.btnGebruiker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(71)))));
            this.btnGebruiker.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGebruiker.Location = new System.Drawing.Point(310, 12);
            this.btnGebruiker.Name = "btnGebruiker";
            this.btnGebruiker.Size = new System.Drawing.Size(86, 40);
            this.btnGebruiker.TabIndex = 2;
            this.btnGebruiker.Text = "Marlene";
            this.btnGebruiker.UseVisualStyleBackColor = false;
            this.btnGebruiker.Click += new System.EventHandler(this.btnGebruiker_Click);
            // 
            // btnLunchKaart
            // 
            this.btnLunchKaart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(210)))), ((int)(((byte)(176)))));
            this.btnLunchKaart.Location = new System.Drawing.Point(16, 83);
            this.btnLunchKaart.Name = "btnLunchKaart";
            this.btnLunchKaart.Size = new System.Drawing.Size(90, 50);
            this.btnLunchKaart.TabIndex = 3;
            this.btnLunchKaart.Text = "LUNCH";
            this.btnLunchKaart.UseVisualStyleBackColor = false;
            this.btnLunchKaart.Click += new System.EventHandler(this.btnLunchKaart_Click);
            // 
            // btnDinerKaart
            // 
            this.btnDinerKaart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(210)))), ((int)(((byte)(176)))));
            this.btnDinerKaart.Location = new System.Drawing.Point(158, 83);
            this.btnDinerKaart.Name = "btnDinerKaart";
            this.btnDinerKaart.Size = new System.Drawing.Size(90, 50);
            this.btnDinerKaart.TabIndex = 4;
            this.btnDinerKaart.Text = "DINER";
            this.btnDinerKaart.UseVisualStyleBackColor = false;
            this.btnDinerKaart.Click += new System.EventHandler(this.btnDinerKaart_Click);
            // 
            // btnDrankKaart
            // 
            this.btnDrankKaart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(210)))), ((int)(((byte)(176)))));
            this.btnDrankKaart.Location = new System.Drawing.Point(300, 83);
            this.btnDrankKaart.Name = "btnDrankKaart";
            this.btnDrankKaart.Size = new System.Drawing.Size(90, 50);
            this.btnDrankKaart.TabIndex = 5;
            this.btnDrankKaart.Text = "DRANKEN";
            this.btnDrankKaart.UseVisualStyleBackColor = false;
            this.btnDrankKaart.Click += new System.EventHandler(this.btnDrankKaart_Click);
            // 
            // listViewKaart
            // 
            this.listViewKaart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNaam,
            this.columnHeaderPrijs,
            this.columnHeaderVoorraad});
            this.listViewKaart.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem10});
            this.listViewKaart.Location = new System.Drawing.Point(16, 153);
            this.listViewKaart.Name = "listViewKaart";
            this.listViewKaart.Size = new System.Drawing.Size(374, 309);
            this.listViewKaart.TabIndex = 6;
            this.listViewKaart.UseCompatibleStateImageBehavior = false;
            this.listViewKaart.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNaam
            // 
            this.columnHeaderNaam.Text = "Naam";
            this.columnHeaderNaam.Width = 250;
            // 
            // columnHeaderPrijs
            // 
            this.columnHeaderPrijs.Text = "prijs";
            // 
            // btnToevoegenBestelling
            // 
            this.btnToevoegenBestelling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(71)))));
            this.btnToevoegenBestelling.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnToevoegenBestelling.Location = new System.Drawing.Point(16, 468);
            this.btnToevoegenBestelling.Name = "btnToevoegenBestelling";
            this.btnToevoegenBestelling.Size = new System.Drawing.Size(374, 50);
            this.btnToevoegenBestelling.TabIndex = 9;
            this.btnToevoegenBestelling.Text = "TOEVOEGEN BESTELLING";
            this.btnToevoegenBestelling.UseVisualStyleBackColor = false;
            this.btnToevoegenBestelling.Click += new System.EventHandler(this.btnToevoegenBestelling_Click);
            // 
            // columnHeaderVoorraad
            // 
            this.columnHeaderVoorraad.Text = "Voorraad";
            // 
            // labelBestelling
            // 
            this.labelBestelling.AutoSize = true;
            this.labelBestelling.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBestelling.Location = new System.Drawing.Point(16, 536);
            this.labelBestelling.Name = "labelBestelling";
            this.labelBestelling.Size = new System.Drawing.Size(146, 38);
            this.labelBestelling.TabIndex = 10;
            this.labelBestelling.Text = "Bestelling";
            // 
            // listViewBestelling
            // 
            this.listViewBestelling.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNaamBestelling,
            this.columnHeaderPrijsBestelling,
            this.columnHeaderComment});
            this.listViewBestelling.Location = new System.Drawing.Point(16, 584);
            this.listViewBestelling.Name = "listViewBestelling";
            this.listViewBestelling.Size = new System.Drawing.Size(374, 309);
            this.listViewBestelling.TabIndex = 11;
            this.listViewBestelling.UseCompatibleStateImageBehavior = false;
            this.listViewBestelling.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNaamBestelling
            // 
            this.columnHeaderNaamBestelling.Text = "Naam";
            this.columnHeaderNaamBestelling.Width = 225;
            // 
            // columnHeaderPrijsBestelling
            // 
            this.columnHeaderPrijsBestelling.Text = "Prijs";
            // 
            // columnHeaderComment
            // 
            this.columnHeaderComment.Text = "Comment";
            this.columnHeaderComment.Width = 100;
            // 
            // btnVerwijderEen
            // 
            this.btnVerwijderEen.Location = new System.Drawing.Point(16, 918);
            this.btnVerwijderEen.Name = "btnVerwijderEen";
            this.btnVerwijderEen.Size = new System.Drawing.Size(100, 50);
            this.btnVerwijderEen.TabIndex = 12;
            this.btnVerwijderEen.Text = "Verwijder 1";
            this.btnVerwijderEen.UseVisualStyleBackColor = true;
            this.btnVerwijderEen.Click += new System.EventHandler(this.btnVerwijderEen_Click);
            // 
            // btnVerwijderAlles
            // 
            this.btnVerwijderAlles.Location = new System.Drawing.Point(122, 918);
            this.btnVerwijderAlles.Name = "btnVerwijderAlles";
            this.btnVerwijderAlles.Size = new System.Drawing.Size(144, 50);
            this.btnVerwijderAlles.TabIndex = 13;
            this.btnVerwijderAlles.Text = "Alles verwijderen";
            this.btnVerwijderAlles.UseVisualStyleBackColor = true;
            this.btnVerwijderAlles.Click += new System.EventHandler(this.btnVerwijderAlles_Click);
            // 
            // btnRijVerwijderen
            // 
            this.btnRijVerwijderen.Location = new System.Drawing.Point(271, 918);
            this.btnRijVerwijderen.Name = "btnRijVerwijderen";
            this.btnRijVerwijderen.Size = new System.Drawing.Size(119, 50);
            this.btnRijVerwijderen.TabIndex = 14;
            this.btnRijVerwijderen.Text = "Rij Verwijderen";
            this.btnRijVerwijderen.UseVisualStyleBackColor = true;
            this.btnRijVerwijderen.Click += new System.EventHandler(this.btnRijVerwijderen_Click);
            // 
            // btnComment
            // 
            this.btnComment.Location = new System.Drawing.Point(281, 543);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(109, 35);
            this.btnComment.TabIndex = 15;
            this.btnComment.Text = "Comment";
            this.btnComment.UseVisualStyleBackColor = true;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // btnAfrekenen
            // 
            this.btnAfrekenen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(71)))));
            this.btnAfrekenen.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAfrekenen.Location = new System.Drawing.Point(16, 984);
            this.btnAfrekenen.Name = "btnAfrekenen";
            this.btnAfrekenen.Size = new System.Drawing.Size(374, 50);
            this.btnAfrekenen.TabIndex = 16;
            this.btnAfrekenen.Text = "Afrekenen";
            this.btnAfrekenen.UseVisualStyleBackColor = false;
            this.btnAfrekenen.Click += new System.EventHandler(this.btnAfrekenen_Click);
            // 
            // OpnemenBestellen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnAfrekenen);
            this.Controls.Add(this.btnComment);
            this.Controls.Add(this.btnRijVerwijderen);
            this.Controls.Add(this.btnVerwijderAlles);
            this.Controls.Add(this.btnVerwijderEen);
            this.Controls.Add(this.listViewBestelling);
            this.Controls.Add(this.labelBestelling);
            this.Controls.Add(this.btnToevoegenBestelling);
            this.Controls.Add(this.listViewKaart);
            this.Controls.Add(this.btnDrankKaart);
            this.Controls.Add(this.btnDinerKaart);
            this.Controls.Add(this.btnLunchKaart);
            this.Controls.Add(this.btnGebruiker);
            this.Controls.Add(this.labelSelectedTable);
            this.Controls.Add(this.pictureBox1);
            this.Name = "OpnemenBestellen";
            this.Size = new System.Drawing.Size(414, 1060);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelSelectedTable;
        private Button btnGebruiker;
        private Button btnLunchKaart;
        private Button btnDinerKaart;
        private Button btnDrankKaart;
        private ListView listViewKaart;
        private ColumnHeader columnHeaderNaam;
        private ColumnHeader columnHeaderPrijs;
        private ColumnHeader columnHeaderVoorraad;
        private Button btnToevoegenBestelling;
        private Label labelBestelling;
        private ListView listViewBestelling;
        private ColumnHeader columnHeaderNaamBestelling;
        private ColumnHeader columnHeaderPrijsBestelling;
        private ColumnHeader columnHeaderComment;
        private Button btnVerwijderEen;
        private Button btnVerwijderAlles;
        private Button btnRijVerwijderen;
        private Button btnComment;
        private Button btnAfrekenen;
    }
}

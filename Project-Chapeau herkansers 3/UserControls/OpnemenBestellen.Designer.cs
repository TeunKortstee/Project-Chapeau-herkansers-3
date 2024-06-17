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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSelectedTafel = new System.Windows.Forms.Label();
            this.btnLunchKaart = new System.Windows.Forms.Button();
            this.btnDinerKaart = new System.Windows.Forms.Button();
            this.btnDrankKaart = new System.Windows.Forms.Button();
            this.listViewKaart = new System.Windows.Forms.ListView();
            this.columnHeaderNaam = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPrijs = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderVoorraad = new System.Windows.Forms.ColumnHeader();
            this.btnToevoegenBestelling = new System.Windows.Forms.Button();
            this.labelBestelling = new System.Windows.Forms.Label();
            this.listViewBestelling = new System.Windows.Forms.ListView();
            this.columnHeaderNaamBestelling = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderPrijsBestelling = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderComment = new System.Windows.Forms.ColumnHeader();
            this.btnVerwijderEen = new System.Windows.Forms.Button();
            this.btnVerwijderAlles = new System.Windows.Forms.Button();
            this.btnRijVerwijderen = new System.Windows.Forms.Button();
            this.btnOpmerking = new System.Windows.Forms.Button();
            this.btnAfrekenen = new System.Windows.Forms.Button();
            this.txtOpmerking = new System.Windows.Forms.TextBox();
            this.btnToevoegenEen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelSelectedTafel
            // 
            this.labelSelectedTafel.AutoSize = true;
            this.labelSelectedTafel.BackColor = System.Drawing.Color.Transparent;
            this.labelSelectedTafel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSelectedTafel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.labelSelectedTafel.Location = new System.Drawing.Point(122, 10);
            this.labelSelectedTafel.Name = "labelSelectedTafel";
            this.labelSelectedTafel.Size = new System.Drawing.Size(118, 37);
            this.labelSelectedTafel.TabIndex = 1;
            this.labelSelectedTafel.Text = "Tafel #1";
            // 
            // btnLunchKaart
            // 
            this.btnLunchKaart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(210)))), ((int)(((byte)(176)))));
            this.btnLunchKaart.Location = new System.Drawing.Point(14, 62);
            this.btnLunchKaart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLunchKaart.Name = "btnLunchKaart";
            this.btnLunchKaart.Size = new System.Drawing.Size(79, 38);
            this.btnLunchKaart.TabIndex = 3;
            this.btnLunchKaart.Text = "LUNCH";
            this.btnLunchKaart.UseVisualStyleBackColor = false;
            this.btnLunchKaart.Click += new System.EventHandler(this.btnLunchKaart_Click);
            // 
            // btnDinerKaart
            // 
            this.btnDinerKaart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(210)))), ((int)(((byte)(176)))));
            this.btnDinerKaart.Location = new System.Drawing.Point(138, 62);
            this.btnDinerKaart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDinerKaart.Name = "btnDinerKaart";
            this.btnDinerKaart.Size = new System.Drawing.Size(79, 38);
            this.btnDinerKaart.TabIndex = 4;
            this.btnDinerKaart.Text = "DINER";
            this.btnDinerKaart.UseVisualStyleBackColor = false;
            this.btnDinerKaart.Click += new System.EventHandler(this.btnDinerKaart_Click);
            // 
            // btnDrankKaart
            // 
            this.btnDrankKaart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(210)))), ((int)(((byte)(176)))));
            this.btnDrankKaart.Location = new System.Drawing.Point(262, 62);
            this.btnDrankKaart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDrankKaart.Name = "btnDrankKaart";
            this.btnDrankKaart.Size = new System.Drawing.Size(79, 38);
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
            listViewItem1});
            this.listViewKaart.Location = new System.Drawing.Point(14, 115);
            this.listViewKaart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewKaart.Name = "listViewKaart";
            this.listViewKaart.Size = new System.Drawing.Size(328, 233);
            this.listViewKaart.TabIndex = 6;
            this.listViewKaart.UseCompatibleStateImageBehavior = false;
            this.listViewKaart.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNaam
            // 
            this.columnHeaderNaam.Text = "Naam";
            this.columnHeaderNaam.Width = 210;
            // 
            // columnHeaderPrijs
            // 
            this.columnHeaderPrijs.Text = "prijs";
            // 
            // columnHeaderVoorraad
            // 
            this.columnHeaderVoorraad.Text = "Voorraad";
            this.columnHeaderVoorraad.Width = 100;
            // 
            // btnToevoegenBestelling
            // 
            this.btnToevoegenBestelling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(71)))));
            this.btnToevoegenBestelling.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnToevoegenBestelling.Location = new System.Drawing.Point(14, 351);
            this.btnToevoegenBestelling.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnToevoegenBestelling.Name = "btnToevoegenBestelling";
            this.btnToevoegenBestelling.Size = new System.Drawing.Size(327, 38);
            this.btnToevoegenBestelling.TabIndex = 9;
            this.btnToevoegenBestelling.Text = "TOEVOEGEN BESTELLING";
            this.btnToevoegenBestelling.UseVisualStyleBackColor = false;
            this.btnToevoegenBestelling.Click += new System.EventHandler(this.btnToevoegenBestelling_Click);
            // 
            // labelBestelling
            // 
            this.labelBestelling.AutoSize = true;
            this.labelBestelling.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBestelling.Location = new System.Drawing.Point(14, 402);
            this.labelBestelling.Name = "labelBestelling";
            this.labelBestelling.Size = new System.Drawing.Size(115, 30);
            this.labelBestelling.TabIndex = 10;
            this.labelBestelling.Text = "Bestelling";
            // 
            // listViewBestelling
            // 
            this.listViewBestelling.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNaamBestelling,
            this.columnHeaderPrijsBestelling,
            this.columnHeaderComment});
            this.listViewBestelling.Location = new System.Drawing.Point(14, 438);
            this.listViewBestelling.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewBestelling.Name = "listViewBestelling";
            this.listViewBestelling.Size = new System.Drawing.Size(328, 233);
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
            this.btnVerwijderEen.BackColor = System.Drawing.Color.LightGray;
            this.btnVerwijderEen.Location = new System.Drawing.Point(14, 674);
            this.btnVerwijderEen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerwijderEen.Name = "btnVerwijderEen";
            this.btnVerwijderEen.Size = new System.Drawing.Size(88, 38);
            this.btnVerwijderEen.TabIndex = 12;
            this.btnVerwijderEen.Text = "Verwijder 1";
            this.btnVerwijderEen.UseVisualStyleBackColor = false;
            this.btnVerwijderEen.Click += new System.EventHandler(this.btnVerwijderEen_Click);
            // 
            // btnVerwijderAlles
            // 
            this.btnVerwijderAlles.BackColor = System.Drawing.Color.LightGray;
            this.btnVerwijderAlles.Location = new System.Drawing.Point(215, 406);
            this.btnVerwijderAlles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerwijderAlles.Name = "btnVerwijderAlles";
            this.btnVerwijderAlles.Size = new System.Drawing.Size(126, 28);
            this.btnVerwijderAlles.TabIndex = 13;
            this.btnVerwijderAlles.Text = "Alles verwijderen";
            this.btnVerwijderAlles.UseVisualStyleBackColor = false;
            this.btnVerwijderAlles.Click += new System.EventHandler(this.btnVerwijderAlles_Click);
            // 
            // btnRijVerwijderen
            // 
            this.btnRijVerwijderen.BackColor = System.Drawing.Color.LightGray;
            this.btnRijVerwijderen.Location = new System.Drawing.Point(237, 674);
            this.btnRijVerwijderen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRijVerwijderen.Name = "btnRijVerwijderen";
            this.btnRijVerwijderen.Size = new System.Drawing.Size(104, 38);
            this.btnRijVerwijderen.TabIndex = 14;
            this.btnRijVerwijderen.Text = "Rij Verwijderen";
            this.btnRijVerwijderen.UseVisualStyleBackColor = false;
            this.btnRijVerwijderen.Click += new System.EventHandler(this.btnRijVerwijderen_Click);
            // 
            // btnOpmerking
            // 
            this.btnOpmerking.BackColor = System.Drawing.Color.LightGray;
            this.btnOpmerking.Location = new System.Drawing.Point(14, 716);
            this.btnOpmerking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpmerking.Name = "btnOpmerking";
            this.btnOpmerking.Size = new System.Drawing.Size(95, 26);
            this.btnOpmerking.TabIndex = 15;
            this.btnOpmerking.Text = "Opmerking";
            this.btnOpmerking.UseVisualStyleBackColor = false;
            this.btnOpmerking.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // btnAfrekenen
            // 
            this.btnAfrekenen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(71)))));
            this.btnAfrekenen.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAfrekenen.Location = new System.Drawing.Point(14, 747);
            this.btnAfrekenen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAfrekenen.Name = "btnAfrekenen";
            this.btnAfrekenen.Size = new System.Drawing.Size(327, 38);
            this.btnAfrekenen.TabIndex = 16;
            this.btnAfrekenen.Text = "Bestelling afronden";
            this.btnAfrekenen.UseVisualStyleBackColor = false;
            this.btnAfrekenen.Click += new System.EventHandler(this.btnAfrekenen_Click);
            // 
            // txtOpmerking
            // 
            this.txtOpmerking.Location = new System.Drawing.Point(115, 719);
            this.txtOpmerking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOpmerking.Name = "txtOpmerking";
            this.txtOpmerking.Size = new System.Drawing.Size(227, 23);
            this.txtOpmerking.TabIndex = 17;
            // 
            // btnToevoegenEen
            // 
            this.btnToevoegenEen.BackColor = System.Drawing.Color.LightGray;
            this.btnToevoegenEen.Location = new System.Drawing.Point(122, 674);
            this.btnToevoegenEen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnToevoegenEen.Name = "btnToevoegenEen";
            this.btnToevoegenEen.Size = new System.Drawing.Size(104, 38);
            this.btnToevoegenEen.TabIndex = 18;
            this.btnToevoegenEen.Text = "Toevoegen 1";
            this.btnToevoegenEen.UseVisualStyleBackColor = false;
            this.btnToevoegenEen.Click += new System.EventHandler(this.btnToevoegenEen_Click);
            // 
            // OpnemenBestellen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnToevoegenEen);
            this.Controls.Add(this.txtOpmerking);
            this.Controls.Add(this.btnAfrekenen);
            this.Controls.Add(this.btnOpmerking);
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
            this.Controls.Add(this.labelSelectedTafel);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OpnemenBestellen";
            this.Size = new System.Drawing.Size(362, 795);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelSelectedTafel;
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
        private Button btnOpmerking;
        private Button btnAfrekenen;
        private TextBox txtOpmerking;
        private Button btnToevoegenEen;
    }
}

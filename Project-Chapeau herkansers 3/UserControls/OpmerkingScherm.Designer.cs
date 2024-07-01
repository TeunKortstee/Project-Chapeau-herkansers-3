namespace Project_Chapeau_herkansers_3.UserControls
{
    partial class OpmerkingScherm
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
            this.anyCommentsLbl = new System.Windows.Forms.Label();
            this.btnAddComment = new System.Windows.Forms.Button();
            this.btnContinuePayment = new System.Windows.Forms.Button();
            this.panelVoegOpmerkingToe = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.labelFeedback = new System.Windows.Forms.Label();
            this.btnConfirmComment = new System.Windows.Forms.Button();
            this.inputOpmerkingen = new System.Windows.Forms.TextBox();
            this.lblTypeComment = new System.Windows.Forms.Label();
            this.panelVoegOpmerkingToe.SuspendLayout();
            this.SuspendLayout();
            // 
            // anyCommentsLbl
            // 
            this.anyCommentsLbl.AutoSize = true;
            this.anyCommentsLbl.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.anyCommentsLbl.Location = new System.Drawing.Point(45, 208);
            this.anyCommentsLbl.Name = "anyCommentsLbl";
            this.anyCommentsLbl.Size = new System.Drawing.Size(326, 40);
            this.anyCommentsLbl.TabIndex = 0;
            this.anyCommentsLbl.Text = "Heeft u opmerkingen?";
            // 
            // btnAddComment
            // 
            this.btnAddComment.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAddComment.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddComment.Location = new System.Drawing.Point(45, 274);
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.Size = new System.Drawing.Size(323, 56);
            this.btnAddComment.TabIndex = 1;
            this.btnAddComment.Text = "VOEG EEN OPMERKING TOE";
            this.btnAddComment.UseVisualStyleBackColor = false;
            this.btnAddComment.Click += new System.EventHandler(this.btnAddComment_Click);
            // 
            // btnContinuePayment
            // 
            this.btnContinuePayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnContinuePayment.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnContinuePayment.Location = new System.Drawing.Point(45, 347);
            this.btnContinuePayment.Name = "btnContinuePayment";
            this.btnContinuePayment.Size = new System.Drawing.Size(323, 56);
            this.btnContinuePayment.TabIndex = 2;
            this.btnContinuePayment.Text = "VERDER MET BETALING";
            this.btnContinuePayment.UseVisualStyleBackColor = false;
            this.btnContinuePayment.Click += new System.EventHandler(this.btnContinuePayment_Click);
            // 
            // panelAddComment
            // 
            this.panelVoegOpmerkingToe.Controls.Add(this.btnBack);
            this.panelVoegOpmerkingToe.Controls.Add(this.labelFeedback);
            this.panelVoegOpmerkingToe.Controls.Add(this.btnConfirmComment);
            this.panelVoegOpmerkingToe.Controls.Add(this.inputOpmerkingen);
            this.panelVoegOpmerkingToe.Controls.Add(this.lblTypeComment);
            this.panelVoegOpmerkingToe.Location = new System.Drawing.Point(39, 118);
            this.panelVoegOpmerkingToe.Name = "panelAddComment";
            this.panelVoegOpmerkingToe.Size = new System.Drawing.Size(332, 404);
            this.panelVoegOpmerkingToe.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SandyBrown;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(265, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(62, 28);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "TERUG";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblSaved
            // 
            this.labelFeedback.AutoSize = true;
            this.labelFeedback.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFeedback.Location = new System.Drawing.Point(24, 356);
            this.labelFeedback.Name = "lblSaved";
            this.labelFeedback.Size = new System.Drawing.Size(0, 20);
            this.labelFeedback.TabIndex = 3;
            // 
            // btnConfirmComment
            // 
            this.btnConfirmComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnConfirmComment.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmComment.Location = new System.Drawing.Point(24, 311);
            this.btnConfirmComment.Name = "btnConfirmComment";
            this.btnConfirmComment.Size = new System.Drawing.Size(281, 34);
            this.btnConfirmComment.TabIndex = 2;
            this.btnConfirmComment.Text = "VOEG TOE";
            this.btnConfirmComment.UseVisualStyleBackColor = false;
            this.btnConfirmComment.Click += new System.EventHandler(this.btnConfirmComment_Click);
            // 
            // inputComment
            // 
            this.inputOpmerkingen.Location = new System.Drawing.Point(24, 67);
            this.inputOpmerkingen.Multiline = true;
            this.inputOpmerkingen.Name = "inputComment";
            this.inputOpmerkingen.Size = new System.Drawing.Size(281, 235);
            this.inputOpmerkingen.TabIndex = 1;
            // 
            // lblTypeComment
            // 
            this.lblTypeComment.AutoSize = true;
            this.lblTypeComment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTypeComment.Location = new System.Drawing.Point(24, 37);
            this.lblTypeComment.Name = "lblTypeComment";
            this.lblTypeComment.Size = new System.Drawing.Size(182, 21);
            this.lblTypeComment.TabIndex = 0;
            this.lblTypeComment.Text = "TYP OPMERKING HIER:";
            // 
            // CommentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelVoegOpmerkingToe);
            this.Controls.Add(this.btnContinuePayment);
            this.Controls.Add(this.btnAddComment);
            this.Controls.Add(this.anyCommentsLbl);
            this.Name = "CommentScreen";
            this.Size = new System.Drawing.Size(407, 631);
            this.panelVoegOpmerkingToe.ResumeLayout(false);
            this.panelVoegOpmerkingToe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label anyCommentsLbl;
        private Button btnAddComment;
        private Button btnContinuePayment;
        private Panel panelVoegOpmerkingToe;
        private Button btnConfirmComment;
        private TextBox inputOpmerkingen;
        private Label lblTypeComment;
        private Label labelFeedback;
        private Button btnBack;
    }
}

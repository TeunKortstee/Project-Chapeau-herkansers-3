namespace Project_Chapeau_herkansers_3.UserControls
{
    partial class CommentScreen
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
            this.panelAddComment = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblSaved = new System.Windows.Forms.Label();
            this.btnConfirmComment = new System.Windows.Forms.Button();
            this.inputComment = new System.Windows.Forms.TextBox();
            this.lblTypeComment = new System.Windows.Forms.Label();
            this.panelAddComment.SuspendLayout();
            this.SuspendLayout();
            // 
            // anyCommentsLbl
            // 
            this.anyCommentsLbl.AutoSize = true;
            this.anyCommentsLbl.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.anyCommentsLbl.Location = new System.Drawing.Point(60, 208);
            this.anyCommentsLbl.Name = "anyCommentsLbl";
            this.anyCommentsLbl.Size = new System.Drawing.Size(297, 50);
            this.anyCommentsLbl.TabIndex = 0;
            this.anyCommentsLbl.Text = "Any comments?";
            // 
            // btnAddComment
            // 
            this.btnAddComment.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAddComment.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddComment.Location = new System.Drawing.Point(45, 274);
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.Size = new System.Drawing.Size(323, 56);
            this.btnAddComment.TabIndex = 1;
            this.btnAddComment.Text = "ADD A COMMENT";
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
            this.btnContinuePayment.Text = "CONTINUE WITH PAYMENT";
            this.btnContinuePayment.UseVisualStyleBackColor = false;
            this.btnContinuePayment.Click += new System.EventHandler(this.btnContinuePayment_Click);
            // 
            // panelAddComment
            // 
            this.panelAddComment.Controls.Add(this.btnBack);
            this.panelAddComment.Controls.Add(this.lblSaved);
            this.panelAddComment.Controls.Add(this.btnConfirmComment);
            this.panelAddComment.Controls.Add(this.inputComment);
            this.panelAddComment.Controls.Add(this.lblTypeComment);
            this.panelAddComment.Location = new System.Drawing.Point(36, 122);
            this.panelAddComment.Name = "panelAddComment";
            this.panelAddComment.Size = new System.Drawing.Size(332, 404);
            this.panelAddComment.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SandyBrown;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(265, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(62, 28);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblSaved
            // 
            this.lblSaved.AutoSize = true;
            this.lblSaved.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaved.Location = new System.Drawing.Point(24, 356);
            this.lblSaved.Name = "lblSaved";
            this.lblSaved.Size = new System.Drawing.Size(0, 20);
            this.lblSaved.TabIndex = 3;
            // 
            // btnConfirmComment
            // 
            this.btnConfirmComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnConfirmComment.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmComment.Location = new System.Drawing.Point(24, 311);
            this.btnConfirmComment.Name = "btnConfirmComment";
            this.btnConfirmComment.Size = new System.Drawing.Size(281, 34);
            this.btnConfirmComment.TabIndex = 2;
            this.btnConfirmComment.Text = "CONFIRM";
            this.btnConfirmComment.UseVisualStyleBackColor = false;
            this.btnConfirmComment.Click += new System.EventHandler(this.btnConfirmComment_Click);
            // 
            // inputComment
            // 
            this.inputComment.Location = new System.Drawing.Point(24, 67);
            this.inputComment.Multiline = true;
            this.inputComment.Name = "inputComment";
            this.inputComment.Size = new System.Drawing.Size(281, 235);
            this.inputComment.TabIndex = 1;
            // 
            // lblTypeComment
            // 
            this.lblTypeComment.AutoSize = true;
            this.lblTypeComment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTypeComment.Location = new System.Drawing.Point(24, 37);
            this.lblTypeComment.Name = "lblTypeComment";
            this.lblTypeComment.Size = new System.Drawing.Size(281, 21);
            this.lblTypeComment.TabIndex = 0;
            this.lblTypeComment.Text = "TYPE CUSTOMERS COMMENT HERE:";
            // 
            // CommentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelAddComment);
            this.Controls.Add(this.btnContinuePayment);
            this.Controls.Add(this.btnAddComment);
            this.Controls.Add(this.anyCommentsLbl);
            this.Name = "CommentScreen";
            this.Size = new System.Drawing.Size(407, 631);
            this.panelAddComment.ResumeLayout(false);
            this.panelAddComment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label anyCommentsLbl;
        private Button btnAddComment;
        private Button btnContinuePayment;
        private Panel panelAddComment;
        private Button btnConfirmComment;
        private TextBox inputComment;
        private Label lblTypeComment;
        private Label lblSaved;
        private Button btnBack;
    }
}

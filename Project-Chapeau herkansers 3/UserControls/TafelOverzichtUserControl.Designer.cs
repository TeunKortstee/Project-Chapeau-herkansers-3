namespace Project_Chapeau_herkansers_3
{
    partial class TafelOverzichtUserControl
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
            tableLayoutPanelTafels = new TableLayoutPanel();
            RefreshBtn = new Button();
            SuspendLayout();
            // 
            // tableLayoutPanelTafels
            // 
            tableLayoutPanelTafels.ColumnCount = 2;
            tableLayoutPanelTafels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelTafels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelTafels.Location = new Point(0, 84);
            tableLayoutPanelTafels.Name = "tableLayoutPanelTafels";
            tableLayoutPanelTafels.RowCount = 2;
            tableLayoutPanelTafels.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelTafels.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelTafels.Size = new Size(459, 302);
            tableLayoutPanelTafels.TabIndex = 0;
            // 
            // RefreshBtn
            // 
            RefreshBtn.Location = new Point(17, 30);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(112, 34);
            RefreshBtn.TabIndex = 1;
            RefreshBtn.Text = "Refresh";
            RefreshBtn.UseVisualStyleBackColor = true;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // TafelOverzichtUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RefreshBtn);
            Controls.Add(tableLayoutPanelTafels);
            Name = "TafelOverzichtUserControl";
            Size = new Size(459, 1032);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelTafels;
        private Button RefreshBtn;
    }
}

using Model;

namespace Project_Chapeau_herkansers_3

{
    public partial class TafelOverzichtUserControl : UserControl
    {
        private List<Tafel> tafels;
        public TafelOverzichtUserControl()
        {
            InitializeComponent();
            tafels = new List<Tafel>();
            for (int i = 1; i < 11; i++)
            {
                tafels.Add(new Tafel(i, TafelStatus.Vrij));
            }
            FillTableLayoutPanel();
        }
        private void Table_Click(object sender, EventArgs e)
        {

        }

        private Button CreateButton(Tafel tafel)
        {
            Button btn = new Button();
            btn.Size = new Size(100, 70);
            btn.Text = tafel.Id.ToString();
            btn.Click += Table_Click;
            btn.Tag = tafel;
            switch (tafel.status)
            {
                case (TafelStatus)0:
                    btn.BackColor = Color.MediumAquamarine;
                    break;
                case (TafelStatus)1:
                    btn.BackColor = Color.SandyBrown;
                    break;
            }

            return btn;
        }
        private void FillTableLayoutPanel()
        {
            CreateTableLayout(tafels);
            foreach (Tafel tafel in tafels)
            {
                Button btn = CreateButton(tafel);
                tableLayoutPanelTafels.Controls.Add(btn);
            }
        }
        private void CreateTableLayout(List<Tafel> buttons)
        {
            tableLayoutPanelTafels.ColumnStyles.Clear();
            tableLayoutPanelTafels.RowStyles.Clear();
            tableLayoutPanelTafels.ColumnCount = 2;
            if (buttons.Count % 2 == 0)
            {
                tableLayoutPanelTafels.RowCount = buttons.Count / 2;
            }
            else
            {
                tableLayoutPanelTafels.RowCount = buttons.Count / 2 + 1;
            }
            for (int i = 0; i < tableLayoutPanelTafels.ColumnCount; i++)
            {
                tableLayoutPanelTafels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 200F));
            }
            for (int i = 0; i < tableLayoutPanelTafels.RowCount; i++)
            {
                tableLayoutPanelTafels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 300f));
            }
        }
    }
}

using Model;
using Service;

namespace Project_Chapeau_herkansers_3

{
    public partial class TafelOverzichtUserControl : UserControl
    {
        public TafelOverzichtUserControl()
        {
            InitializeComponent();
            FillTableLayoutPanel(GetTafels());
        }
        private void Table_Click(object sender, EventArgs e)
        {
            //button click naar volgende pagina om status aan te passen
            Form1 form = Form1.Instance;
            Button btn = (Button)sender;
            TafelStatusUI tafelstatusui = new TafelStatusUI((Tafel)btn.Tag);
            form.SwitchPanels(tafelstatusui);
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
                case (TafelStatus)1:
                    btn.BackColor = Color.MediumAquamarine;
                    break;
                case (TafelStatus)2:
                    btn.BackColor = Color.SandyBrown;
                    break;
            }

            return btn;
        }
        private void FillTableLayoutPanel(List<Tafel> tafels)
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
        private List<Tafel> GetTafels()
        {
            //Get alle tafels van db
            TafelService service = new TafelService();
            return service.GetAllTafels();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FillTableLayoutPanel(GetTafels());
        }
    }
}

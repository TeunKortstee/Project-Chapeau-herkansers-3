using Model;
using Service;

namespace Project_Chapeau_herkansers_3.UserControls
{
    public partial class UserControlPersoneel : UserControl
    {
        private Form1 form;
        private PersoneelService personeelService;
        public UserControlPersoneel()
        {
            InitializeComponent();
            this.form = Form1.Instance;
            CreateEmployeeListView();
            personeelService = new PersoneelService();
            GetPersoneel();
        }

        #region DisplayUIElements

        private void CreateEmployeeListView()
        {
            lsvDatabaseItems.Clear();

            lsvDatabaseItems.Columns.Add("Naam", 100);
            lsvDatabaseItems.Columns.Add("Functie", 150);
        }
        private void GetPersoneel()
        {
            try
            {
                List<Personeel> personeelList = personeelService.GetPersoneel();
                foreach (Personeel personeel in personeelList)
                {
                    DisplayPersoneel(personeel);
                }
            }
            catch (Exception)
            {
                DisplayErrorMessage("Er ging iets mis bij de database");
            }
        }
        private void DisplayPersoneel(Personeel personeel)
        {
            ListViewItem item = new ListViewItem(personeel.AchterNaam);
            item.SubItems.Add(personeel.Functie.ToString());
            item.Tag = personeel;
            lsvDatabaseItems.Items.Add(item);
        }

        #endregion

        #region Buttons
        private void btnAddNewObject_Click(object sender, EventArgs e)
        {
            this.form.SwitchPanels(new UserControlNieuwItem(new Personeel(), false));
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.form.SwitchPanels(new UserControlManager());
        }

        private void btnAdjust_Click(object sender, EventArgs e)
        {
            if (!IsSelected())
            {
                return;
            }
            ListViewItem selectedLsvItem = lsvDatabaseItems.SelectedItems[0];
            AdjustSelectedItem(selectedLsvItem);
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsSelected())
                {
                    return;
                }
                ListViewItem selectedLsvItem = lsvDatabaseItems.SelectedItems[0];

                DeleteSelectedItem(selectedLsvItem);
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message);
            }
        }
        #endregion

        #region DeleteSelectedItem
        private void DeleteSelectedItem(ListViewItem selectedLsvItem)
        {
            RemovePersoneel((Personeel)selectedLsvItem.Tag);
            lsvDatabaseItems.Items.Remove(selectedLsvItem);
        }
        private void AdjustSelectedItem(ListViewItem selectedLsvItem)
        {
            this.form.SwitchPanels(new UserControlNieuwItem((Personeel)selectedLsvItem.Tag, true));
        }
        private void RemovePersoneel(Personeel selectedPersoneel)
        {
            this.personeelService.RemovePersoneel(selectedPersoneel);
        }
        #endregion

        private bool IsSelected()
        {
            if (lsvDatabaseItems.SelectedItems.Count > 0)
            {
                return true;
            }
            DisplayErrorMessage("Selecteer een item uit de lijst");
            return false;
        }
        private void DisplayErrorMessage(string errorMessage)
        {
            lblErrorOverview.Visible = true;
            lblErrorOverview.Text = errorMessage;
        }
    }
}

using Model;
using Service;

namespace Project_Chapeau_herkansers_3.UserControls
{
    public partial class UserControlPersoneelOverzicht : UserControl
    {
        private Form1 form;
        public UserControlPersoneelOverzicht()
        {
            InitializeComponent();
            this.form = Form1.Instance;
        }

        #region DisplayUIElements

        private void FillEmployeeListView(Functie functie)
        {
            lsvDatabaseItems.Clear();

            lsvDatabaseItems.Columns.Add("Naam", 100);
            lsvDatabaseItems.Columns.Add("Functie", 150);

            GetPersoneel(functie);

        }
        private void GetPersoneel(Functie functie)
        {
            try
            {
                PersoneelService personeelService = new PersoneelService();
                foreach (Personeel personeel in personeelService.GetPersoneelByFunctie(functie))
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

        #region Bottom Buttons

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
        }
        private void AdjustSelectedItem(ListViewItem selectedLsvItem)
        {
            switch (selectedLsvItem.Tag)
            {
                case MenuItem:
                    this.form.SwitchPanels(new UserControlItemEdit((MenuItem)selectedLsvItem.Tag));
                    break;
                case Personeel:
                    this.form.SwitchPanels(new UserControlItemEdit((Personeel)selectedLsvItem.Tag));
                    break;
            }
        }
        private void RemovePersoneel(Personeel selectedPersoneel)
        {
            PersoneelService personeelService = new PersoneelService();
            personeelService.RemovePersoneel(selectedPersoneel);
            FillEmployeeListView(selectedPersoneel.Functie);
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

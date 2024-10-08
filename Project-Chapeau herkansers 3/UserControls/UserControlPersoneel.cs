using Model;
using Service;
using System.Collections.Generic;

namespace Project_Chapeau_herkansers_3.UserControls
{
    public partial class UserControlPersoneel : UserControl
    {
        private Form1 form;
        private PersoneelService personeelService;
        private List<Personeel> personeel;
        public UserControlPersoneel()
        {
            InitializeComponent();
            this.form = Form1.Instance;
            CreateEmployeeListView();
            personeelService = new PersoneelService();
            this.personeel = GetAllPersoneel();
            DisplayAllPersoneel(this.personeel);
        }

        #region DisplayUIElements

        private void CreateEmployeeListView()
        {
            lsvDatabaseItems.Clear();

            lsvDatabaseItems.Columns.Add("Naam", 100);
            lsvDatabaseItems.Columns.Add("Functie", 150);
        }
        // Geef betere naam
        private List<Personeel> GetAllPersoneel()
        {
            List<Personeel> personeelList = new List<Personeel>();
            try
            {
                personeelList = personeelService.GetAllPersoneel();
            }
            catch (Exception)
            {
                DisplayErrorMessage("Er ging iets mis");
            }
            return personeelList;   
        }
        private void DisplayAllPersoneel(List<Personeel> personeel)
        {
            foreach (Personeel werknemer in personeel)
            {
                ListViewItem item = new ListViewItem(werknemer.AchterNaam);
                item.SubItems.Add(werknemer.Functie.ToString());
                item.Tag = werknemer;
                lsvDatabaseItems.Items.Add(item);
            }
        }

        #endregion

        #region Buttons
        private void btnAddNewObject_Click(object sender, EventArgs e)
        {
            this.form.SwitchPanels(new UserControlPersoneelEdit(new Personeel(), false));
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
            this.personeel = GetAllPersoneel();
        }
        private void AdjustSelectedItem(ListViewItem selectedLsvItem)
        {
            this.form.SwitchPanels(new UserControlPersoneelEdit((Personeel)selectedLsvItem.Tag, true));
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

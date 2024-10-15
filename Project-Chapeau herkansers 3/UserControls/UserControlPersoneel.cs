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
            personeelService = new PersoneelService();
            this.personeel = GetAllPersoneel();
            SetButtonTags();
            RefreshListView((Functie)btnBediening.Tag);
        }

        #region DisplayUIElements
        private void RefreshListView(Functie functie)
        {
            CreateEmployeeListView();
            DisplayPersoneelByFunctie(functie);
        }
        private void CreateEmployeeListView()
        {
            lsvDatabaseItems.Clear();

            lsvDatabaseItems.Columns.Add("Naam", 100);
            lsvDatabaseItems.Columns.Add("Functie", 150);
        }
        private List<Personeel> GetAllPersoneel()
        {
            personeel = new List<Personeel>();
            try
            {
                personeel = personeelService.GetAllPersoneel();
            }
            catch (Exception)
            {
                DisplayErrorMessage("Er ging iets mis");
            }
            return personeel;
        }
        private void DisplayPersoneelByFunctie(Functie functie)
        {
            foreach (Personeel werknemer in this.personeel)
            {
                if (werknemer.Functie == functie)
                {
                    ListViewItem item = new ListViewItem(werknemer.AchterNaam);
                    item.SubItems.Add(werknemer.Functie.ToString());
                    item.Tag = werknemer;
                    lsvDatabaseItems.Items.Add(item);
                }
            }
        }

        #endregion

        #region Top Buttons
        private void btnAddNewObject_Click(object sender, EventArgs e)
        {
            this.form.SwitchPanels(new UserControlPersoneelEdit(new Personeel(), false));
        }
        private void BedieningButtonEnabledChanged(object sender, EventArgs e)
        {
            SetEnableColor(btnBediening);
        }
        private void KeukenButtonEnabledChanged(object sender, EventArgs e)
        {
            SetEnableColor(btnKeuken);
        }
        private void BarButtonEnabledChanged(object sender, EventArgs e)
        {
            SetEnableColor(btnBar);
        }
        private void ManagersButtonEnabledChanged(object sender, EventArgs e)
        {
            SetEnableColor(btnManagers);
        }
        private void BedieningClick(object sender, EventArgs e)
        {
            RefreshListView((Functie)btnBediening.Tag);
            RenablePersoneelButtons((Functie)btnBediening.Tag);
        }

        private void KeukenClick(object sender, EventArgs e)
        {
            RefreshListView((Functie)btnKeuken.Tag);
            RenablePersoneelButtons((Functie)btnKeuken.Tag);
        }

        private void BarClick(object sender, EventArgs e)
        {
            RefreshListView((Functie)btnBar.Tag);
            RenablePersoneelButtons((Functie)btnBar.Tag);
        }

        private void ManagersClick(object sender, EventArgs e)
        {
            RefreshListView((Functie)btnManagers.Tag);
            RenablePersoneelButtons((Functie)btnManagers.Tag);
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
        private void DeleteSelectedItem(ListViewItem selectedLsvItem)
        {
            if (IsCurrentUser((Personeel)selectedLsvItem.Tag) || !IsConfirmed())
            {
                return;
            }
            RemovePersoneel((Personeel)selectedLsvItem.Tag);
            lsvDatabaseItems.Items.Remove(selectedLsvItem);
            personeel.Remove((Personeel)selectedLsvItem.Tag);
        }
        private void AdjustSelectedItem(ListViewItem selectedLsvItem)
        {
            if (IsCurrentUser((Personeel)selectedLsvItem.Tag))
            {
                return;
            }
            this.form.SwitchPanels(new UserControlPersoneelEdit((Personeel)selectedLsvItem.Tag, true));
        }
        private void RemovePersoneel(Personeel selectedPersoneel)
        {
            this.personeelService.RemovePersoneel(selectedPersoneel);
        }
        private bool IsConfirmed()
        {
            DialogResult confirmResult = MessageBox.Show("Weet u zeker dat u dit werknemer wilt verwijderen?", "Ja of Nee", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region ButtonStates
        private void SetButtonTags()
        {
            btnBediening.Tag = Functie.Bediening;
            btnKeuken.Tag = Functie.Keuken;
            btnBar.Tag = Functie.Bar;
            btnManagers.Tag = Functie.Manager;
        }
        private void RenablePersoneelButtons(Functie functie)
        {
            switch (functie)
            {
                case Functie.Bediening:
                    SetButtonStates(false, true, true, true);
                    break;
                case Functie.Keuken:
                    SetButtonStates(true, false, true, true);
                    break;
                case Functie.Bar:
                    SetButtonStates(true, true, false, true);
                    break;
                case Functie.Manager:
                    SetButtonStates(true, true, true, false);
                    break;
            }
        }
        private void SetButtonStates(bool bediening, bool keuken, bool bar, bool managers)
        {
            btnBediening.Enabled = bediening;
            btnKeuken.Enabled = keuken;
            btnBar.Enabled = bar;
            btnManagers.Enabled = managers;
        }
        private void SetEnableColor(Button button)
        {
            if (button.Enabled)
            {
                button.BackColor = Color.FromArgb(255, 138, 210, 176);
            }
            else
            {
                button.BackColor = Color.FromArgb(114, 138, 210, 176);
            }
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
        private bool IsCurrentUser(Personeel ingelogdeGebruiker)
        {
            if (ingelogdeGebruiker.Id == form.personeel.Id)
            {
                MessageBox.Show("Je kan jezelf niet aanpassen of verwijderen");
                return true;
            }
            return false;
        }
        private void DisplayErrorMessage(string errorMessage)
        {
            lblErrorOverview.Visible = true;
            lblErrorOverview.Text = errorMessage;
        }
    }
}

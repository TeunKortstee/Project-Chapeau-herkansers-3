using Model;
using Service;
using System.Collections.Generic;

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
            personeelService = new PersoneelService();
            RefreshPersoneelList();
        }
        private void RefreshPersoneelList()
        {
            List<Personeel> personeel = GetAllPersoneel();
            SetButtons(personeel);
            RefreshListView((Functie)btnBediening.Tag, personeel);
        }

        #region DisplayUIElements
        private void RefreshListView(Functie functie, List<Personeel> personeel)
        {
            CreateEmployeeListView();
            DisplayPersoneelByFunctie(functie, personeel);
        }
        private void CreateEmployeeListView()
        {
            lsvPersoneelItems.Clear();

            lsvPersoneelItems.Columns.Add("Naam", 100);
            lsvPersoneelItems.Columns.Add("Functie", 150);
        }
        private List<Personeel> GetAllPersoneel()
        {
            List<Personeel> personeel = new List<Personeel>();
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
        private void DisplayPersoneelByFunctie(Functie functie, List<Personeel> personeel)
        {
            foreach (Personeel werknemer in personeel)
            {
                if (werknemer.Functie == functie)
                {
                    ListViewItem item = new ListViewItem(werknemer.AchterNaam);
                    item.SubItems.Add(werknemer.Functie.ToString());
                    item.Tag = werknemer;
                    lsvPersoneelItems.Items.Add(item);
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
        private void BedieningClick(List<Personeel> personeel)
        {
            RefreshListView((Functie)btnBediening.Tag, personeel);
            RenablePersoneelButtons((Functie)btnBediening.Tag);
        }

        private void KeukenClick(List<Personeel> personeel)
        {
            RefreshListView((Functie)btnKeuken.Tag, personeel);
            RenablePersoneelButtons((Functie)btnKeuken.Tag);
        }

        private void BarClick(List<Personeel> personeel)
        {
            RefreshListView((Functie)btnBar.Tag, personeel);
            RenablePersoneelButtons((Functie)btnBar.Tag);
        }

        private void ManagersClick(List<Personeel> personeel)
        {
            RefreshListView((Functie)btnManagers.Tag, personeel);
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
            if (!HasSelectedPersoneel())
            {
                return;
            }
            ListViewItem selectedLsvItem = lsvPersoneelItems.SelectedItems[0];
            AdjustSelectedPersoneel((Personeel)selectedLsvItem.Tag);
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (!HasSelectedPersoneel() || !IsConfirmed())
                {
                    return;
                }
                ListViewItem selectedLsvItem = lsvPersoneelItems.SelectedItems[0];

                DeletePersoneel((Personeel)selectedLsvItem.Tag);
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message);
            }
        }
        private void DeletePersoneel(Personeel personeel)
        {
            if (IsCurrentUser(personeel))
            {
                return;
            }
            this.personeelService.RemovePersoneel(personeel);
            RefreshPersoneelList();
        }
        private void AdjustSelectedPersoneel(Personeel personeel)
        {
            if (IsCurrentUser(personeel))
            {
                return;
            }
            this.form.SwitchPanels(new UserControlPersoneelEdit(personeel, true));
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
        private void SetButtons(List<Personeel> personeel)
        {
            SetButtonTags();
            SetButtonClicks(personeel);
        }
        private void SetButtonTags()
        {
            btnBediening.Tag = Functie.Bediening;
            btnKeuken.Tag = Functie.Keuken;
            btnBar.Tag = Functie.Bar;
            btnManagers.Tag = Functie.Manager;
        }
        private void SetButtonClicks(List<Personeel> personeel)
        {
            btnBediening.Click += (sender, e) => BedieningClick(personeel);
            btnKeuken.Click += (sender, e) => KeukenClick(personeel);
            btnBar.Click += (sender, e) => BarClick(personeel);
            btnManagers.Click += (sender, e) => ManagersClick(personeel);
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

        private bool HasSelectedPersoneel()
        {
            if (lsvPersoneelItems.SelectedItems.Count > 0)
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

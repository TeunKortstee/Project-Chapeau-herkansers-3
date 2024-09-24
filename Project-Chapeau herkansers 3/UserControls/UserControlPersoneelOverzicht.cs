using Model;
using Service;

namespace Project_Chapeau_herkansers_3.UserControls
{
    public partial class UserControlPersoneelOverzicht : UserControl
    {
        private Form1 form;
        private PersoneelService personeelService;
        public UserControlPersoneelOverzicht(PersoneelService personeelService)
        {
            InitializeComponent();
            this.form = Form1.Instance;
            this.personeelService = personeelService;
            DisplayEmployeeElements(functie);

        }
        #region DisplayUIElements

        #region Employee
        private void DisplayEmployeeElements(Functie functie)
        {
            SetObjectText("Personeel", "Werknemer");
            DisplayEmployeeButtons();
            RenableEmployeeButtons(functie);
            FillEmployeeListView(functie);
        }
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

        #region Buttons - MenuItem
        private void DisplayMenuButtons()
        {
            btnOption1.Tag = MenuType.Lunch;
            btnOption2.Tag = MenuType.Diner;
            btnOption3.Tag = MenuType.Drank;
            SetButtonText(MenuType.Lunch.ToString(), MenuType.Diner.ToString(), MenuType.Drank.ToString());
        }
        private void RenableMenuButtons(MenuType menuType)
        {
            switch (menuType)
            {
                case MenuType.Lunch:
                    SetButtonStates(false, true, true);
                    break;
                case MenuType.Diner:
                    SetButtonStates(true, false, true);
                    break;
                case MenuType.Drank:
                    SetButtonStates(true, true, false);
                    break;
            }
            btnAddNewObject.Tag = menuType;
        }
        #endregion

        #region Buttons - Employee
        private void DisplayEmployeeButtons()
        {
            btnOption1.Tag = Functie.Serveerder;
            btnOption2.Tag = Functie.Keuken;
            btnOption3.Tag = Functie.Bar;
            SetButtonText(Functie.Serveerder.ToString(), Functie.Keuken.ToString(), Functie.Bar.ToString());
            AddButtonChangesForPersoneelManagement();
        }
        private void RenableEmployeeButtons(Functie functie)
        {
            switch (functie)
            {
                case Functie.Serveerder:
                    SetButtonStates(false, true, true);
                    chkOption4.CheckState = CheckState.Unchecked;
                    break;
                case Functie.Keuken:
                    SetButtonStates(true, false, true);
                    chkOption4.CheckState = CheckState.Unchecked;
                    break;
                case Functie.Bar:
                    SetButtonStates(true, true, false);
                    chkOption4.CheckState = CheckState.Unchecked;
                    break;
                case Functie.Manager:
                    SetButtonStates(true, true, true);
                    chkOption4.CheckState = CheckState.Checked;
                    break;
            }
            btnAddNewObject.Tag = functie;
        }
        private void AddButtonChangesForPersoneelManagement()
        {
            chkOption4.Visible = true;
            chkOption4.Text = "Managers weergeven";
            chkOption4.Tag = Functie.Manager;
        }
        #endregion

        private void SetObjectText(string title, string objectType)
        {
            lblOverview.Text = title;
            btnAddNewObject.Text = $"{objectType} toevoegen";
        }
        private void SetButtonText(string option1, string option2, string option3)
        {
            btnOption1.Text = option1;
            btnOption2.Text = option2;
            btnOption3.Text = option3;
        }
        private void SetButtonStates(bool option1, bool option2, bool option3)
        {
            btnOption1.Enabled = option1;
            btnOption2.Enabled = option2;
            btnOption3.Enabled = option3;
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
            switch (selectedLsvItem.Tag)
            {
                case MenuItem:
                    RemoveMenuItem((MenuItem)selectedLsvItem.Tag);
                    break;
                case Personeel:
                    RemovePersoneel((Personeel)selectedLsvItem.Tag);
                    break;
            }
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
        private void RemoveMenuItem(MenuItem selectedMenuItem)
        {
            MenuItemService menuItemService = new MenuItemService();
            menuItemService.SoftDeleteMenuItem(selectedMenuItem);
            FillMenuListView(selectedMenuItem.MenuType);
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

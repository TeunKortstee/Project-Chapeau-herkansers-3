using Model;
using Service;

namespace Project_Chapeau_herkansers_3.UserControls
{
    public partial class UserControlPersoneelEdit : UserControl
    {
        private Form1 form;
        // hier Personeel service
        private PersoneelService personeelService;
        private bool isEditing;

        public UserControlPersoneelEdit()
        {
            InitializeComponent();
            this.form = Form1.Instance;
            this.isEditing = false;
            personeelService = new PersoneelService();
            SetNewPersoneelLogic(Functie.Bediening);
            SetAddButton(new Personeel());
        }
        public UserControlPersoneelEdit(Personeel currentPersoneel)
        {
            InitializeComponent();
            this.form = Form1.Instance;
            this.isEditing = true;
            personeelService = new PersoneelService();
            SetEditPersoneelLogic(currentPersoneel);
            SetAddButton(currentPersoneel);
        }

        #region Personeel Logic
        private void SetAddButton(Personeel personeel)
        {
            btnConfirm.Click += (sender, e) => PersoneelConfirmClick(personeel);
        }
        private void SetEditPersoneelLogic(Personeel personeel)
        {
            SetCurrentObjectInfo(personeel.AchterNaam, personeel.Email);
            SetNewPersoneelLogic(personeel.Functie);
        }

        private void SetNewPersoneelLogic(Functie function)
        {
            SetObjectText("Werknemer", "Achternaam", "Email", "De_Graaf", "Functie");
            cmbType.DataSource = Enum.GetValues(typeof(Functie));
            cmbType.SelectedItem = function;
        }
        private void SetCurrentObjectInfo(string firstField, string secondField)
        {
            txt1.Text = firstField;
            txt2.Text = secondField;
        }
        private void SetObjectText(string objectType, string name, string emailOrPrice, string placeholder1, string enumType)
        {
            lblObject.Text = $"Nieuw {objectType}";
            lbl1.Text = name;
            lbl2.Text = emailOrPrice;
            txt2.PlaceholderText = placeholder1;
            lblEnum.Text = enumType;
        }
        #endregion

        #region Functionalities
        private void PersoneelConfirmClick(Personeel personeel)
        {
            try
            {
                // Dishonest method (het liegt)
                personeel = FillPersoneelObject(personeel);
                InsertPersoneel(personeel);
                UpdatePersoneel(personeel);
                ReturnToOverview();
            }
            catch (Exception)
            {
                DisplayErrorMessage("Er ging iets mis");
            }
        }
        private Personeel FillPersoneelObject(Personeel personeel)
        {
            if (!AreValidPersoneelInputs(txt1.Text, txt2.Text, (Functie)cmbType.SelectedItem))
            {
                throw new Exception();
            }
            personeel.AchterNaam = txt1.Text;
            personeel.Email = CreateEmail(txt2.Text);
            personeel.Functie = (Functie)cmbType.SelectedItem;
            return personeel;
        }
        #region Send to Database
        private void InsertPersoneel(Personeel newPersoneel)
        {
            if (isEditing)
            {
                return;
            }
            personeelService.InsertPersoneel(newPersoneel);
        }
        private void UpdatePersoneel(Personeel existingPersoneel)
        {
            if (!isEditing)
            {
                return;
            }
            personeelService.UpdatePersoneel(existingPersoneel);
        }
        #endregion
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReturnToOverview();
        }
        #endregion

        #region PersoneelHandling
        public string CreateEmail(string email)
        {
            if (!email.ToLower().EndsWith("@chapeau.nl"))
            {
                // If not, append the domain
                email = $"{email}@chapeau.nl";
            }
            return email.ToLower();
        }
        private bool AreValidPersoneelInputs(string nameInput, string emailInput, Functie selectedItem)
        {
            if (!IsEmpty(nameInput, emailInput) || !ValidCharacters(nameInput, emailInput) || !Enum.IsDefined(typeof(Functie), selectedItem))
            {
                return false;
            }
            return true;
        }
        private bool ValidCharacters(string nameInput, string emailInput)
        {
            foreach (char character in emailInput)
            {
                if (!char.IsLetter(character) && character != '_' && character != '.' && character != '@')
                {
                    DisplayErrorMessage("Username is niet geldig");
                    return false;
                }
            }
            foreach (char character in nameInput)
            {
                if (!char.IsLetter(character) && character != ' ')
                {
                    DisplayErrorMessage("Achternaam is niet geldig");
                    return false;
                }
            }
            return true;
        }
        private bool IsEmpty(string nameInput, string emailInput)
        {
            if (string.IsNullOrEmpty(emailInput) || string.IsNullOrWhiteSpace(nameInput))
            {
                DisplayErrorMessage("Vul alle velden in");
                return false;
            }
            return true;
        }
        #endregion

        #region ErrorHandling
        private void DisplayErrorMessage(string errorMessage)
        {
            lblErrorNewObject.Visible = true;
            lblErrorNewObject.Text = errorMessage;
        }

        #endregion

        private void ReturnToOverview()
        {
            form.SwitchPanels(new UserControlPersoneel());
        }
    }
}

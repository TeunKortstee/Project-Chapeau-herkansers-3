using Model;
using Service;

namespace Project_Chapeau_herkansers_3.UserControls
{
    public partial class UserControlPersoneelEdit : UserControl
    {
        private Form1 form;
        private PersoneelService personeelService;
        private bool isEditing;

        public UserControlPersoneelEdit(Personeel currentPersoneel, bool isEditing)
        {
            InitializeComponent();
            this.form = Form1.Instance;
            this.isEditing = isEditing;
            personeelService = new PersoneelService();
            SetPersoneelLogic(currentPersoneel);
        }

        #region Personeel Logic
        private void SetPersoneelLogic(Personeel currentPersoneel)
        {
            if (!isEditing)
            {
                SetNewPersoneelLogic(Functie.Bediening);
            }
            else
            {
                SetEditPersoneelLogic(currentPersoneel);
            }
            SetAddButton(currentPersoneel);
        }
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
                UpdatePersoneelObject(personeel);
                // InsertPersoneel(personeel);
                if (!isEditing)
                    personeelService.InsertPersoneel(personeel);
                else
                    personeelService.UpdatePersoneel(personeel);
                ReturnToOverview();
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message);
            }
        }
        private void UpdatePersoneelObject(Personeel personeel)
        {
            if (AreValidPersoneelInputs(txt1.Text, txt2.Text, (Functie)cmbType.SelectedItem))
            {
                personeel.AchterNaam = txt1.Text;
                personeel.Email = CreateEmail(txt2.Text);
                personeel.Functie = (Functie)cmbType.SelectedItem;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReturnToOverview();
        }
        #endregion

        #region ErrorHandling
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
            if (!IsEmpty(nameInput, emailInput) || !AreValidCharacters(nameInput, emailInput) || !Enum.IsDefined(typeof(Functie), selectedItem))
            {
                return false;
            }
            return true;
        }
        private bool AreValidCharacters(string nameInput, string emailInput)
        {
            foreach (char character in emailInput)
            {
                if (!char.IsLetter(character) && character != '_' && character != '.' && character != '@')
                {
                    throw new Exception("Username is niet geldig");
                }
            }
            foreach (char character in nameInput)
            {
                if (!char.IsLetter(character) && character != ' ')
                {
                    throw new Exception("Achternaam is niet geldig");
                }
            }
            return true;
        }
        private bool IsEmpty(string nameInput, string emailInput)
        {
            if (string.IsNullOrEmpty(emailInput) || string.IsNullOrWhiteSpace(nameInput))
            {
                throw new Exception("Vul alle velden in");
            }
            return true;
        }
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

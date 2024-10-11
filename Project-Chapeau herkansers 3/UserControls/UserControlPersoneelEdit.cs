using Model;
using Service;

namespace Project_Chapeau_herkansers_3.UserControls
{
    public partial class UserControlPersoneelEdit : UserControl
    {
        private Form1 form;
        private bool isEditing;
        private Personeel currentPersoneel;

        public UserControlPersoneelEdit(Personeel currentPersoneel, bool isEditing)
        {
            InitializeComponent();
            this.form = Form1.Instance;
            this.currentPersoneel = currentPersoneel;
            this.isEditing = isEditing;
            if (!isEditing)
            {
                SetNewPersoneelLogic(Functie.Bediening);
            }
            else
            {
                SetEditPersoneelLogic(currentPersoneel);
            }
        }

        #region Personeel Logic
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
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                InsertPersoneel();
                UpdatePersoneel();
                ReturnToOverview();
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message);
            }
        }
        #region Send to Database
        private void InsertPersoneel()
        {
            if (!AreValidPersoneelInputs(txt1.Text, txt2.Text, (Functie)cmbType.SelectedItem) || isEditing)
            {
                return;
            }
            PersoneelService personeelService = new PersoneelService();
            Personeel newPersoneel = new Personeel(txt1.Text, personeelService.CreateEmail(txt2.Text), (Functie)cmbType.SelectedItem);
            personeelService.InsertPersoneel(newPersoneel);
        }
        private void UpdatePersoneel()
        {
            if (!AreValidPersoneelInputs(txt1.Text, txt2.Text, (Functie)cmbType.SelectedItem) || !isEditing)
            {
                return;
            }
            this.currentPersoneel.AchterNaam = txt1.Text;
            this.currentPersoneel.Email = txt2.Text;
            this.currentPersoneel.Functie = (Functie)cmbType.SelectedItem;
            PersoneelService personeelService = new PersoneelService();
            personeelService.UpdatePersoneel(this.currentPersoneel);
        }
        #endregion
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReturnToOverview();
        }
        #endregion

        #region ErrorHandling

        #region PersoneelHandling
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
                if (!char.IsLetter(character) && character != '_' && character != '.')
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
            if (string.IsNullOrEmpty(nameInput) || string.IsNullOrWhiteSpace(nameInput))
            {
                DisplayErrorMessage("Vul alle velden in");
                return false;
            }
            return true;
        }
        #endregion

        private string InvalidInput()
        {
            return "Vul een geldig getal in";
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

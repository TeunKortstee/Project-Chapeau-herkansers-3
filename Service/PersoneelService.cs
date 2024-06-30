using BCrypt.Net;
using DAL;
using Model;

namespace Service
{
    public class PersoneelService
    {
        const string chapeauDomain = "@chapeau.nl";
        const string defaultPassword = "0000";

        private PersoneelDao personeelDao;

        public PersoneelService()
        {
            this.personeelDao = new PersoneelDao();
        }
        public List<Personeel> GetPersoneelByFunctie(Functie functie)
        {
            return personeelDao.GetPersoneelByFunctie(functie);
        }
        public void InsertPersoneel(Personeel personeel)
        {
            string slowSaltedHashedPassword = HashPasswordWithBCrypt(defaultPassword, 11);
            personeel.WachtWoord = slowSaltedHashedPassword;
            personeelDao.InsertPersoneel(personeel);
        }
        public void RemovePersoneel(Personeel personeel)
        {
            personeelDao.RemovePersoneel(personeel);
        }
        public void UpdatePersoneel(Personeel personeel)
        {
            personeelDao.UpdatePersoneel(personeel);
        }
        // Lucas
        public string CreateEmail(string username)
        {
            string formattedEmail = $"{username}{chapeauDomain}".ToLower();
            if (!IsUniqueEmail(formattedEmail))
            {
                throw new Exception("Email bestaat al");
            }
            return formattedEmail;
        }
        private bool IsUniqueEmail(string email)
        {
            return personeelDao.IsUniqueEmail(email);
        }
        private string HashPasswordWithBCrypt(string password, int workfactor)
        {
            string hashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(password, workfactor, HashType.SHA512);
            return hashedPassword;
        }
    }
}

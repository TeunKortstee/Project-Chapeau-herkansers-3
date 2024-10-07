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
        public List<Personeel> GetAllPersoneel()
        {
            return personeelDao.GetAllPersoneel();
        }
        public void InsertPersoneel(Personeel personeel)
        {
            string slowSaltedHashedPassword = HashPasswordWithBCrypt(defaultPassword, 11);
            personeel.Email = CreateEmail(personeel.Email);
            personeel.WachtWoord = slowSaltedHashedPassword;
            personeelDao.InsertPersoneel(personeel);
        }
        public void RemovePersoneel(Personeel personeel)
        {
            personeelDao.SoftDeletePersoneel(personeel);
        }
        public void UpdatePersoneel(Personeel personeel)
        {
            personeel.Email = CreateEmail(personeel.Email);
            personeelDao.UpdatePersoneel(personeel);
        }
        // Lucas
        public string CreateEmail(string email)
        {
            if (!email.ToLower().EndsWith(chapeauDomain))
            {
                // If not, append the domain
                email = $"{email}{chapeauDomain}";
            }
    
            return email.ToLower(); 
        }
        private string HashPasswordWithBCrypt(string password, int workfactor)
        {
            string hashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(password, workfactor, HashType.SHA512);
            return hashedPassword;
        }
    }
}

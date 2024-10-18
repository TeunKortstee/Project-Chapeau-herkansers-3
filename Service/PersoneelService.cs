using BCrypt.Net;
using DAL;
using Model;

namespace Service
{
    public class PersoneelService
    {
        // dit in app config
        //const string chapeauDomain = "@chapeau.nl";
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
            personeel.WachtWoord = slowSaltedHashedPassword;
            personeelDao.InsertPersoneel(personeel);
        }
        public void RemovePersoneel(Personeel personeel)
        {
            personeelDao.SoftDeletePersoneel(personeel);
        }
        public void UpdatePersoneel(Personeel personeel)
        {
            personeelDao.UpdatePersoneel(personeel);
        }

        private string HashPasswordWithBCrypt(string password, int workfactor)
        {
            return BCrypt.Net.BCrypt.EnhancedHashPassword(password, workfactor, HashType.SHA512);
        }
    }
}

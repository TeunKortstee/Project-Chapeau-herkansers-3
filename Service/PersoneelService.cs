using BCrypt.Net;
using DAL;
using Model;

namespace Service
{
    public class PersoneelService
    {
        const string DatabaseExceptionText = "Er ging iets mis";

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
            try
            {
                personeel.WachtWoord = HashPasswordWithBCrypt("0000", 11);
                personeelDao.InsertPersoneel(personeel);
            }
            catch
            {
                throw new Exception(DatabaseExceptionText);
            }
        }
        public void RemovePersoneel(Personeel personeel)
        {
            try
            {
                personeelDao.SoftDeletePersoneel(personeel);
            }
            catch
            {
                throw new Exception(DatabaseExceptionText);
            }
        }
        public void UpdatePersoneel(Personeel personeel)
        {
            try
            {
                personeelDao.UpdatePersoneel(personeel);
            }
            catch
            {
                throw new Exception(DatabaseExceptionText);
            }
        }

        private string HashPasswordWithBCrypt(string password, int workfactor)
        {
            return BCrypt.Net.BCrypt.EnhancedHashPassword(password, workfactor, HashType.SHA512);
        }
    }
}

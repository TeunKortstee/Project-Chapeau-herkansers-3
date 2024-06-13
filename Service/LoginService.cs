using BCrypt.Net;
using DAL;
using Model;

namespace Service
{
    public class LoginService
    {
        private LoginDao loginDao;
        const int workFactor = 11;
        const bool enhancedEntropy = true;
        public LoginService()
        {
            loginDao = new LoginDao();
        }
        public List<Personeel> GetAllPersoneel()
        {
            return loginDao.GetAllPersoneel();
        }
        public Personeel GetPersoneel(Personeel personeel)
        {
            return loginDao.GetPersoneel(personeel);
        }
        public void ChangePassword(Personeel personeel, string wachtwoord)
        {
            personeel.Salt = GenerateSalt();
            personeel.WachtWoord = HashPasswordWithBCrypt(wachtwoord, personeel.Salt);
            loginDao.ChangePassword(personeel);
        }
        private string HashPasswordWithBCrypt(string password, string salt)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, salt, enhancedEntropy, HashType.SHA512);
            return hashedPassword;
        }
        private string GenerateSalt()
        {
            string saltString = BCrypt.Net.BCrypt.GenerateSalt(workFactor);
            return saltString;
        }
        public bool VerifyPassword(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.EnhancedVerify(password, hashedPassword, HashType.SHA512);

        }
    }
}

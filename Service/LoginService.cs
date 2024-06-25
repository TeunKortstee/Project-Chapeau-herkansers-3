using BCrypt.Net;
using DAL;
using Model;

namespace Service
{
    public class LoginService
    {
        private LoginDao loginDao;
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
            personeel.WachtWoord = HashPasswordWithBCrypt(wachtwoord, 11);
            loginDao.ChangePassword(personeel);
        }
        private string HashPasswordWithBCrypt(string password, int workfactor)
        {
            string hashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(password, workfactor, HashType.SHA512);
            return hashedPassword;
        }
        public bool VerifyPassword(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.EnhancedVerify(password, hashedPassword, HashType.SHA512);

        }
    }
}

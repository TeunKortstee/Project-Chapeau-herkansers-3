using BCrypt.Net;
using DAL;
using Model;
using System.Text;

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
        private byte[] HashPasswordWithBCrypt(string password, byte[] salt)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, Encoding.UTF8.GetString(salt), enhancedEntropy, HashType.SHA512);
            return Encoding.UTF8.GetBytes(hashedPassword);
        }
        private byte[] GenerateSalt()
        {
            string saltString = BCrypt.Net.BCrypt.GenerateSalt(workFactor);
            return Encoding.UTF8.GetBytes(saltString);
        }
        public bool VerifyPassword(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.EnhancedVerify(password, hashedPassword, HashType.SHA512);

        }
        //public bool VerifyPassword(string enteredPassword, byte[] storedSalt, byte[] storedHash)
        //{
        //    byte[] hash = GenerateSaltedHash(enteredPassword, storedSalt);
        //    return hash.SequenceEqual(storedHash);
        //}
    }
}

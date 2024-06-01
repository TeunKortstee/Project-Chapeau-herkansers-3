using DAL;
using Model;
using System.Security.Cryptography;

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
            personeel.Salt = GenerateSalt();
            personeel.Wachtwoord = GenerateSaltedHash(wachtwoord, personeel.Salt);
            loginDao.ChangePassword(personeel);
        }
        public void InsertPersoneel(Personeel personeel, string wachtwoord)
        {
            personeel.Salt = GenerateSalt();
            personeel.Wachtwoord = GenerateSaltedHash(wachtwoord, personeel.Salt);
            loginDao.InsertPersoneel(personeel);
        }
        public static byte[] GenerateSalt()
        {
            byte[] salt = new byte[32];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }
        public static byte[] GenerateSaltedHash(string plainText, byte[] salt, int iterations = 10000)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(plainText, salt, iterations))
            {
                return pbkdf2.GetBytes(32); // 256-bit hash
            }
        }
        public bool VerifyPassword(string enteredPassword, byte[] storedSalt, byte[] storedHash)
        {
            byte[] hash = GenerateSaltedHash(enteredPassword, storedSalt);
            return hash.SequenceEqual(storedHash);
        }
    }
}

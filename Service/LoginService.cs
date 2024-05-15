using DAL;
using Model;
using System.Security.Cryptography;
using System.Text;

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

        }
        public void InsertPersoneel(Personeel personeel)
        {
            loginDao.InsertPersoneel(personeel);
        }
        static byte[] HashPassword(string password, byte[] salt)
        {
            using (var sha256 = SHA256.Create())
            {
                // Combine password and salt
                byte[] saltedPassword = Encoding.UTF8.GetBytes(password).Concat(salt).ToArray();

                // Compute hash
                return sha256.ComputeHash(saltedPassword);
            }
        }
    }
}

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
            loginDao.ChangePassword(personeel, ComputeSha256Hash(wachtwoord));
        }
        public void InsertPersoneel(Personeel personeel)
        {
            loginDao.InsertPersoneel(personeel);
        }
        private string ComputeSha256Hash(string computeThis)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(computeThis));
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte bit in bytes)
            {
                stringBuilder.Append(bit.ToString("x2"));
            }
            return stringBuilder.ToString();
        }
    }
}

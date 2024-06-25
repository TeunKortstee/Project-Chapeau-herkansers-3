using BCrypt.Net;
using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using BCrypt.Net;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Text.RegularExpressions;

namespace Service
{
    public class PersoneelService
    {
        const string chapeauDomain = "@chapeau.nl";
        const string defaultPassword = "0000";
        const int workFactor = 11;
        const bool enhancedEntropy = true;

        private PersoneelDao personeelDao;

        public PersoneelService()
        {
            this.personeelDao = new PersoneelDao();
        }
        public List<Personeel> GetAllPersoneel()
        {
            return personeelDao.GetAllPersoneel();
        }
        public List<Personeel> GetPersoneelByFunctie(Functie functie)
        {
            return personeelDao.GetPersoneelByFunctieId(functie);
        }
        public void InsertPersoneel(Personeel personeel)
        {
            personeelDao.InsertPersoneel(personeel);
        }
        public void RemovePersoneel(Personeel personeel)
        {
            personeelDao.RemovePersoneel(personeel);
        }
        // Lucas
        public Personeel CreatePersoneel(string surname, string username, Functie function)
        {
            string salt = GenerateSalt();
            string slowSaltedHashedPassword = HashPasswordWithBCrypt(defaultPassword, salt);
            return new Personeel(surname, CreateEmail(username), slowSaltedHashedPassword, salt, function);
        }
        private string CreateEmail(string username)
        {
            string formattedEmail = $"{username}{chapeauDomain}".ToLower();
            CheckEmail(formattedEmail);
            return formattedEmail;
        }
        private void CheckEmail(string formattedEmail)
        {
            if (!IsUniqueEmail(formattedEmail))
            {
                throw new Exception("Email bestaat al");
            }
        }
        private bool IsUniqueEmail(string email)
        {
            return personeelDao.IsUniqueEmail(email);
        }
        private string HashPasswordWithBCrypt(string password, string salt)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, salt, enhancedEntropy, HashType.SHA512);
            return hashedPassword;
        }
        private string GenerateSalt()
        {
            return BCrypt.Net.BCrypt.GenerateSalt(workFactor);
        }
    }
}

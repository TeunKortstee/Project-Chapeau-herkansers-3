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

namespace Service
{
    public class PersoneelService
    {
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
        public Personeel CreatePersoneel(string surname, string email, string password, Functie function)
        {
            if (!IsUniqueEmail(email)) 
            {
                throw new FormatException("Email bestaat al");
            }
            string salt = GenerateSalt();
            string slowSaltedHashedPassword = HashPasswordWithBCrypt(password, salt);
            return new Personeel(surname, email, slowSaltedHashedPassword, salt, function);

            // Had geprobeerd om een slow saltedhash te maken met Argon2
            // HashPasswordWithArgon2(password, salt, 4, 65536, 2);
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
        private bool IsUniqueEmail(string email)
        {
            return personeelDao.IsUniqueEmail(email);
        }

        //private string HashPasswordWithArgon2(string password, int iterations, int memorySize, int parallelism)
        //{
        //    byte[] salt = new byte[32];
        //    using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
        //    {
        //        rng.GetBytes(salt);
        //    }

        //    // Generate a salt
        //    Argon2Config config = new Argon2Config
        //    {
        //        Type = Argon2Type.DataIndependentAddressing,
        //        Version = Argon2Version.Nineteen,
        //        TimeCost = iterations,
        //        MemoryCost = memorySize,
        //        Lanes = parallelism,
        //        Threads = parallelism,
        //        Password = Encoding.UTF8.GetBytes(password),
        //        Salt = salt,
        //    };
        //    Argon2 argon2 = new Argon2(config);
        //    SecureArray<byte> hash = argon2.Hash();
        //    return config.EncodeString(hash.Buffer);
        //}
    }
}

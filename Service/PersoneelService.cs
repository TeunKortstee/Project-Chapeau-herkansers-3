using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using Isopoh.Cryptography.Argon2;
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
        // Lucas
        public Personeel CreatePersoneel(string surname, string email, string password,  Functie function)
        {
            byte[] salt = GenerateSalt();
            byte[] slowSaltedHashedPassword = HashPasswordWithBCrypt(password, salt);
            return new Personeel(surname, email, slowSaltedHashedPassword, salt, function);
            // Had geprobeerd om een slow saltedhash te maken met Argon2
            // HashPasswordWithArgon2(password, salt, 4, 65536, 2);
        }
        private byte[] HashPasswordWithBCrypt(string password, byte[] salt)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, Encoding.UTF8.GetString(salt), enhancedEntropy, HashType.SHA512);
            return Encoding.UTF8.GetBytes(hashedPassword);
        }
        public byte[] GenerateSalt()
        {
            string saltString = BCrypt.Net.BCrypt.GenerateSalt(workFactor);
            return Encoding.UTF8.GetBytes(saltString);
        }
        //private byte[] HashPasswordWithArgon2(string password, byte[] salt, int iterations, int memorySize, int parallelism)
        //{

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
        //    using (var argon2 = new Argon2(config))
        //    {
        //        return argon2.GetBytes(16);
        //    }
        //}
    }
}

﻿using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class LoginDao : BaseDao
    {
        public List<Personeel> GetAllPersoneel()
        {
            string query = "SELECT PersoneelsId, Voornaam, Achternaam, Wachtwoord, Functie, Fooi FROM Personeel";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public Personeel GetPersoneel(Personeel personeel)
        {
            try
            {
                string query = "SELECT PersoneelsId, Achternaam, Wachtwoord, Salt, Email, FunctieId FROM Personeel WHERE Email=@Email";
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                new SqlParameter("@Email", personeel.email)
                };
                return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public void ChangePassword(Personeel personeel)
        {
            string query = "UPDATE Personeel SET Wachtwoord = @Wachtwoord, Salt=@Salt WHERE PersoneelsId = @PersoneelsId;";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@PersoneelsId", personeel.Id),
                new SqlParameter("@Wachtwoord", personeel.WachtWoord),
                new SqlParameter("@Salt", personeel.Salt)
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public void InsertPersoneel(Personeel personeel)
        {
            string query = "INSERT INTO Personeel(Achternaam, Email, Wachtwoord, Salt, FunctieId) VALUES (@Email, @Achternaam, @Wachtwoord, @Salt, @Functie)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Email", personeel.email),
                new SqlParameter("@Achternaam", personeel.AchterNaam),
                new SqlParameter("@Wachtwoord", personeel.WachtWoord),
                new SqlParameter("@Salt", personeel.Salt),
                new SqlParameter("@Functie", personeel.Functie),

            };
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Personeel> ReadTables(DataTable dataTable)
        {
            List<Personeel> personeel = new List<Personeel>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Personeel student = new Personeel()
                {
                    Id = Convert.ToInt32(dr["PersoneelsId"]),
                    email = dr["Email"].ToString(),
                    AchterNaam = dr["Achternaam"].ToString(),
                    WachtWoord = dr["Wachtwoord"].ToString(),
                    Salt = dr["Salt"].ToString(),
                    Functie = (Functie)Convert.ToInt32(dr["FunctieId"])
                };
                personeel.Add(student);
            }
            return personeel;
        }
    }
}

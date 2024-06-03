﻿using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PersoneelDao : BaseDao
    {
        public List<Personeel> GetAllPersoneel()
        {
            string query = "SELECT PersoneelsId, Voornaam, Achternaam, Wachtwoord, FunctieId FROM Personeel"; ;
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Personeel> ReadTables(DataTable dataTable)
        {
            List<Personeel> personeel = new List<Personeel>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Personeel werknemer = new Personeel()
                {
                    Id = (int)dr["PersoneelsId"],
                    VoorNaam = dr["Voornaam"].ToString(),
                    AchterNaam = dr["Achternaam"].ToString(),
                    Functie = (Functie)dr["FunctieId"]
                };
                personeel.Add(werknemer);
            }
            return personeel;
        }
        public Personeel GetPersoneel(Personeel personeel)
        {
            string query = "SELECT PersoneelsId, Voornaam, Achternaam, Wachtwoord, FunctieId, Fooi FROM Personeel WHERE Voornaam=@Voornaam AND Wachtwoord=@Wachtwoord";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Voornaam", personeel.VoorNaam),
                new SqlParameter("@Wachtwoord", personeel.WachtWoord)
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }
        public void InsertPersoneel(Personeel personeel)
        {
            string query = "INSERT INTO Personeel (Voornaam, Achternaam, Wachtwoord, Functie) VALUES (@Voornaam, @Achternaam, @Wachtwoord, @Functie)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Voornaam", personeel.VoorNaam),
                new SqlParameter("@Achternaam", personeel.AchterNaam),
                new SqlParameter("@Wachtwoord", personeel.WachtWoord),
                new SqlParameter("@Functie", personeel.Functie),
            };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
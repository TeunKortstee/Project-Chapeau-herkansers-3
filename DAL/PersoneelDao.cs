using Model;
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
            string query = "SELECT PersoneelId, Voornaam, Achternaam, Wachtwoord, Functie FROM Personeel"; ;
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
                    PersoneelsId = (int)dr["PersoneelsId"],
                    Voornaam = dr["Voornaam"].ToString(),
                    Achternaam = dr["Achternaam"].ToString(),
                    Functie = (Functie)dr["FunctieId"]
                };
                personeel.Add(werknemer);
            }
            return personeel;
        }
        public Personeel GetPersoneel(Personeel personeel)
        {
            string query = "SELECT PersoneelId, Voornaam, Achternaam, Wachtwoord, Functie, Fooi FROM Personeel WHERE Voornaam=@Voornaam AND Wachtwoord=@Wachtwoord";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Voornaam", personeel.Voornaam),
                new SqlParameter("@Wachtwoord", personeel.Wachtwoord)
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }
        public void InsertPersoneel(Personeel personeel)
        {
            string query = "INSERT INTO Personeel (Voornaam, Achternaam, Wachtwoord, Functie) VALUES (@Voornaam, @Achternaam, @Wachtwoord, @Functie)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Voornaam", personeel.Voornaam),
                new SqlParameter("@Achternaam", personeel.Achternaam),
                new SqlParameter("@Wachtwoord", personeel.Wachtwoord),
                new SqlParameter("@Functie", personeel.Functie),
            };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}

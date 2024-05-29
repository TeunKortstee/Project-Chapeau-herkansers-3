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
                    PersoneelId = (int)dr["PersoneelId"],
                    Voornaam = dr["Voornaam"].ToString(),
                    Achternaam = dr["Achternaam"].ToString(),
                    Functie = (Functie)dr["FunctieId"]
                };
                personeel.Add(werknemer);
            }
            return personeel;
        }
    }
}

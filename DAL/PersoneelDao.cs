using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class PersoneelDao : BaseDao
    {
        public List<Personeel> GetAllPersoneel()
        {
            string query = "SELECT PersoneelsId, Achternaam, Wachtwoord, FunctieId FROM Personeel"; ;
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
                    Id = Convert.ToInt32(dr["PersoneelsId"]),
                    AchterNaam = dr["Achternaam"].ToString(),
                    Functie = (Functie)Convert.ToInt32(dr["FunctieId"])
                };
                personeel.Add(werknemer);
            }
            return personeel;
        }
        public Personeel GetPersoneel(Personeel personeel)
        {
            string query = "SELECT PersoneelsId, Achternaam, Wachtwoord, FunctieId, Fooi FROM Personeel WHERE Email=@Email AND Wachtwoord=@Wachtwoord";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Email", personeel.Email),
                new SqlParameter("@Wachtwoord", personeel.WachtWoord)
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }
        public void InsertPersoneel(Personeel personeel)
        {
            string query = "INSERT INTO Personeel (Achternaam, Wachtwoord, FunctieId, Email) VALUES (@Achternaam, @Wachtwoord, @FunctieId, @Email)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Achternaam", personeel.AchterNaam),
                new SqlParameter("@Email", personeel.Email),
                new SqlParameter("@Wachtwoord", personeel.WachtWoord),
                new SqlParameter("@FunctieId", (int)personeel.Functie)

            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public void RemovePersoneel(Personeel selectedEmployee)
        {
            string query = "DELETE FROM Personeel WHERE PersoneelsId = @PersoneelsId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@PersoneelsId", selectedEmployee.Id),
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        // Lucas
        public List<Personeel> GetPersoneelByFunctieId(Functie functie)
        {
            string query = "SELECT p.* FROM Personeel p JOIN Personeel_Functie f ON p.FunctieId = f.FunctieId WHERE p.FunctieId = @FunctieId";
            SqlParameter[] sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("@FunctieId", (int)functie),
                };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public bool IsUniqueEmail(string email)
        {
            string query = "SELECT Email FROM Personeel WHERE Email = @Email";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Email", email),
            };

            List<Personeel> personeel = ReadTables(ExecuteSelectQuery(query, sqlParameters));

            // If no records are found, the email is unique
            return personeel.Count == 0;
        }
    }
}

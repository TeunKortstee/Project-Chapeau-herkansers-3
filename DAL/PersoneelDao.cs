using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class PersoneelDao : BaseDao
    {

        private List<Personeel> ReadTables(DataTable dataTable)
        {
            List<Personeel> personeel = new List<Personeel>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Personeel werknemer = new Personeel()
                {
                    Id = Convert.ToInt32(dr["PersoneelsId"]),
                    AchterNaam = dr["Achternaam"].ToString(),
                    Email = dr["Email"].ToString(),
                    Functie = (Functie)Convert.ToInt32(dr["FunctieId"])
                };
                personeel.Add(werknemer);
            }
            return personeel;
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
        public List<Personeel> GetPersoneelByFunctie(Functie functie)
        {
            string query = "SELECT PersoneelsId, Achternaam, Email, FunctieId FROM Personeel WHERE FunctieId = @FunctieId";
            SqlParameter[] sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("@FunctieId", (int)functie),
                };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public bool IsUniqueEmail(string email)
        {
            string query = "SELECT PersoneelsId, Achternaam, Email, FunctieId FROM Personeel WHERE Email = @Email";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Email", email),
            };

            List<Personeel> personeel = ReadTables(ExecuteSelectQuery(query, sqlParameters));
            return personeel.Count == 0;
        }
        public void UpdatePersoneel(Personeel selectedPersoneel)
        {
            string query = "UPDATE Personeel SET Achternaam = @Achternaam, Email = @Email, FunctieId = @FunctieId  WHERE PersoneelsId = @PersoneelsId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@PersoneelsId", selectedPersoneel.Id),
                new SqlParameter("@Achternaam", selectedPersoneel.AchterNaam),
                new SqlParameter("@Email", selectedPersoneel.Email),
                new SqlParameter("@FunctieId", (int)selectedPersoneel.Functie),
            };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}

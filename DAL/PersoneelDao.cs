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
        // Lucas
        public List<Personeel> GetAllPersoneel()
        {
            string query = "SELECT PersoneelsId, Achternaam, FunctieId, Email FROM Personeel WHERE IsBeschikbaar = 1";
            return ReadTables(ExecuteSelectQuery(query));
        }
        public void UpdatePersoneel(Personeel personeel)
        {
            string query = "UPDATE Personeel SET Achternaam = @Achternaam, Email = @Email, FunctieId = @FunctieId  WHERE PersoneelsId = @PersoneelsId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@PersoneelsId", personeel.Id),
                new SqlParameter("@Achternaam", personeel.AchterNaam),
                new SqlParameter("@Email", personeel.Email),
                new SqlParameter("@FunctieId", (int)personeel.Functie),
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public void SoftDeletePersoneel(Personeel selectedEmployee)
        {
            string query = "UPDATE Personeel SET IsBeschikbaar = 0 WHERE PersoneelsId = @PersoneelsId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@PersoneelsId", selectedEmployee.Id),
            };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}

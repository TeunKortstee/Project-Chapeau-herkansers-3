using Model;
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
            string query = "SELECT PersoneelId, Voornaam, Achternaam, Wachtwoord, Functie, Fooi FROM Personeel WHERE Voornaam=@Voornaam AND Wachtwoord=@Wachtwoord";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Voornaam", personeel.Voornaam),
                new SqlParameter("@Wachtwoord", personeel.Wachtwoord)
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }
        public void ChangePassword(Personeel personeel)
        {
            string query = "UPDATE Personeel SET Wachtwoord = @Wachtwoord WHERE PersoneelsId = @PersoneelsId;";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@PersoneelsId", personeel.PersoneelsId),
                new SqlParameter("@Wachtwoord", personeel.Wachtwoord)
            };
            ExecuteEditQuery(query, sqlParameters);
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

        private List<Personeel> ReadTables(DataTable dataTable)
        {
            List<Personeel> personeel = new List<Personeel>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Personeel student = new Personeel()
                {
                    PersoneelsId = (int)dr["PersoneelsId"],
                    Voornaam = dr["Voornaam"].ToString(),
                    Achternaam = dr["Achternaam"].ToString(),
                    Wachtwoord = (byte[])dr["Wachtwoord"],
                    Functie = (Functie)dr["Functie"],
                };
                personeel.Add(student);
            }
            return personeel;
        }
    }
}

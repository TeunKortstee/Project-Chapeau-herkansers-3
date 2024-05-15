using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class LoginDao : BaseDao
    {
        public List<Personeel> GetAllPersoneel()
        {
            string query = "SELECT PersoneelId, Voornaam, Achternaam, Wachtwoord, Functie, Fooi FROM Personeel";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public Personeel GetPersoneel(Personeel personeel)
        {
            string query = "SELECT PersoneelId, Voornaam, Achternaam, Wachtwoord, Functie, Fooi FROM Personeel WHERE Voornaam=@Voornaam AND Wachtwoord=@Wachtwoord";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Voornaam", personeel.FirstName),
                new SqlParameter("@Wachtwoord", personeel.Password)
            };
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            return ReadTables(dataTable).FirstOrDefault();
        }
        public void ChangePassword(Personeel personeel, string Wachtwoord)
        {
            string query = "UPDATE Personeel SET Wachtwoord = @Wachtwoord WHERE PersoneelID = @Id;";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Id", personeel.Id),
                new SqlParameter("@Wachtwoord", personeel.Password)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void InsertPersoneel(Personeel personeel)
        {
            string query = "INSERT INTO Personeel(Voornaam, Achternaam, Wachtwoord, Functie) VALUES (@Voornaam, @Achternaam, @Wachtwoord, @Functie, @Fooi)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Voornaam", personeel.FirstName),
                new SqlParameter("@Achternaam", personeel.LastName),
                new SqlParameter("@Wachtwoord", personeel.Password),
                new SqlParameter("@Functie", personeel.Functie),
                new SqlParameter("@Fooi", personeel.Fooi)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Personeel> ReadPersoneel(DataTable dataTable)
        {
            List<Personeel> personeel = new List<Personeel>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Personeel student = new Personeel()
                {
                    Id = (int)dr["PersoneelId"],
                    FirstName = dr["Voornaam"].ToString(),
                    LastName = dr["Achternaam"].ToString(),
                    Password = dr["Wachtwoord"].ToString(),
                    Functie = (Functie)dr["Functie"],
                    Fooi = (float)dr["Fooi"]
                };
                personeel.Add(student);
            }
            return personeel;
        }
        private List<Personeel> ReadTables(DataTable dataTable)
        {
            List<Personeel> personeel = new List<Personeel>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Personeel student = new Personeel()
                {
                    Id = (int)dr["PersoneelId"],
                    FirstName = dr["Voornaam"].ToString(),
                    LastName = dr["Achternaam"].ToString(),
                    Password = dr["Wachtwoord"].ToString(),
                    Functie = (Functie)dr["Functie"],
                    Fooi = (float)dr["Fooi"]
                };
                personeel.Add(student);
            }
            return personeel;
        }
    }
}

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
                new SqlParameter("@Voornaam", personeel.VoorNaam),
                new SqlParameter("@Wachtwoord", personeel.WachtWoord)
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }
        public void ChangePassword(Personeel personeel)
        {
            string query = "UPDATE Personeel SET Wachtwoord = @Wachtwoord WHERE PersoneelID = @Id;";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Id", personeel.Id),
                new SqlParameter("@Wachtwoord", personeel.WachtWoord)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void InsertPersoneel(Personeel personeel)
        {
            string query = "INSERT INTO Personeel(Voornaam, Achternaam, Wachtwoord, Functie) VALUES (@Voornaam, @Achternaam, @Wachtwoord, @Functie)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Voornaam", personeel.VoorNaam),
                new SqlParameter("@Achternaam", personeel.AchterNaam),
                new SqlParameter("@Wachtwoord", personeel.WachtWoord),
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
                    Id = (int)dr["PersoneelId"],
                    VoorNaam = dr["Voornaam"].ToString(),
                    AchterNaam = dr["Achternaam"].ToString(),
                    WachtWoord = (byte[])dr["Wachtwoord"],
                    Functie = (Functie)dr["Functie"]
                    
                };
                personeel.Add(student);
            }
            return personeel;
        }
    }
}

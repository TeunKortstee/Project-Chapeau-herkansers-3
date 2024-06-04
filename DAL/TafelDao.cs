using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class TafelDao : BaseDao
    {
        public List<Tafel> GetAllTafels()
        {
            string query = "SELECT TableNr, Capaciteit, StatusId FROM Tafels;";
            return ReadTables(ExecuteSelectQuery(query));
        }
        public void ChangeTableStatus(Tafel tafel)
        {
            string query = "UPDATE Tafels SET StatusId = @StatusId WHERE TableNr = @tafelNummer;";
            SqlParameter[] sqlParameters = new SqlParameter[2]
            {
                new SqlParameter("@StatusId", tafel.status),
                new SqlParameter("@tafelNummer", tafel.Id)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Tafel> ReadTables(DataTable dataTable)
        {
            List<Tafel> tafels = new List<Tafel>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Tafel tafel = new Tafel()
                {
                    Id = (int)dr["TableNr"],
                    Capaciteit = (int)dr["Capaciteit"],
                    status = (TafelStatus)dr["StatusId"]
                };
                tafels.Add(tafel);
            }
            return tafels;
        }
    }
}

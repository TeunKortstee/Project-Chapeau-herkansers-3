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
        public void ChangeTafelStatus(Tafel tafel)
        {
            string query = "UPDATE Tafels SET StatusId = @StatusId WHERE TableNr = @tafelNummer;";
            SqlParameter[] sqlParameters = new SqlParameter[2]
            {
                new SqlParameter("@StatusId", tafel.status),
                new SqlParameter("@tafelNummer", tafel.Id)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public List<Tafel> ReadTables(DataTable dataTable)
        {
            List<Tafel> tafels = new List<Tafel>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Tafel tafel = new Tafel()
                {
                    Id = Convert.ToInt32(dr["TableNr"]),
                    Capaciteit = Convert.ToInt32(dr["Capaciteit"]),
                    status = (TafelStatus)Convert.ToInt32(dr["StatusId"])
                };
                tafels.Add(tafel);
            }
            return tafels;
        }
    }
}

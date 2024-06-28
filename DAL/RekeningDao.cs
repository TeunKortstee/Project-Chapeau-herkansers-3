using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RekeningDao : BaseDao
    {
        private TafelDao tafelDao;
        public RekeningDao() {
            tafelDao = new TafelDao();


        }

        // Lucas
        public List<Rekening> GetBetaaldeRekeningen(bool betaald)
        {
            string query = "SELECT * FROM Rekeningen WHERE Betaald = @Betaald";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Betaald", betaald),

            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Rekening> ReadTables(DataTable dataTable)
        {
            List<Rekening> rekeningen = new List<Rekening>();
            TafelDao tafelDao = new TafelDao();
            foreach (DataRow row in dataTable.Rows)
            {
                Tafel tafel = tafelDao.ReadTables(dataTable)[0];
                Rekening rekening = new Rekening(Convert.ToInt32(row["RekeningId"]), 
                    tafel, 
                    (double)row["TotaalPrijs"],
                    (bool)row["Betaald"], 
                    (DateTime)row["Datum"],
                    (double)row["Belasting"],
                    (string)row["Opmerkingen"]
                    );
                
                rekeningen.Add(rekening);
            }
            return rekeningen;      
        }
        public void RekeningBetaald(Rekening rekening) {
            string query = "UPDATE Rekeningen SET Betaald = 1, Datum = GETDATE() WHERE RekeningId = @ID; UPDATE Bestellingen SET Betaald = 1 WHERE TableNr = @TableNr AND Betaald = 0; UPDATE Tafels SET StatusId = 1 WHERE TableNr = @TableNr;";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ID", rekening.RekeningId),
                new SqlParameter("@TableNr", rekening.Tafel.Id),
                

            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public void VoegOpmerkingenToe(Rekening rekening, string opmerkingen)
        {
            string query = "UPDATE Rekeningen SET Opmerkingen = @Opmerkingen WHERE RekeningId = @ID;";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ID", rekening.RekeningId),
                new SqlParameter("@Opmerkingen",opmerkingen)
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public int InsertRekening(Rekening rekening)
        {
            string query = "INSERT INTO Rekeningen (TafelId,TotaalPrijs,Betaald,Belasting) VALUES (@TafelId,@TotaalPrijs,@Betaald,@Belasting) SELECT CAST(scope_identity() AS int)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@TafelId", rekening.Tafel.Id),
                new SqlParameter("@TotaalPrijs", rekening.TotaalPrijs),                
                new SqlParameter("@Betaald", rekening.Betaald),
                new SqlParameter("@Belasting", rekening.Belasting)

            };
            return ExecuteEditQueryReturnID(query, sqlParameters);
        }
    }
}
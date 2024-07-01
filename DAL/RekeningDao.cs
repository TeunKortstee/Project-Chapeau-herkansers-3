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
            string query = "SELECT Rekeningen.RekeningId, Rekeningen.TafelID, Rekeningen.Datum, Rekeningen.BelastingNormaal, Rekeningen.BelastingAlcoholisch, Rekeningen.Opmerkingen, Tafels.TableNr, Tafels.Capaciteit, Tafels.StatusId FROM Rekeningen JOIN Tafels ON Rekeningen.TafelId=Tafels.TableNr";
            return ReadTables(ExecuteSelectQuery(query));
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
                    (DateTime)row["Datum"],
                    (double)row["BelastingNormaal"],
                    (double)row["BelastingAlcoholisch"],
                    (string)row["Opmerkingen"]
                    );
                
                rekeningen.Add(rekening);
            }
            return rekeningen;      
        }       
        public int InsertRekening(Rekening rekening)
        {
            string query = "INSERT INTO Rekeningen (TafelId,TotaalPrijs,BelastingNormaal,BelastingAlcoholisch,Opmerkingen) VALUES (@TafelId,@TotaalPrijs,@BelastingNormaal,@BelastingAlcoholisch,@Opmerkingen) SELECT CAST(scope_identity() AS int); UPDATE Bestellingen SET Betaald = 1 WHERE TableNr = @TafelId AND Betaald = 0; UPDATE Tafels SET StatusId = 1 WHERE TableNr = @TafelId;";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@TafelId", rekening.Tafel.Id),
                new SqlParameter("@TotaalPrijs", rekening.TotaalPrijs),
                new SqlParameter("@BelastingNormaal", rekening.BelastingNormaal),
                new SqlParameter("@BelastingAlcoholisch", rekening.BelastingAlcoholisch),
                new SqlParameter("@Opmerkingen", rekening.Opmerkingen)
            };
            return ExecuteEditQueryReturnID(query, sqlParameters);
        }
    }
}
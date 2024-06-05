﻿using Model;
using System;
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
        public Rekening GetRekening(int bestellingID)
        {
            string query = "SELECT RekeningId, BestellingId, TotaalPrijs, Datum, Fooi, Betaald FROM Rekeningen WHERE BestellingId = @bestellingId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@bestellingId", bestellingID),
             
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        private List<Rekening> ReadTables(DataTable dataTable)
        {
            List<Rekening> rekeningen = new List<Rekening>();
            foreach (DataRow row in dataTable.Rows)
            {

                Rekening rekening = new Rekening(Convert.ToInt32(row["RekeningId"]), 
                    Convert.ToInt32(row["BestellingId"]), 
                    (double)row["TotaalPrijs"], 
                    (double)row["Fooi"], 
                    (bool)row["Betaald"], 
                    (DateTime)row["DateTime"]);
                
                rekeningen.Add(rekening);
            }
            return rekeningen;
        }

        public void InsertRekening(Rekening rekening)
        {
            string query = "INSERT INTO Rekening(BestellingId,TotaalPrijs,Fooi,Betaald,Datum) VALUES (@BestellingId,@TotaalPrijs,@Fooi,@Betaald,@Datum)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@BestellingId", rekening.BestellingId),
                new SqlParameter("@TotaalPrijs", rekening.TotaalPrijs),
                new SqlParameter("@Fooi", rekening.Fooi),
                new SqlParameter("@Betaald", rekening.Betaald),

            };
            ExecuteEditQuery(query, sqlParameters);
        }


    }
}

using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ItemBereiderDao : BaseDao
    {
        public List<ItemBereider> GetAllItems(int personeelsId)
        {
            string query = @"SELECT
                                    [BesteldItemId]
                                  , [Opmerking]
                                  , [Instuurtijd]
                                  , OrderedItem.[MenuItemId]
                                  , OrderedItem.BestellingsId
                                  , [Hoeveelheid]
                                  , Orders.PersoneelsId
                                  
                                  , Keuken.[Status]
                            FROM [dbo].[BesteldeItems] AS OrderedItem
                                INNER JOIN Bestellingen AS Orders ON Orders.BestellingsId = OrderedItem.BesteldItemId
                                
                                FULL OUTER JOIN Keuken on Keuken.BestellingId = Orders.BestellingsId
                            WHERE Orders.PersoneelsId = 0";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@personeelsId", personeelsId),
             
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
            // kan dit query makkelijker?
            // wat doet de personeelsId en moet ik zoveel innerjoins hebben?
        }

        private List<ItemBereider> ReadTables(DataTable dataTable)
        {
            List<ItemBereider> items = new List<ItemBereider>();
            foreach (DataRow row in dataTable.Rows)
            {
                
                int? gerechtsStatus = null;
                // Als Status kolom uitgelezen wordt als DBNull.Value betekent dat dit kolom geen waarde heeft in tabel.
                // DataTable gebruikt DBNull.Value waarde, dit is niet hetzelfde als C# null.
                if (row["Status"] != System.DBNull.Value)
                {
                    // Status waarde is niet null in database dus niet "DBNull.Value" we kunnen nu gerechtsStatus zetten naar database waarde.
                    gerechtsStatus = Convert.ToInt32(row["Status"]);
                }

                ItemBereider item = new ItemBereider()
                {
                    BesteldItemId = Convert.ToInt32(row["BesteldItemId"]),
                    Opmerking = row["Opmerking"].ToString(),
                    Instuurtijd = (DateTime)row["Instuurtijd"],
                    //MenuItemId = Convert.ToInt32(row["MenuItemID"]),
                    BestellingsId = Convert.ToInt32(row["BestellingsID"]),
                    Hoeveelheid = Convert.ToInt32(row["Hoeveelheid"]),
                    PersoneelsId = Convert.ToInt32(row["PersoneelsId"]),
                    //Voorraad = Convert.ToInt32(row["Voorraad"]),
                    //Alcoholisch = row["Alcoholisch"].ToString(),
                    //Naam = row["Naam"].ToString(),
                    // Als gerechtsStatus niet is gezet naar database waarde gebruiken we GerechtsStatus.NotStarted als standaard.
                    // Als gerechtsStatus wel is gezet naar database waarde omdat die beschikbaar is Casten we het integer waarde naar GerechtStatus enum
                    Status = gerechtsStatus != null ? (GerechtsStatus)gerechtsStatus : GerechtsStatus.NotStarted

                };
                items.Add(item);
            }
            return items;
        }

       
    }
}

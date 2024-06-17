using Model;
using System.Data;
using System.Data.SqlClient;

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
        public void ChangeStatus(Bestelling bestelling, string ItemBereider)
        {
            string query = $"UPDATE {ItemBereider} SET Status=@Status WHERE BestellingId = @BestellingId;";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Status", bestelling.status),
                new SqlParameter("@BestellingId", bestelling.bestellingId)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public List<Bestelling> GetTafelBestelling(Tafel tafel, string ItemBereider)
        {
            string query = $"SELECT Naam, Bestellingen.BestellingsId, Status, Opmerking, Instuurtijd FROM {ItemBereider} \r\nJOIN Bestellingen ON {ItemBereider}.BestellingId = Bestellingen.BestellingsId\r\nJOIN BesteldeItems ON BesteldeItems.BestellingsId = Bestellingen.BestellingsId\r\nJOIN MenuItems ON MenuItems.MenuItemId = Besteldeitems.MenuItemId WHERE TableNr=@TableNr";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@TableNr", tafel.Id),
            };
            return ReadBestelling(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Bestelling> ReadBestelling(DataTable dataTable)
        {
            List<Bestelling> bestellingen = new List<Bestelling>();
            foreach (DataRow row in dataTable.Rows)
            {
                int bestellingId = Convert.ToInt32(row["BestellingsId"]);
                Bestelling bestelling = bestellingen.Find(b => b.bestellingId == bestellingId);

                if (bestelling == null)
                {
                    bestelling = new Bestelling
                    {
                        bestellingId = bestellingId,
                        status = (GerechtsStatus)Convert.ToInt32(row["Status"])
                    };
                    bestellingen.Add(bestelling);
                }

                BesteldeItem besteldeItem = new BesteldeItem(new MenuItem
                {
                    Naam = row["Naam"].ToString(),
                })
                {
                    Opmerking = row["Opmerking"].ToString(),
                    InstuurTijd = Convert.ToDateTime(row["Instuurtijd"]),
                };

                bestelling.BestellingItems.Add(besteldeItem);
            }
            return bestellingen;
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

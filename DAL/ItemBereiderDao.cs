using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ItemBereiderDao : BaseDao
    {
        public List<BesteldeItem> GetAllItems(int personeelsId)
        {
            string query = @"SELECT BesteldItemId, Opmerking, Instuurtijd,  BesteldeItems.MenuItemId, MenuItems.Naam, BesteldeItems.BestellingsId, Hoeveelheid, 
                            Bestellingen.PersoneelsId,  BesteldeItems.GerechtsStatus FROM BesteldeItems JOIN MenuItems ON (MenuItems.MenuItemId=BesteldeItems.MenuItemId) 
                            JOIN Bestellingen ON Bestellingen.BestellingsId = BesteldeItems.BesteldItemId;";

            
            return ReadTables(ExecuteSelectQuery(query));
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
        private List<BesteldeItem> ReadTables(DataTable dataTable)
        {
            List<BesteldeItem> items = new List<BesteldeItem>();
            foreach (DataRow row in dataTable.Rows)
            {


                BesteldeItem item = new BesteldeItem()
                {
                    BesteldItemId = Convert.ToInt32(row["BesteldItemId"]),
                    Opmerking = row["Opmerking"].ToString(),
                    InstuurTijd = (DateTime)row["Instuurtijd"],
                    //BestellingsID = Convert.ToInt32(row["BestellingsID"]),
                    Hoeveelheid = Convert.ToInt32(row["Hoeveelheid"]),
                    Naam = row["Naam"].ToString(),
                    status = (GerechtsStatus)row["GerechtsStatus"]

                };
                items.Add(item);
            }
            return items;
        }
        public void UpdateStatus(GerechtsStatus status, int besteldeItemId)
        {
            string query = "UPDATE BesteldeItems SET GerechtsStatus = @status WHERE BesteldItemId = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@status", (int)status),
                new SqlParameter("@id", besteldeItemId)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

    }
}

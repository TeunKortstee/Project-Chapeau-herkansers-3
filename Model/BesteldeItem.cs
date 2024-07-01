using System.Runtime.InteropServices;

namespace Model
{
    public class BesteldeItem
    {
        public int BesteldItemId { get; set; }
        public string Opmerking { get; set; }
        public DateTime InstuurTijd { get; set; }
        public MenuItem menuItem { get; set; }
        public Bestelling bestelling { get; set; } //Luciano
        public int Hoeveelheid { get; set; }
        public GerechtsStatus Status { get; set; }
        public string? Naam { get; set; }

        public BesteldeItem(MenuItem menuItem) //Luciano
        {
            Opmerking = "";
            InstuurTijd = DateTime.Now;
            Hoeveelheid = 1;
            this.menuItem = menuItem;
        }

        public BesteldeItem()
        {
            
        }

        public void UpdateOrderStatus(GerechtsStatus status)
        {
            Status = status;
        }
    } 
}

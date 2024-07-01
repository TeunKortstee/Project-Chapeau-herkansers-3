using System.Runtime.InteropServices;

namespace Model
{
    public class BesteldeItem
    {
        public int BesteldItemId { get; set; }
        public string Opmerking { get; set; }
        public DateTime InstuurTijd { get; set; }
        public MenuItem menuItem { get; set; }

        public int Hoeveelheid { get; set; }
        public GerechtsStatus Status { get; set; } //Yusuf
        public string? Naam { get; set; } //Yusuf

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

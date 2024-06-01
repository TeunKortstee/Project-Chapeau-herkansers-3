namespace Model
{
    public class BesteldItem
    {
        public int BesteldItemId { get; set; }
        public string Opmerking { get; set; }
        public DateTime InstuurTijd { get; set; }
        public MenuItem menuItem { get; set; }
        public int Aantal { get; set; }

        public BesteldItem(MenuItem menuItem)
        {
            Opmerking = "";
            InstuurTijd = DateTime.Now;
            Aantal = 1;
            this.menuItem = menuItem;
        }
    }
}

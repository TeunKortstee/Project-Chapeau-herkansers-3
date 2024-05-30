namespace Model
{
    public class BesteldItem
    {
        public int BesteldItemId { get; set; }
        public string Opmerking { get; set; }
        public DateTime InstuurTijd { get; set; }
        public MenuItem menuItem { get; set; }

        public BesteldItem(MenuItem menuItem)
        {
            Opmerking = "";
            InstuurTijd = DateTime.Now;
            this.menuItem = menuItem;
        }
    }
}

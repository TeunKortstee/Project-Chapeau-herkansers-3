namespace Model
{
    public class Personeel
    {
        public int Id { get; set; }
        public string email { get; set; }
        public string VoorNaam { get; set; }
        public string AchterNaam { get; set; }
        public byte[] WachtWoord { get; set; }
        public byte[] Salt { get; set; }
        public Functie Functie { get; set; }
        public float Fooi { get; set; }


    }
}

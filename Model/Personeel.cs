namespace Model
{
    public class Personeel
    {
        public int PersoneelId { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Wachtwoord { get; set; }
        public Functie Functie { get; set; }
        public float Fooi { get; set; }
    }
}

namespace Model
{
    public class Personeel
    {
        public int PersoneelsId { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string email { get; set; }
        public byte[] WachtWoord { get; set; }
        public byte[] Salt { get; set; }
        public Functie Functie { get; set; }

        public Personeel(string voornaam, string achternaam, string wachtwoord, Functie functie)
        {
            this.Voornaam = voornaam;
            this.Achternaam = achternaam;
            this.Wachtwoord = wachtwoord;
            this.Functie = functie;
        }
    }
}

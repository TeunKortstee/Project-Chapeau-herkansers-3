namespace Model
{
    public class Personeel
    {
        private int personeelsId;

        public int PersoneelsId {
            get { return this.personeelsId; } 
        }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Wachtwoord { get; set; }
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

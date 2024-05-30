namespace Model
{
    public class Personeel
    {
        public int PersoneelsId { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string email { get; set; }
        public byte[] Wachtwoord { get; set; }
        public byte[] Salt { get; set; }
        public Functie Functie { get; set; }

        public Personeel()
        {

        }
        public Personeel(string voornaam, string achternaam, string email, Functie functie)
        {
            this.Voornaam = voornaam;
            this.Achternaam = achternaam;
            this.Functie = functie;
        }
    }
}

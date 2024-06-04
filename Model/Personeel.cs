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

        public Personeel()
        {

        }
        public Personeel(string achternaam, string email, byte[] wachtwoord, Functie functie)
        {
            this.AchterNaam = achternaam;
            this.email = email;
            this.WachtWoord = wachtwoord;
            this.Functie = functie;
        }
    }
}

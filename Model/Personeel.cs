namespace Model
{
    public class Personeel
    {
        public int Id { get; set; }
        public string email { get; set; }
        public string AchterNaam { get; set; }
        public string WachtWoord { get; set; }
        public string Salt { get; set; }
        public Functie Functie { get; set; }       

        public Personeel()
        {

        }
        public Personeel(string achternaam, string email, string wachtwoord, string salt, Functie functie)
        {
            this.AchterNaam = achternaam;
            this.email = email;
            this.WachtWoord = wachtwoord;
            this.Salt = salt;
            this.Functie = functie;
        }
    }
}

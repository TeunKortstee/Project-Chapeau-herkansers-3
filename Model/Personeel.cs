namespace Model
{
    public class Personeel
    {
        public int Id { get; set; }
        public string AchterNaam { get; set; }
        public string Email { get; set; }
        public string WachtWoord { get; set; }
        public Functie Functie { get; set; }

        public Personeel()
        {
            Id = 0;
            Email = "";
            AchterNaam = "";
            WachtWoord = "";
            Functie = Functie.Bediening;
        }
        public Personeel(string achternaam, string email, Functie functie)
        {
            this.AchterNaam = achternaam;
            this.Email = email;
            this.Functie = functie;
        }
    }
}

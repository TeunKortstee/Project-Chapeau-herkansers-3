namespace Model
{
    public class Personeel
    {
        public int Id { get; set; }
        public string email { get; set; }
        public string AchterNaam { get; set; }
        public string WachtWoord { get; set; }
        public Functie Functie { get; set; }

        public Personeel()
        {
            Id = 0;
            email = "";
            AchterNaam = "";
            WachtWoord = "";
            Functie = Functie.Serveerder;
        }
        public Personeel(string achternaam, string email, Functie functie)
        {
            this.AchterNaam = achternaam;
            this.email = email;
            this.Functie = functie;
        }
    }
}

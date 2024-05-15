namespace Model
{
    public class Personeel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] Password { get; set; }
        public Functie Functie { get; set; }
        public float Fooi { get; set; }


    }
}

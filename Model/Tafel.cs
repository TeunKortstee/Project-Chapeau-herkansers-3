namespace Model
{
    public class Tafel
    {
        public int Id { get; set; }
        public int Capaciteit { get; set; }
        public Personeel personeel { get; set; }
        public Reservering reservering { get; set; }
        public TafelStatus status { get; set; }


    }
}

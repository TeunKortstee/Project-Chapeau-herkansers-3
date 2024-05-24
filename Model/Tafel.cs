namespace Model
{
    public class Tafel
    {
        public int Id { get; set; }
        public int Capaciteit { get; set; }
        public Personeel personeel { get; set; }
        public Reservering reservering { get; set; }
        public TafelStatus status { get; set; }

        public Tafel(int id, TafelStatus status)
        {
            Id = id;
            this.status = status;
            Capaciteit = 0;
            personeel = new Personeel();
            reservering = new Reservering();
        }
    }
}

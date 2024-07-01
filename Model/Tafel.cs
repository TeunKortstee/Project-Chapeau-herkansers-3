namespace Model
{
    public class Tafel
    {
        public int Id { get; set; }
        public int Capaciteit { get; set; }
        public Personeel personeel { get; set; }
        public Reservering reservering { get; set; }
        public TafelStatus status { get; set; }

        public Tafel() { 
        
        
        }

        public Tafel(int id, int capaciteit, Personeel personeel, Reservering reservering, TafelStatus status)
        {
            Id = id;
            Capaciteit = capaciteit;
            this.personeel = personeel;
            this.reservering = reservering;
            this.status = status;
        }
    }
}

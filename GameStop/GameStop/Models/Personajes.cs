namespace GameStop.Models
{
    public class Personaje
    {
        public int id { get; set; }
        public string? nombre { get; set; }

        virtual public ICollection<Juego>? Juegos { get; set; }
        
    }
}

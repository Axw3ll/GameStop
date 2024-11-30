using System.ComponentModel.DataAnnotations;

namespace GameStop.Models
{
    public class Clasificacion
    {
        public int id { get; set; }
        [Required(ErrorMessage ="El nombre de la clasificacion es obligatorio")]
        public string? nombre { get; set; }

        virtual public ICollection<Juego>? Juegos { get; set; }

    }
}

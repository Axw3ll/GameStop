using System.ComponentModel.DataAnnotations;

namespace GameStop.Models
{
    public class Juego
    {
        public int id { get; set; }
        [Required(ErrorMessage ="El nombre del juego es olbigatorio")]
        public string? name  { get; set; }
        [Required(ErrorMessage = "La descripcion del juego es obligatoria")]
        public string? description { get; set; }

        public int ClasificacionId { get; set; }
        virtual public Clasificacion? Clasificacion { get; set; }
        virtual public ICollection<Personaje>? Personajes { get; set; }


    }
}

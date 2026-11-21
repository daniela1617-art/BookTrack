using System.ComponentModel.DataAnnotations;

namespace BookTrack.Models
{
    public class Libro
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El título es obligatorio")]
        [StringLength(150)]
        public string Titulo { get; set; } = string.Empty;

        [Required(ErrorMessage = "El autor es obligatorio")]
        [StringLength(100)]
        public string Autor { get; set; } = string.Empty;

        [Required(ErrorMessage = "El género es obligatorio")]
        [StringLength(50)]
        public string Genero { get; set; } = string.Empty;

        [Range(1000, 2100, ErrorMessage = "Ingrese un año válido")]
        public int AnioPublicacion { get; set; }

        [Range(0, 10000, ErrorMessage = "La cantidad no puede ser negativa")]
        public int EjemplaresDisponibles { get; set; }
    }
}

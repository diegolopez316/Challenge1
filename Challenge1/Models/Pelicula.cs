using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Challenge1.Models
{
    [Table("Pelicula")]
    public class Pelicula
    {
        [Key]
        public int Id { get; set; }
        public string? Imagen { get; set; }

        [Required]
        public string Denominacion { get; set; }

        public DateTime FechaDeCreacion { get; set; }
        
        [Range(1,5)]
        public int? Calificacion { get; set; }
        
        //TODO: relación con Personajes
        public ICollection<Personaje> PersonajeList { get; set; } = new List<Personaje>();

    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Challenge1.Models
{
    [Table("Personaje")]
    public class Personaje
    {
        [Key]
        public int Id { get; set; }
        public string? Imagen { get; set; }
        
        [Required] // Comando para que en la base de datos este campo sea excluyente.
        public string Denominacion { get; set; }

        public int Edad { get; set; }
        [Required]
        public int Peso { get; set; }
        [Required]
        public string Historia { get; set; }


        public ICollection<Pelicula> Peliculas { get; set; } = new List<Pelicula>();
    }
}

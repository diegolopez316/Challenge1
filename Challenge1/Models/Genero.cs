using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Challenge1.Models
{
    [Table("Genero")] // este va a ser el nombre de la tabla 
    public class Genero
    {
        [Key] //el Id va a ser la Key, o clave primaria de la clase.
        public int Id { get; set; }

        public string? Imagen { get; set; } //? significa que Imagen no es excluyente, puede no estar, a nivel codigo, NO BD
                
        public ICollection<Pelicula> Peliculas { get; set; } = new List<Pelicula>();
    }
}



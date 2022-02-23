namespace Challenge1.Models
{
    public class Genero
    {
        public int Id { get; set; }
        public string? Imagen { get; set; }

        //TODO: relación con peliculas
        public ICollection<Pelicula> Peliculas { get; set; } = new List<Pelicula>();
    }
}



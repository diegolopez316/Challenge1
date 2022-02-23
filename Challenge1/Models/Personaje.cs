namespace Challenge1.Models
{
    public class Personaje
    {
        public int Id { get; set; }
        public string Imagen { get; set; }

        public string Denominacion { get; set; }

        public int Edad { get; set; }

        public int Peso { get; set; }

        public string Historia { get; set; }

        public ICollection<Pelicula> Peliculas { get; set; } = new List<Pelicula>();
    }
}

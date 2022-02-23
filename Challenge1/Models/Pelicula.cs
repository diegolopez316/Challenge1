namespace Challenge1.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Imagen { get; set; }

        public string Denominacion { get; set; }

        public DateTime FechaDeCreacion { get; set; }

        public int Calificacion { get; set; }

        //TODO: relación con Personajes
        public ICollection<Personaje> PersonajeList { get; set; } = new List<Personaje>();

    }
}

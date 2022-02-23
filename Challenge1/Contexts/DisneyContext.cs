using Microsoft.EntityFrameworkCore;
using Challenge1.Models;

namespace Challenge1.Contexts
{
    public class DisneyContext : DbContext
    {
        private const string Schema = "DisneyDatabase";


        public DisneyContext(DbContextOptions<DisneyContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema(Schema);
        }



        public DbSet<Genero> Generos { get; set; } = null!; // <clase> Nombre - lo que solicites de la base de datos retorna como lo tengas modelado
        public DbSet<Pelicula> Peliculas { get; set; } = null!;
        public DbSet<Personaje> Personajes { get; set; } = null!;

    }
}

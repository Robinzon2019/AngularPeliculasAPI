using AngularPeliculasAPI.Entidades;
using Microsoft.EntityFrameworkCore;

namespace AngularPeliculasAPI
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {
        }

        public DbSet<Genero> Generos { get; set; }
    }
}

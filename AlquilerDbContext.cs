using Act18.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Act18.Data
{
    public class AlquilerDBContext : DbContext
    {
        public AlquilerDBContext(DbContextOptions<AlquilerDBContext> options) : base(options)
        {
        }

        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Alquiler> Alquileres { get; set; }
    }
}
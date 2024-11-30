using Microsoft.EntityFrameworkCore;

namespace GameStop.Models
{
    public class GameStopDBContext : DbContext
    {
        public GameStopDBContext(DbContextOptions<GameStopDBContext> options) : base(options) 
        { 
        
        }

        public DbSet<Juego> Juegos { get; set; }

        public DbSet<Clasificacion> Clasificaciones { get; set; }
        public DbSet<Personaje> Personajes { get; set; }

    }
}

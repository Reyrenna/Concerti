using Concerti.Models;
using Microsoft.EntityFrameworkCore;

namespace Concerti.Data
{
    public class EventiDbContext : DbContext
    {
        public EventiDbContext(DbContextOptions<EventiDbContext> options) : base(options)
        {}
        public DbSet<User> Users { get; set; }
        public DbSet<Biglietto> Bigliettos { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Artisti> Artistis { get; set; }
    }
}

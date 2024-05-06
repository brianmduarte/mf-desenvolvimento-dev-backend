using Microsoft.EntityFrameworkCore;

namespace mf_desenvolvimento_dev_backend.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuario { get; set; }
    }
}

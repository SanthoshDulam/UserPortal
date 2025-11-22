using Microsoft.EntityFrameworkCore;

namespace UserPortal.Models
{
    // App DB context - EF Core
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}

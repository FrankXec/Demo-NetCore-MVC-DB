using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class BarContext : DbContext
    {
        public BarContext(DbContextOptions<BarContext> options) 
            : base(options)
        { 

        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Beer> Beers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().ToTable("Brand");
            modelBuilder.Entity<Beer>().ToTable("Beer");
        }

    }
}
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Aircraft_ASP.NET_MVC_.Data
{
    using Aircraft_ASP.NET_MVC_.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    

    public class AircraftDbContext : IdentityDbContext
    {
        public AircraftDbContext(DbContextOptions<AircraftDbContext> options)
            : base(options)
        {
        }
        public DbSet<Aircraft> Airplanes { get; set; }
        public DbSet<Destination> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Aircraft>()
                .HasOne(c => c.Category)
                .WithMany(c => c.Airplanes)
                .HasForeignKey(c => c.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }
    }
}

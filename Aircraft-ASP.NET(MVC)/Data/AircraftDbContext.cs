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
        public DbSet<Airplane> Airplanes { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Airplane>()
                .HasOne(c => c.Category)
                .WithMany(c => c.Airplanes)
                .HasForeignKey(c => c.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }
    }
}

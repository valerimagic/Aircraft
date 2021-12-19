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
    }
}

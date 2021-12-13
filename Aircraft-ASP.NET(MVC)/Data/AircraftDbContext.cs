namespace Aircraft_ASP.NET_MVC_.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class AircraftDbContext : IdentityDbContext
    {
        public AircraftDbContext(DbContextOptions<AircraftDbContext> options)
            : base(options)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aircraft_ASP.NET_MVC_.Data;
using Aircraft_ASP.NET_MVC_.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Aircraft_ASP.NET_MVC_.Infrastructure
{
    public static class AplicationBuilderExtension
    {
        public static IApplicationBuilder PrepareDatabase(this IApplicationBuilder app) //ext metod koito se griji da podgotvi DB, извикава метод върху интерфейса
        {
            using var scopedServiced = app.ApplicationServices.CreateScope();
            var data = scopedServiced.ServiceProvider.GetService<AircraftDbContext>();

            data.Database.Migrate();
            SeedCategories(data);



            return app;
        }

        private static void SeedCategories(AircraftDbContext data)
        {
            if (data.Categories.Any())
            {
                return;
            }
            
            data.Categories.AddRange(new []
            {
                new Destination{Name = "London"},
                new Destination{Name = "Paris"},
                new Destination{Name = "New York"},
                new Destination{Name = "Tokyo"},
                new Destination{Name = "Rome"},
                new Destination{Name = "Sofia"},
            });
            data.SaveChanges();
        }
    }

    
}

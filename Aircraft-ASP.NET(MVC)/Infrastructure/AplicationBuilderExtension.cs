using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace Aircraft_ASP.NET_MVC_.Infrastructure
{
    public static class AplicationBuilderExtension
    {
        public static IApplicationBuilder PrepareDatabase(this IApplicationBuilder app) //ext metod koito se griji da podgotvi DB, извикава метод върху интерфейса
        {
            return app;
        }
    }

    
}

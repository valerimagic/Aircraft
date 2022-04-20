using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircraft_ASP.NET_MVC_.Data.Models
{
    public class Passengers
    { 
        public int Id { get; set; }
        public string Name { get; init; }
        public int Age { get; set; }
        public IEnumerable<Aircraft> Airplanes { get; set; } = new List<Aircraft>();
    }
}

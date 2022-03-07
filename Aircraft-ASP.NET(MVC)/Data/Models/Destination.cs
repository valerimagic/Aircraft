using System.Collections.Generic;

namespace Aircraft_ASP.NET_MVC_.Data.Models
{
    public class Destination
    {
        public int Id { get; set; }
        public string Name { get; init; }
        public IEnumerable<Aircraft> Airplanes { get; set; } = new List<Aircraft>();
    }
}

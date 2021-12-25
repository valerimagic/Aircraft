using System.Collections.Generic;

namespace Aircraft_ASP.NET_MVC_.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Airplane> Airplanes { get; set; } = new List<Airplane>();
    }
}

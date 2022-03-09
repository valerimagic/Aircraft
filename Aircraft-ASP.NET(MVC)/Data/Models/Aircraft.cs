namespace Aircraft_ASP.NET_MVC_.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static DataConstants;
    public class Aircraft
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(AirPlaneBrandMaxLength)]
        public string Destination { get; set; }

        [Required]
        [MaxLength(AirPlaneModelMaxLength)]
        public string Model { get; set; }

        [Required]
        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public int Year { get; set; }

        public int CategoryId { get; set; }

        public Destination Category { get; set; }
    }
}

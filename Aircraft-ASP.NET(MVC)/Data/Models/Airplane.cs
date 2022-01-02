namespace Aircraft_ASP.NET_MVC_.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static DataConstants;
    public class Airplane
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(AirPlaneBrandMaxLength)]
        public string Brand { get; init; }

        [Required]
        [MaxLength(AirPlaneModelMaxLength)]
        public string Model { get; init; }

        [Required]
        public string Description { get; init; }

        public string ImageUrl { get; init; }

        public int Year { get; init; }

        public int CategoryId { get; init; }

        public Category Category { get; init; }
    }
}

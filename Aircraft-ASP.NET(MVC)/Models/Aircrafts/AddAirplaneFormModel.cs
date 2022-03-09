namespace Aircraft_ASP.NET_MVC_.Models.Aircrafts
{
    public class AddAirplaneFormModel
    {
        
        public string Destination { get; init; }
        
        public string Model { get; init; }
        
        public string Description { get; init; }

        public string ImageUrl { get; init; }

        public int Year { get; init; }

        public int CategoryId { get; init; }
    }
}

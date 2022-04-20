using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aircraft_ASP.NET_MVC_.Models.Aircrafts
{
    public class AddPassengersFormModel
    {
        public string DestinationFrom { get; init; }
        public string DestinationTo { get; init; }

        public string Description { get; init; }

        [Display(Name = "Add File")]
        public string ImageUrl { get; init; }

        public int Year { get; init; }

        //public int CategoryId { get; init; }

        //public IEnumerable<AirplaneCategoryViewModel> Categories { get; set; }
    }
}

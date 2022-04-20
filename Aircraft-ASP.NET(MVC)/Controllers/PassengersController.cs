using Aircraft_ASP.NET_MVC_.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircraft_ASP.NET_MVC_.Controllers
{
    public class PassengersController : Controller
    {
        private readonly AircraftDbContext data;

        public PassengersControllerController(AircraftDbContext data) => this.data = data;

        public IActionResult Add() => View(new AddAirplaneFormModel
        {
            Categories = this.GetAirplaneCategories()
        });


        [HttpPost]
        public IActionResult Add(AddAirplaneFormModel plane)
        {
            return View();
        }

        private IEnumerable<AirplaneCategoryViewModel> GetAirplaneCategories()
            => this.data
                .Categories
                .Select(c => new AirplaneCategoryViewModel
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToList();
    }
    }
}

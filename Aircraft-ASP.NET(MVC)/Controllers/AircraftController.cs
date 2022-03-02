using Aircraft_ASP.NET_MVC_.Models.Aircrafts;

namespace Aircraft_ASP.NET_MVC_.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class AircraftController : Controller
    {
        public IActionResult Add() => View();

        [HttpPost]
        public IActionResult Add(AddAirplaneFormModel plane)
        {
            return View();
        }
    }
}

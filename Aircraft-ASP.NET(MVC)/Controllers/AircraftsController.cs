using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aircraft_ASP.NET_MVC_.Models.Aircrafts;
using Microsoft.AspNetCore.Mvc;

namespace Aircraft_ASP.NET_MVC_.Controllers
{
    public class AircraftsController : Controller
    {
        public IActionResult Add() => View();

        [HttpPost]
        public IActionResult Add(AddAirplaneFormModel plane)
        {
            return View();
        }
    }
}

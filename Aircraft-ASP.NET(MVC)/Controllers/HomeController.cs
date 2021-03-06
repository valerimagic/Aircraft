namespace Aircraft_ASP.NET_MVC_.Controllers
{
    using System.Diagnostics;
    using Aircraft_ASP.NET_MVC_.Models;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Passeners() => View();



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

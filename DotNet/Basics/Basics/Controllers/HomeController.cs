using Basics.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Basics.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            TempData["address"] = "North Nazimabad";
            TempData.Keep();
            return View();
        }

        public IActionResult About()
        {

            TempData.Keep();
            ViewBag.name = "Owais Ahmed Khan";
            ViewBag.designation = "Software Developer";

            ViewData["email"] = "owaisk23@gmail.com";
            ViewData["city"] = "Karachi";

            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
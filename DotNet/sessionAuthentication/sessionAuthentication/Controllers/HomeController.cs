using Microsoft.AspNetCore.Mvc;
using sessionAuthentication.Models;
using System.Diagnostics;

namespace sessionAuthentication.Controllers
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
            if (HttpContext.Session.GetString("role") == "user")
            {
                ViewBag.adminEmail = HttpContext.Session.GetString("userEmail");
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Admin");
            }
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
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string email,string pswd)
        {

            if(email=="admin@gmail.com" && pswd=="aptech")
            {

                TempData["abc"] = "hello" + email;
                TempData.Keep();
                return RedirectToAction("Privacy");
             
            }

            return View();
        }
        public IActionResult Privacy()
        {
            TempData.Keep();

            return View();
        }
        [HttpGet]
        public IActionResult my()
        {
      

            return View();
        }
        [HttpPost]
        public IActionResult my(IFormCollection frm)
        {
            string name = frm["email"];
            string pass = frm["pswd"];
            ViewBag.a = name;

            return View();
        }
    }
}
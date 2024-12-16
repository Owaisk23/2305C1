using Microsoft.AspNetCore.Mvc;

namespace sessionAuthentication.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("role") == "admin")
            {
                ViewBag.adminEmail = HttpContext.Session.GetString("adminEmail");
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
            
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string email, string pwd)
        {
            if (email == "admin@gmail.com" && pwd == "123")
            {
                HttpContext.Session.SetString("adminEmail", email);
                HttpContext.Session.SetString("role", "admin");

                return RedirectToAction("Index");



            }
            else if (email == "client@gmail.com" && pwd == "123")
            {

                HttpContext.Session.SetString("clientEmail", email);
                HttpContext.Session.SetString("role", "client");
                return RedirectToAction("Index", "Client");

            }
            else if (email == "haris@gmail.com" && pwd == "123")
            {

                HttpContext.Session.SetString("userEmail", email);
                HttpContext.Session.SetString("role", "user");
                return RedirectToAction("Index", "Home");

            }
            else
            {
                ViewBag.msg = "Invalid Credentials";
                return View();
            }
        }
    }
}

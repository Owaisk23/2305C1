using Microsoft.AspNetCore.Mvc;

namespace sessionAuthentication.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("role") == "client")
            {
                ViewBag.adminEmail = HttpContext.Session.GetString("clientEmail");
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Admin");
            }
        }
    }
}

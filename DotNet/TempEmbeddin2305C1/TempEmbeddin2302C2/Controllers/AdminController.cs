using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using TempEmbeddin2302C2.Models;

namespace TempEmbeddin2302C2.Controllers
{
    public class AdminController : Controller
    {
        [Authorize(Roles ="Admin")]
        public IActionResult Index()
        {
            return View();

            //if(HttpContext.Session.GetString("role") == "admin")
            //{

            //return View();
            //}
            //else
            //{
            //    return RedirectToAction("Login");
            //}
        }
        public IActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddUser(User user)
        {
            if (ModelState.IsValid)
            {
                return Content("Data is all good to be inserted in database");
            }
            else
            {

            return View();
            }
        }


        public IActionResult Login()                                                              
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email,string pass)
        {
            if(email=="admin@gmail.com" && pass== "123")
            {
                HttpContext.Session.SetString("role","admin");
                HttpContext.Session.SetString("email",email);
                return RedirectToAction("Index");


            }else if (email == "user@gmail.com" && pass == "123")
            {
                HttpContext.Session.SetString("role", "user");
                HttpContext.Session.SetString("email", email);
                return RedirectToAction("Index","Home");
            }
            else if (email == "owais@gmail.com" && pass == "123")
            {
                HttpContext.Session.SetString("role", "client");
                HttpContext.Session.SetString("email", email);
                return RedirectToAction("Index", "Client");
            }
            else
            {
                ViewBag.msg = "Invalid credentials";
            return View();
            }
        }


        public IActionResult AdminLogout()
        {
            HttpContext.Session.Clear();
            HttpContext.Session.Remove("role");
            HttpContext.Session.Remove("email");
            return RedirectToAction("Login");

        }


    }
}

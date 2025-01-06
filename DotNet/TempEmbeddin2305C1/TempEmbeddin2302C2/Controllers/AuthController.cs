using System.Security.Claims;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using TempEmbeddin2302C2.Models;

namespace TempEmbeddin2302C2.Controllers
{
    public class AuthController : Controller
    {
        private readonly _2302c2ecommerceContext db;
        public AuthController(_2302c2ecommerceContext _db)
        {
            db = _db;
        }
        public IActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Signup(User user)
        {
            var checkUser = db.Users.FirstOrDefault(a => a.Email == user.Email);
            if (checkUser == null)
            {
                var hasher = new PasswordHasher<string>();
                string hashPassword = hasher.HashPassword(user.Email, user.Password);

                user.Password = hashPassword;
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Login");

            }
            else
            {
             ViewBag.msg = "User Already registered. Please Login.";
            return View();
            }
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            bool isAuthenticated = false;
            
            ClaimsIdentity identity = null;
            string controller = "";

            var checkUser = db.Users.FirstOrDefault(a => a.Email == user.Email);
            if (checkUser != null)
            {
                var hasher = new PasswordHasher<string>();
                var verifyPass = hasher.VerifyHashedPassword(user.Email, checkUser.Password ,user.Password);
                if(verifyPass== PasswordVerificationResult.Success && checkUser.RoleId==1)
                {
                    identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name,checkUser.Username ),
                    new Claim(ClaimTypes.Role, "Admin"),
                    new Claim(ClaimTypes.Sid, checkUser.Id.ToString()),
                }, CookieAuthenticationDefaults.AuthenticationScheme);

                    isAuthenticated = true;
                    controller = "Admin";

                    HttpContext.Session.SetInt32("UserID", checkUser.Id);
                    HttpContext.Session.SetString("UserEmail", checkUser.Email) ;


                }
                else if( verifyPass == PasswordVerificationResult.Success && checkUser.RoleId == 2)
                {
                    identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name,checkUser.Username ),
                    new Claim(ClaimTypes.Role, "User"),
                    new Claim(ClaimTypes.Sid, checkUser.Id.ToString())
                }, CookieAuthenticationDefaults.AuthenticationScheme);


                    isAuthenticated = true;
                    controller = "Home";
                    HttpContext.Session.SetInt32("UserID", checkUser.Id);
                    HttpContext.Session.SetString("UserEmail", checkUser.Email); 
                }
                else
                {
                    ViewBag.msg = "Invalid Credentials";
                    return View();

                }

                if (isAuthenticated)
                {
                    var principal = new ClaimsPrincipal(identity);

                    var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                    return RedirectToAction("Index",controller);

                }
               
                else
                {
                    ViewBag.msg = "Login Failed";
                    return View();
                }



            }
            else
            {
                ViewBag.msg = "Invalid User";
                return View();
            }

            
            
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("UserID");
            HttpContext.Session.Remove("UserEmail");
            HttpContext.Session.Clear();
            var login = HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Login", "Auth");
        }
    }
}

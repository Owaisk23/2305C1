using System.Diagnostics;

using _2302b1TempEmbedding.Models;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using TempEmbeddin2302C2.Models;

namespace TempEmbeddin2302C2.Controllers
{
    public class HomeController : Controller
    {
        private readonly _2302c2ecommerceContext db;

        public HomeController(_2302c2ecommerceContext _db)
        {
            db = _db;
        }

     
        [Authorize]
        public IActionResult Index()
        {
            return View();
         
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            TempData.Keep("phone");
            return View();
        }

        public IActionResult Products()
        {
            //TempData.Keep("msg");
            var data = db.Items.Include(item => item.Cat);
            return View(data.ToList());
        }

        [Authorize (Roles ="User")]
        public IActionResult Details(int id)
        {
            var data = db.Items.Include(item => item.Cat);
            var item = data.FirstOrDefault(prd =>prd.Id == id );

           if(item != null)
            {
                Cart cart = new Cart();
                ViewBag.Cart = cart;

            return View(item);
            }
            else
            {
            return RedirectToAction("Products");
            }
            
        }
        [Authorize(Roles = "User")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddToCart(Cart cart)
        {
            var Duplicate= db.Carts.FirstOrDefault(c => c.ItemId == cart.ItemId && c.UserId==cart.UserId);
            if (Duplicate != null) {


                Duplicate.Qty += cart.Qty; // = 2 + 1 
                Duplicate.Total = Duplicate.Qty * Duplicate.Price;

            
                db.Carts.Update(Duplicate);
                db.SaveChanges();
               TempData["msg"] = "Cart updated successfully.";
;            }
            else {
                cart.Total = cart.Price * cart.Qty;
                db.Carts.Add(cart);
                db.SaveChanges();
                TempData["msg"] = "Product added to cart successfully.";


            }


            
            return RedirectToAction("Products");
        }

        public IActionResult MyCart()
        {
            var userId = Convert.ToInt32(HttpContext.Session.GetInt32("UserID"));

            var cartItems = from cart in db.Carts
                            join item in db.Items on cart.ItemId equals item.Id
                            where cart.UserId == userId
                            select new CartViewModel
                            {
                                CartId = cart.Id,
                                ProductName = item.Name,
                                Description = item.Description,
                                Price = item.Price,
                                Quantity = cart.Qty,
                                TotalPrice = cart.Total,
                            };

            if (cartItems != null)
            {

                return View(cartItems);

            }
            else
            {
                ViewBag.msg = "No products found. Shop now";
                return View(cartItems);
            }

        }

        public IActionResult Checkout(int userid, int total)
        {
            ViewBag.total = total;

            return View();
        }


    }
}
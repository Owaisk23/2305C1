using Dbfirst.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Dbfirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductsContext db;

        public HomeController(ProductsContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult EditProduct(int id)
        {
            var product = db.Products.FirstOrDefault(x => x.Id == id);
            return View(product);
        }
        [HttpPost]
        public IActionResult EditProduct(Product product)
        {
            db.Products.Update(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProduct(int id)
        {
            var product = db.Products.FirstOrDefault(x => x.Id == id);
            return View(product);
        }
        [HttpPost]
        public IActionResult DeleteProductreq(int id)
        {
            var product1 = db.Products.FirstOrDefault(x => x.Id == id);
            db.Products.Remove(product1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DetailProduct(int id)
        {
            var product = db.Products.FirstOrDefault(x => x.Id == id);
            return View(product);
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
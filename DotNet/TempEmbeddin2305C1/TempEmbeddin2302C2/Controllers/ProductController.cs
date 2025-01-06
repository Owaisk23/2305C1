using Microsoft.AspNetCore.Mvc;

using TempEmbeddin2302C2.Models;

namespace TempEmbeddin2302C2.Controllers
{
    public class ProductController : Controller
    {
        _2302c2ecommerceContext db = new _2302c2ecommerceContext();
        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product prd)
        {
            if(ModelState.IsValid)
            {
                db.Products.Add(prd);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            else
            {
            return View();
            }
           
        }
        public IActionResult Edit(int id)
        {
            var product= db.Products.Find(id);
            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product prd)
        {
            if (ModelState.IsValid)
            {
                db.Products.Update(prd);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Delete(int id)
        {
            var product = db.Products.Find(id);
            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Product prd)
        {
               db.Products.Remove(prd);
                db.SaveChanges();
                return RedirectToAction("Index");

          

        }


    }
}

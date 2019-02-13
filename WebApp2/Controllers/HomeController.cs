using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp2.Models;
namespace WebApp2.Controllers
{
    public class HomeController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        
        // GET: Home
        public ActionResult Index()
        {
            var cat = from u in db.Categories select u;
            if(cat!=null)
            {
                ViewBag.Category = cat;
            }
            return View();
        }

        public ActionResult FormTest(string urunadi,string fiyat,string kategori)
        {
            Products p = new Products();
            p.ProductName = urunadi;
            p.UnitPrice = Convert.ToDecimal(fiyat);
            p.CategoryID = Convert.ToInt32(kategori);

            db.Products.Add(p);
            db.SaveChanges();
            var product = from pp in db.Products select pp;

            return View(product.ToList());
        }
    }
}
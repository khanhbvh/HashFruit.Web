using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HashFruit.Web.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            ViewBag.Title = "Product";
            return View();
        }

        public ActionResult Detail()
        {
            ViewBag.Title = "Product Detail";
            return View();
        }
    }
}
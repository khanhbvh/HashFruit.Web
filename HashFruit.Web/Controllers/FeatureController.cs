using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HashFruit.Web.Controllers
{
    public class FeatureController : Controller
    {
        // GET: Feature
        public ActionResult Index()
        {
            ViewBag.Title = "Feature";
            return View();
        }

        public ActionResult Detail()
        {
            ViewBag.Title = "Feature Detail";
            return View();
        }
    }
}
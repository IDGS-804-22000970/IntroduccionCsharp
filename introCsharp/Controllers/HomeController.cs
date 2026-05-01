using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace introCsharp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Tadeo de Jesus Morales Fernandez.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "IDGS904.";

            return View();
        }
    }
}
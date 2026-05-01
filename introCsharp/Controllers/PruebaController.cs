using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace introCsharp.App_Start
{
    public class PruebaController: Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Tadeo Morales.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Tadeo Morales.";

            return View();
        }


        //GET
        public ActionResult Suma()
        {
            return View();
        }

        //POST
        [HttpPost]
        public ActionResult Suma(string x, string y, string r1)
        {
            int res = Convert.ToInt16(x + y) + Convert.ToInt16(y);
            ViewBag.Res = Convert.ToString(res);

            return View();
        }

    }
}
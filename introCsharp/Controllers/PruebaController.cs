using System;
using introCsharp.Services;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using introCsharp.Models;

namespace introCsharp.Controllers
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
            int res = Convert.ToInt32(x) + Convert.ToInt32(y);
            ViewBag.Res = Convert.ToString(res);

            return View();
        }

        public ActionResult Calculos(OperasBas op)
        {
            op.Suma();
            return View(op);
        }

        public ActionResult MuestraPeliculas()
        {
            var PeliculasService = new PeliculasServices();
            var model = PeliculasService.ObtenerPelicula();

            return View(model);
        }

        public ActionResult CalcularDis()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CalcularDis(CalcularDis dis)
        {
            dis.Distancia();

            return View(dis);
        }


        public ActionResult Multiplicacion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Multiplicacion(Multiplicacion mul)
        {
            mul.Multiplicar();

            return View(mul);
        }

    }
}
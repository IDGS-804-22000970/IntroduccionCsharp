using introCsharp.Models;
using System.Web.Mvc;

namespace introCsharp.Controllers
{
    public class MultiplicacionController : Controller
    {
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
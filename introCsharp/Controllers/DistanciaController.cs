using introCsharp.Models;
using System.Web.Mvc;

namespace introCsharp.Controllers
{
    public class DistanciaController : Controller
    {
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
    }
}
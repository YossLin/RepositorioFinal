using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PK1_YOSS.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var hour = DateTime.Now.Hour;
            var segundos = DateTime.Now.Second;
            var minutos = DateTime.Now.Minute;
            ViewBag.Dias = hour < 12 ? "Buenos Dias !!" : "Buenas Tardes!!";
            ViewBag.Horas = hour;
            ViewBag.Minutos = minutos;
            ViewBag.Segundos = segundos;
            return View();
        }

    }
}

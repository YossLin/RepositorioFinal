using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PK2_RSVPwapp.Models;

namespace PK2_RSVPwapp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var hour = DateTime.Now.Hour;

            ViewBag.Greeting = hour < 12 ?  "¡ ¡ ¡ * Hola Muy Buen Dia * ! ! !" : "¡ ¡ ¡ * Hola Muy Buena Tarde * ! ! !";
            return View();
        }
        // Get:  /Home/RsvpForm
        //Renderea al link de la forma RSVP
        public ViewResult RsvpForm()
        {
            return View();
        }


        // Responde  un POST: /Home/RsvpForm
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            // TODO: Enviar respuesta al correo del ordenador 
            //return View("Agradecimientos", guestResponse);  //primera vz 

            //verificando errores de validacion
            if (ModelState.IsValid)
            {
                return View("Agradecimientos", guestResponse);
            }
            else
            {
                //Hay un problema de Validacion 
                return View();
            }

        }

    }
}
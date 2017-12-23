using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaPresentacion.Controllers
{
    public class HomeController : Controller
    {
        //Pagina de Inicio. No se requieren condiciones para estar aqui.
        public ActionResult Index()
        {
            return View();
        }
    }
}
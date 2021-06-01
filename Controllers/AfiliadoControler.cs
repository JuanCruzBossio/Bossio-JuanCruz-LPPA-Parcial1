using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ParcialLPPA.Negocios;

namespace ParcialLPPA.Controllers
{
    public class AfiliadoControler:Controller
    {
        public ActionResult Index()
        {
            var neg = new AfiliadoNegocio();
            var lista = neg.Listar();
            return View(lista);
        }
    }
}
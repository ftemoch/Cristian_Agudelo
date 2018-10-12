using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Parcial2.Models;

namespace Parcial2.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Lista()
        {
            var Clientes = new Clientes()
            {   
                ID = 1,
                Nombre = "Cristian Camilo",
                Apellido = "Agudelo Rivera",
                Sueldo = 100000
                //Crear View
            };
            return View();
        }
    }
}
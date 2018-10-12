using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            var Movie = new Movie()
            {
                Dir = "Friend request",
                Nombre = "123"
                //Crear View
            };
            return View(Movie);
        }
    }
}

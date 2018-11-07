using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Clase12.Models;
using Clase12.Controllers;
using Clase12.ViewModels;

namespace Clase12.Controllers
{
    public class ClientesController : Controller
    {
        private ApplicationDbContext _context;
        public ClientesController()
        {
            _context = new ApplicationDbContext();

        }
        protected override void Dispose (bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Lista(){
            //var clientes = GetClientes();

            var clientes = _context.Clientes.ToList();
                return View(clientes);
        }
        public ActionResult Details(int id)
        {
            var cliente = GetClientes().SingleOrDefault(c => c.ID == id);
            //var cliente = ContextClientes().SingleOrDefault(c => c.ID == id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        public ActionResult Nueva()
        {
            var tipoClientes = _context.tipoClientes.ToList();
            var ViewModel = new NewClienteViewModel
            {
                TipoClientes = tipoClientes
            }
            return View(ViewModel);
        }

        public ActionResult Create(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        private IEnumerable<Cliente> GetClientes()
        {
            return new List<Cliente>
            {
                new Cliente { ID=1, Nombre="Cristian Agudelo"},

                new Cliente { ID=2, Nombre="Mary williamns"}
            };
        }
    }
    
}
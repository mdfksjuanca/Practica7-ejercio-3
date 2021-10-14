using AppMVC01.Datos;
using AppMVC01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppMVC01.Controllers
{
    public class CustomerController : Controller
    {
        CustomerAdmin admin = new CustomerAdmin();
        // GET: Customer
        public ActionResult Index()
        {
            return View(admin.Consultar());
        }
        public ActionResult Detalle(int id)
        {
            return View(admin.Consultar(id));
        }
        public ActionResult Crear()
        {
            return View();
        }
        public ActionResult Guardar(CLIENTES modelo)
        {
            admin.Guardar(modelo);
            return View("Crear", modelo);
        }
        public ActionResult Editar(int id)
        {
            return View(admin.Consultar(id));
        }
        public ActionResult Modificar(CLIENTES modelo)
        {
            admin.Modificar(modelo);
            return View("Editar", modelo);
        }
        public ActionResult Eliminar(int id)
        {
            CLIENTES modelo = admin.Consultar(id);
            admin.Eliminar(modelo);
            return View("Index", admin.Consultar());
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Venta_Motos_Web.Models;
using System.Web.Helpers;
using System.Web.Security;

namespace Venta_Motos_Web.Controllers
{
    public class ClientesController : Controller
    {
        DB_Ventas_AutomovilesContext db = new DB_Ventas_AutomovilesContext();

        public ActionResult Listado()
        {
            var consulta = from datos in db.Tbl_Clientes
                           orderby datos.cli_cedula ascending
                           select datos;
            IEnumerable<Tbl_Motos> inventario = consulta.ToList();
            return View(inventario);
        }// fin del metodo Listado

        [HttpGet]
        public ActionResult Registrar()
        {
            Models.ClientesModel datos = new Models.ClientesModel();
            var maximo = ((from id in db.Tbl_Clientes select (int?)id.inv_codigo).Max()) + 1;
            if (maximo == null)
            {
                maximo = 0;
                datos.inv_codigo = Convert.ToString(1);
                //Creo una lista de elementos y le agrego 2 elementos para
                //mostrar en el comboBox
                List<SelectListItem> lista = new List<SelectListItem>()
                {
                    new SelectListItem(){Value="A", Text="Activo"},
                    new SelectListItem(){Value="N", Text="Nulo"},
                };
                //cargo mi Lista ubicada en el modelo con los elementos de la lista anterior
                datos.estado = new SelectList(lista, "Value", "Text");

                return View(datos);
            }
            else
            {
                datos.inv_codigo = Convert.ToString(maximo);
                //Creo una lista de elementos y le agrego 2 elementos para
                //mostrar en el comboBox
                List<SelectListItem> lista = new List<SelectListItem>()
                {
                    new SelectListItem(){Value="A", Text="Activo"},
                    new SelectListItem(){Value="N", Text="Nulo"},
                };
                //cargo mi Lista ubicada en el modelo con los elementos de la lista anterior
                datos.estado = new SelectList(lista, "Value", "Text");
                return View(datos);
            }
        }//fin del metodo HttpGet de Registrar






        // GET: Clientes
        public ActionResult Index()
        {
            return View();
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clientes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

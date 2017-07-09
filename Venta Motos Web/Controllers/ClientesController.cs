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
                           orderby datos.cli_Cedula ascending
                           select datos;
            IEnumerable<Tbl_Clientes> inventario = consulta.ToList();
            return View(inventario);
        }// fin del metodo Listado

        [HttpGet]
        public ActionResult Registro()
        {
            DB_Ventas_AutomovilesContext db = new DB_Ventas_AutomovilesContext();
            ClientesModel clientes = new ClientesModel();
            var maximo = (from registro in db.Tbl_Clientes select registro.cli_Cedula).Max();


            if (maximo == null)
            {
                maximo = Convert.ToString(0);

            }
            maximo += 1;

            clientes.cli_Cedula = maximo;

            return View("Registro", clientes);
        }

        [HttpPost]
        public ActionResult Registro(ClientesModel clientes)
        {
            if (ModelState.IsValid)
            {
                DB_Ventas_AutomovilesContext db = new DB_Ventas_AutomovilesContext();
                var var_cli = db.Tbl_Clientes.Create();
                //se pasan los datos del modelo al usuario nuevo
                var_cli.cli_Cedula = clientes.cli_Cedula;
                var_cli.cli_Nombre = clientes.cli_Nombre;
                var_cli.cli_Telefono = clientes.cli_Telefono;
                var_cli.cli_Direccion = clientes.cli_Direccion;             
                db.Tbl_Clientes.Add(var_cli);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "El registro fue incorrecto");
                return View("Registro");
            }
        }

        [HttpGet]
        public ActionResult Modificar()
        {
            //Se crea un objeto modelo
            ClientesModel clientes= new ClientesModel();
            clientes.cli_Cedula= 0;

            return View(clientes);
        }

        [HttpPost]
        public ActionResult Modificar(ClientesModel clientes)
        {
            if (ModelState.IsValid)
            {
                DB_Ventas_AutomovilesContext db = new DB_Ventas_AutomovilesContext();
                var producto = db.Tbl_Clientes.FirstOrDefault(u => u.cli_Cedula== clientes.cli_Cedula);

                if (producto != null)
                {
                    producto.cli_Cedula = clientes.cli_Cedula;
                    producto.cli_Nombre = clientes.cli_Nombre;
                    producto.cli_Telefono = clientes.cli_Telefono;
                    producto.cli_Direccion = clientes.cli_Direccion;

                    db.SaveChanges();
                    return RedirectToAction("Index", "Clientes");
                }
                else
                {
                    ModelState.AddModelError("Error", "No se logró encontrar el cliente");
                }
            }
            else
            {
                ModelState.AddModelError("Error", "No se logró modificar el cliente");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Eliminar(int cod)
        {
            DB_Ventas_AutomovilesContext db = new DB_Ventas_AutomovilesContext();
            var cli = db.Tbl_Clientes.FirstOrDefault(u => u.cli_Cedula == Convert.ToString(cod));
            
            ClientesModel producto = new ClientesModel();
            producto.cli_Cedula = cli.cli_Cedula;
            producto.cli_Nombre = cli.cli_Nombre;
            producto.cli_Telefono = cli.cli_Telefono;
            producto.cli_Direccion = cli.cli_Direccion;

            return View(producto);
        }

        [HttpPost]
        public ActionResult Eliminar(ClientesModel clientes)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    DB_Ventas_AutomovilesContext db = new DB_Ventas_AutomovilesContext();
                    var cli = db.Tbl_Clientes.FirstOrDefault(i => i.cli_Cedula== clientes.cli_Cedula);
                    db.Tbl_Clientes.Remove(cli);
                    db.SaveChanges();
                    return RedirectToAction("Listado", "Clientes");
                }
                else
                {
                    ModelState.AddModelError("Error", "No se logró eliminar el cliente");
                    return View(clientes);
                }
            }
            catch
            {
                ModelState.AddModelError("Error", "No se logró eliminar el cliente");
                return View(clientes);
            }
        }

        [HttpGet]
        public ActionResult Detalles(ClientesModel clientes)
        {
            return View(clientes);
        }

    }
}

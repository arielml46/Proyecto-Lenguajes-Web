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
    public class MotoController : Controller
    {
        // GET: Moto
        public ActionResult Index()
        {
            return View();
        }

        // GET: Moto/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Moto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Moto/Create
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

        // GET: Moto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Moto/Edit/5
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

        // GET: Moto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Moto/Delete/5
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

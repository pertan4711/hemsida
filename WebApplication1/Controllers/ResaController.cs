using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ResaController : Controller
    {
        // GET: Resa
        public ActionResult Index()
        {
            return View();
        }

        // GET: Resa/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Resa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Resa/Create
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

        // GET: Resa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Resa/Edit/5
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

        // GET: Resa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Resa/Delete/5
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web.Controllers
{
    public class CostumerController : Controller
    {
        // GET: Costumer
        public ActionResult Index()
        {
            return View();
        }

        // GET: Costumer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Costumer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Costumer/Create
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

        // GET: Costumer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Costumer/Edit/5
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

        // GET: Costumer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Costumer/Delete/5
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

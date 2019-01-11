using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EstabCadastros.Controllers
{
    public class EstabelecimentosController : Controller
    {
        // GET: Estabelecimentos
        public ActionResult Index()
        {
            List < Estab > = new List<Estab>;
            using (IDbConnection db) = new 
            return View();
        }

        // GET: Estabelecimentos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Estabelecimentos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estabelecimentos/Create
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

        // GET: Estabelecimentos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Estabelecimentos/Edit/5
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

        // GET: Estabelecimentos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Estabelecimentos/Delete/5
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

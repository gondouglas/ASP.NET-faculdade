using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EntityModels;
using Web.Models;
using Web.DAL;

namespace Web.Controllers
{
    public class QuartosController : Controller
    {
        Context ctx = new Context();
        // GET: Quartos
        public ActionResult Index()
        {
            return View(QuartoDAO.getList(ctx));
        }

        // GET: Quartos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quarto quarto = QuartoDAO.getById(Convert.ToInt32(id),ctx);
            if (quarto == null)
            {
                return HttpNotFound();
            }
            return View(quarto);
        }

        // GET: Quartos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Quartos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Numero,Andar,ValorDiaria,Ocupado,Deletado")] Quarto quarto)
        {
            Quarto q = QuartoDAO.getByNumero(quarto.Numero, ctx);
            if (q != null)
            {
                return View(quarto);
            }
            

            if (ModelState.IsValid)
            {
                QuartoDAO.Add(quarto,ctx);
                return RedirectToAction("Index");
            }

            return View(quarto);
        }

        public ActionResult Livres()
        {
            return View(QuartoDAO.getLivres(ctx));
        }

        public ActionResult Ocupados()
        {
            return View(QuartoDAO.getOcupados(ctx));
        }

        // GET: Quartos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quarto quarto = QuartoDAO.getById(Convert.ToInt32(id),ctx);
            if (quarto == null)
            {
                return HttpNotFound();
            }
            return View(quarto);
        }

        // POST: Quartos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Numero,Andar,ValorDiaria,Ocupado,Deletado")] Quarto quarto)
        {
            if (ModelState.IsValid)
            {
                QuartoDAO.Update(quarto,ctx);
                return RedirectToAction("Index");
            }
            return View(quarto);
        }

        // GET: Quartos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quarto quarto = QuartoDAO.getById(Convert.ToInt32(id),ctx);
            if (quarto == null)
            {
                return HttpNotFound();
            }
            return View(quarto);
        }

        // POST: Quartos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Quarto quarto = QuartoDAO.getById(Convert.ToInt32(id),ctx);
            QuartoDAO.Remove(quarto,ctx);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                ctx.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

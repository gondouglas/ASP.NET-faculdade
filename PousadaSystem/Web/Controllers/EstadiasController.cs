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
    public class EstadiasController : Controller
    {
        Context ctx = new Context();

        // GET: Estadias
        public ActionResult Index()
        {
            var estadias = ctx.Estadias.Include(e => e._Hospede).Include(e => e._Quarto);
            return View(estadias.ToList());
        }

        // GET: Estadias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estadia estadia = EstadiaDAO.getById(Convert.ToInt32(id),ctx);
            if (estadia == null)
            {
                return HttpNotFound();
            }
            return View(estadia);
        }

        // GET: Estadias/Create
        public ActionResult Create()
        {
            ViewBag.HospedeID = new SelectList(HospedeDAO.getList(ctx), "ID", "Nome");
            ViewBag.QuartoID = new SelectList(QuartoDAO.getLivres(ctx), "ID", "Numero");
            return View();
        }

        // POST: Estadias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Inicio,Final,QuantidadeDias,ValorTotal,QuartoID,HospedeID,Deletado")] Estadia estadia)
        {
            if(estadia.Final <= estadia.Inicio)
            {
                return View(estadia);
            }

            if (ModelState.IsValid)
            {
                Quarto quarto = QuartoDAO.getById(estadia.QuartoID,ctx);
                quarto.Ocupado = true;
                QuartoDAO.Update(quarto, ctx);
                estadia.QuantidadeDias = (estadia.Final-estadia.Inicio).Days;
                estadia.ValorTotal = estadia.QuantidadeDias * quarto.ValorDiaria;
                EstadiaDAO.Add(estadia, ctx);
                return RedirectToAction("Index");
            }

            ViewBag.HospedeID = new SelectList(HospedeDAO.getList(ctx), "ID", "Nome", estadia.HospedeID);
            ViewBag.QuartoID = new SelectList(QuartoDAO.getList(ctx), "ID", "Numero", estadia.QuartoID);
            return View(estadia);
        }

        // GET: Estadias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estadia estadia = EstadiaDAO.getById(Convert.ToInt32(id),ctx);
            if (estadia == null)
            {
                return HttpNotFound();
            }
            return View(estadia);
        }

        // POST: Estadias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Estadia estadia = EstadiaDAO.getById(Convert.ToInt32(id),ctx);
            EstadiaDAO.Remove(estadia,ctx);
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

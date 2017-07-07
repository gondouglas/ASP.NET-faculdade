using System;
using System.Net;
using System.Web.Mvc;
using EntityModels;
using Web.DAL;
using System.Linq;

namespace Web.Controllers
{
    public class EstadiasController : Controller
    {
        private readonly EstadiaDAO estadiaDAO = new EstadiaDAO();
        private readonly HospedeDAO hospedeDAO = new HospedeDAO();
        private readonly QuartoDAO quartoDAO = new QuartoDAO();

        // GET: Estadias
        public ActionResult Index()
        {
            return View(estadiaDAO.getDeletados(false).ToList());
        }

        // GET: Estadias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estadia estadia = estadiaDAO.getById(Convert.ToInt32(id));
            if (estadia == null)
            {
                return HttpNotFound();
            }
            return View(estadia);
        }

        // GET: Estadias/Create
        public ActionResult Create()
        {
            ViewBag.HospedeID = new SelectList(hospedeDAO.getList(), "ID", "Nome");
            ViewBag.QuartoID = new SelectList(quartoDAO.getLivres(), "ID", "Numero");
            return View();
        }

        // POST: Estadias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Inicio,Final,QuantidadeDias,ValorTotal,QuartoID,HospedeID,Deletado")] Estadia estadia)
        {
            if (!(estadia.Final <= estadia.Inicio))
            {
                if (ModelState.IsValid)
                {
                    Quarto quarto = quartoDAO.getById(estadia.QuartoID);
                    quarto.Ocupado = true;
                    quartoDAO.Update(quarto);
                    estadia.QuantidadeDias = (estadia.Final - estadia.Inicio).Days;
                    estadia.ValorTotal = estadia.QuantidadeDias * quarto.ValorDiaria;
                    estadiaDAO.Add(estadia);
                    return RedirectToAction("Index");
                }
            }
            ViewBag.HospedeID = new SelectList(hospedeDAO.getList(), "ID", "Nome", estadia.HospedeID);
            ViewBag.QuartoID = new SelectList(quartoDAO.getList(), "ID", "Numero", estadia.QuartoID);
            return View(estadia);

        }

        // GET: Estadias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Estadia estadia = estadiaDAO.getById(Convert.ToInt32(id));
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
            Estadia estadia = estadiaDAO.getById(Convert.ToInt32(id));
            estadiaDAO.Remove(estadia);
            return RedirectToAction("Index");
        }
    }
}

using System;
using System.Net;
using System.Web.Mvc;
using EntityModels;
using Web.DAL;
using System.Linq;

namespace Web.Controllers
{
    public class QuartosController : Controller
    {
        private readonly EstadiaDAO estadiaDAO = new EstadiaDAO();
        private readonly HospedeDAO hospedeDAO = new HospedeDAO();
        private readonly QuartoDAO quartoDAO = new QuartoDAO();
        // GET: Quartos
        public ActionResult Index()
        {
            return View(quartoDAO.getDeletados(false).ToList());
        }

        // GET: Quartos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quarto quarto = quartoDAO.getById(Convert.ToInt32(id));
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
            Quarto q = quartoDAO.getByNumero(quarto.Numero);
            if (q != null)
            {
                return View(quarto);
            }
            

            if (ModelState.IsValid)
            {
                quartoDAO.Add(quarto);
                return RedirectToAction("Index");
            }

            return View(quarto);
        }

        public ActionResult Livres()
        {
            return View(quartoDAO.getLivres().ToList());
        }

        public ActionResult Ocupados()
        {
            return View(quartoDAO.getOcupados().ToList());
        }

        // GET: Quartos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Quarto quarto = quartoDAO.getById(Convert.ToInt32(id));
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
                quartoDAO.Update(quarto);
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
            Quarto quarto = quartoDAO.getById(Convert.ToInt32(id));
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
            Quarto quarto = quartoDAO.getById(Convert.ToInt32(id));
            quartoDAO.Remove(quarto);
            return RedirectToAction("Index");
        }
    }
}

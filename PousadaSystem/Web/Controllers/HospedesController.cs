using System;
using System.Net;
using System.Web.Mvc;
using EntityModels;
using Web.DAL;
using System.Linq;

namespace Web.Controllers
{
    public class HospedesController : Controller
    {
        private readonly EstadiaDAO estadiaDAO = new EstadiaDAO();
        private readonly HospedeDAO hospedeDAO = new HospedeDAO();
        private readonly QuartoDAO quartoDAO = new QuartoDAO();

        // GET: Hospedes
        public ActionResult Index()
        {
            return View(hospedeDAO.getDeletados(false).ToList());
        }

        // GET: Hospedes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hospede hospede = hospedeDAO.getById(Convert.ToInt32(id));
            if (hospede == null)
            {
                return HttpNotFound();
            }
            return View(hospede);
        }

        // GET: Hospedes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hospedes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nome,Cpf,Email,Deletado")] Hospede hospede)
        {
            if (ExistCpf(hospede.Cpf) || ExistEmail(hospede.Email))
            {
                return View(hospede);
            }
            if (ModelState.IsValid)
            {

                hospedeDAO.Add(hospede);
                return RedirectToAction("Index");
            }

            return View(hospede);
        }

        // GET: Hospedes/Edit/5
        public ActionResult Edit(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hospede hospede = hospedeDAO.getById(Convert.ToInt32(id));
            if (hospede == null)
            {
                return HttpNotFound();
            }
            return View(hospede);
        }

        // POST: Hospedes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nome,Cpf,Email,Deletado")] Hospede hospede)
        {

            if (ModelState.IsValid)
            {
                hospedeDAO.Update(hospede);
                return RedirectToAction("Index");
            }
            return View(hospede);


        }

        // GET: Hospedes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hospede hospede = hospedeDAO.getById(Convert.ToInt32(id));
            if (hospede == null)
            {
                return HttpNotFound();
            }
            return View(hospede);
        }

        // POST: Hospedes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Hospede hospede = hospedeDAO.getById(Convert.ToInt32(id));
            hospedeDAO.Remove(hospede);
            return RedirectToAction("Index");
        }

        private bool ExistCpf(string cpf)
        {
            Hospede hospede = hospedeDAO.getByCpf(cpf);
            if (hospede != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool ExistEmail(string email)
        {
            Hospede hospede = hospedeDAO.getByEmail(email);
            if (hospede != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private Hospede ExistEmail(Hospede x)
        {
            Hospede hospede = hospedeDAO.getByEmail(x.Email);
            if (hospede != null)
            {
                return hospede;
            }
            else
            {
                return null;
            }
        }
    }
}

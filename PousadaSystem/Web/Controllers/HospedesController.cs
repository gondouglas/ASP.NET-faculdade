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
    public class HospedesController : Controller
    {
        Context ctx = new Context();
        // GET: Hospedes
        public ActionResult Index()
        {
            return View(HospedeDAO.getList(ctx));
        }

        // GET: Hospedes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hospede hospede = HospedeDAO.getById(Convert.ToInt32(id), ctx);
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

                HospedeDAO.Add(hospede, ctx);
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
            Hospede hospede = HospedeDAO.getById(Convert.ToInt32(id), ctx);
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
            Hospede hos = ExistEmail(hospede);
            if (hos.ID.Equals(hospede.ID)){

                if (ModelState.IsValid)
                {
                    HospedeDAO.Update(hospede, ctx);
                    return RedirectToAction("Index");
                }
                return View(hospede);
            }else
            {
                return View(hospede);
            }
        }

        // GET: Hospedes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hospede hospede = HospedeDAO.getById(Convert.ToInt32(id), ctx);
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
            Hospede hospede = HospedeDAO.getById(Convert.ToInt32(id), ctx);
            HospedeDAO.Remove(hospede, ctx);
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

        private bool ExistCpf(string cpf)
        {
            Hospede hospede = HospedeDAO.getByCpf(cpf, ctx);
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
            Hospede hospede = HospedeDAO.getByEmail(email, ctx);
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
            Hospede hospede = HospedeDAO.getByEmail(x.Email, ctx);
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

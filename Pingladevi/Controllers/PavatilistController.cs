using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Pingladevi.Data;

namespace Pingladevi.Controllers
{
    public class PavatilistController : Controller
    {
        private PingladeviEntities db = new PingladeviEntities();

        // GET: Pavatilist
        public ActionResult Index()
        {
            return View(db.Tbl_Pavati.ToList());
        }

        // GET: Pavatilist/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Pavati tbl_Pavati = db.Tbl_Pavati.Find(id);
            if (tbl_Pavati == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Pavati);
        }

        // GET: Pavatilist/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pavatilist/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Date,Name,Mobileno,PaymentInWord,PaymentInNo")] Tbl_Pavati tbl_Pavati)
        {
            if (ModelState.IsValid)
            {
                db.Tbl_Pavati.Add(tbl_Pavati);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_Pavati);
        }

        // GET: Pavatilist/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Pavati tbl_Pavati = db.Tbl_Pavati.Find(id);
            if (tbl_Pavati == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Pavati);
        }

        // POST: Pavatilist/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Date,Name,Mobileno,PaymentInWord,PaymentInNo")] Tbl_Pavati tbl_Pavati)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Pavati).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_Pavati);
        }

        // GET: Pavatilist/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Pavati tbl_Pavati = db.Tbl_Pavati.Find(id);
            if (tbl_Pavati == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Pavati);
        }

        // POST: Pavatilist/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tbl_Pavati tbl_Pavati = db.Tbl_Pavati.Find(id);
            db.Tbl_Pavati.Remove(tbl_Pavati);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

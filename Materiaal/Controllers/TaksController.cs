using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Materiaal.DAL;
using Materiaal.Models.Aanvraag;

namespace Materiaal.Controllers
{
    public class TaksController : Controller
    {
        private Context db = new Context();

        // GET: Taks
        public ActionResult Index()
        {
            return View(db.Taks.ToList());
        }

        // GET: Taks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tak tak = db.Taks.Find(id);
            if (tak == null)
            {
                return HttpNotFound();
            }
            return View(tak);
        }

        // GET: Taks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Taks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "tak_Id,tak_Naam")] Tak tak)
        {
            if (ModelState.IsValid)
            {
                db.Taks.Add(tak);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tak);
        }

        // GET: Taks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tak tak = db.Taks.Find(id);
            if (tak == null)
            {
                return HttpNotFound();
            }
            return View(tak);
        }

        // POST: Taks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "tak_Id,tak_Naam")] Tak tak)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tak).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tak);
        }

        // GET: Taks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tak tak = db.Taks.Find(id);
            if (tak == null)
            {
                return HttpNotFound();
            }
            return View(tak);
        }

        // POST: Taks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tak tak = db.Taks.Find(id);
            db.Taks.Remove(tak);
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

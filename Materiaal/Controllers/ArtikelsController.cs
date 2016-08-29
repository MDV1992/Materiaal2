using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Materiaal.DAL;
using Materiaal.Models;
using Materiaal.ViewModels.Artikels;

namespace Materiaal.Controllers
{
    public class ArtikelsController : Controller
    {
        private Context db = new Context();

        // GET: Artikels
         public ActionResult Index()
       {
            List<ArtikelIndexViewModel> ArtikelVMList = new List<ArtikelIndexViewModel>();
            List<Artikel> Artikelen = new List<Artikel>(db.Artikelen.ToList());

            foreach (var art in Artikelen)
            {
                ArtikelIndexViewModel AIVM = new ArtikelIndexViewModel();
                AIVM.artikel.art_Id = art.art_Id;
                AIVM.artikel.art_Naam = art.art_Naam;
                AIVM.artikel.cat_Id = art.cat_Id;
                AIVM.artikel.Leverancier = art.Leverancier;
                AIVM.artikel.prijs = art.prijs;
                AIVM.artikel.voorraad = art.voorraad;
                AIVM.artikel.actief = art.actief;
                Categorie cat = db.Categorien.Find(AIVM.artikel.cat_Id);
                AIVM.categorie.cat_Naam = cat.cat_Naam;

                ArtikelVMList.Add(AIVM);
                
            }

            return View(ArtikelVMList);

        }

        // GET: Artikels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artikel artikel = db.Artikelen.Find(id);
            if (artikel == null)
            {
                return HttpNotFound();

            }

            return View(artikel);
        }

        // GET: Artikels/Create
        public ActionResult Create()
        {
            ViewBag.CategorySelect = new SelectList(db.Categorien, "Cat_id", "cat_Naam");
            return View();
        }

        // POST: Artikels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "art_Id,art_Naam,voorraad,cat_Id,prijs,Leverancier")] Artikel artikel)
        {
            if (ModelState.IsValid)
            {
                db.Artikelen.Add(artikel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(artikel);
        }

        // GET: Artikels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artikel artikel = db.Artikelen.Find(id);
            if (artikel == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategorySelect = new SelectList(db.Categorien, "Cat_id", "cat_Naam");
            return View(artikel);
        }

        // POST: Artikels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "art_Id,art_Naam,voorraad,cat_Id,prijs,Leverancier")] Artikel artikel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(artikel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(artikel);
        }

   
        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artikel art = db.Artikelen.Find(id);
            if (art == null)
            {
                return HttpNotFound();
            }

            Artikel artikel = db.Artikelen.Find(id);
            if (artikel == null)
            {
                return HttpNotFound();
            }
            return View(artikel);
        }

        // POST: Artikels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Artikel artikel = db.Artikelen.Find(id);
            db.Artikelen.Remove(artikel);
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

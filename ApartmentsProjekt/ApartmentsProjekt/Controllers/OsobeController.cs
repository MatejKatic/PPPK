using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using ApartmentsProjekt.Models;
using System.Data.Entity;

namespace ApartmentsProjekt.Controllers
{
    public class OsobeController : Controller
    {
        private ModelContainer db = new ModelContainer();


        // GET: Osobas
        public ActionResult Index()
        {
            return View(db.Osobas.ToList());
        }
        public ActionResult GetNaziv(int id)
        {
            return Content(db.Osobas.SingleOrDefault(p => p.IDOsoba == id).Description);
        }

        // GET: Osobas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Osoba person = db.Osobas.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // GET: Osobas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Osobas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDOsoba,Naziv")] Osoba person)
        {
            if (ModelState.IsValid)
            {
                db.Osobas.Add(person);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(person);
        }

        // GET: Osobas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Osoba person = db.Osobas.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // POST: Osobas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDOsoba,Naziv")] Osoba person)
        {
            if (ModelState.IsValid)
            {
                db.Entry(person).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(person);
        }

        // GET: Osobas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Osoba person = db.Osobas.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // POST: Osobas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            foreach (var apartment in db.Apartments.Where(ap => ap.vlasnikID == id).ToList())
            {
                db.UploadedFiles.RemoveRange(db.UploadedFiles.Where(f => f.ApartmentIDApartment == apartment.IDApartment));
            }
            db.Apartments.RemoveRange(db.Apartments.Where(ap => ap.vlasnikID == id));

            Osoba person = db.Osobas.Find(id);
            db.Osobas.Remove(person);
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
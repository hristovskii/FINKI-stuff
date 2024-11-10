using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Pregledi.Context;
using Pregledi.Models;

namespace Pregledi.Controllers
{
    public class HospitalsController : Controller
    {
        private PreglediContext db = new PreglediContext();

        // GET: Hospitals
        public ActionResult Index()
        {
            return View(db.Hospitals.ToList());
        }

        // GET: Hospitals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hospital hospital = db.Hospitals.Find(id);
            if (hospital == null)
            {
                return HttpNotFound();
            }
            return View(hospital);
        }

        // GET: Hospitals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hospitals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Address")] Hospital hospital, HttpPostedFileBase Image)
        {
            if (ModelState.IsValid)
            {
                if (Image != null && Image.ContentLength > 0)
                {
                    using (var binaryReader = new BinaryReader(Image.InputStream))
                    {
                        hospital.Image = binaryReader.ReadBytes(Image.ContentLength);
                    }
                }

                db.Hospitals.Add(hospital);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hospital);
        }

        // GET: Hospitals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hospital hospital = db.Hospitals.Find(id);
            if (hospital == null)
            {
                return HttpNotFound();
            }
            return View(hospital);
        }

        // POST: Hospitals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Image,Name,Address")] Hospital hospital)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hospital).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hospital);
        }

        // GET: Hospitals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hospital hospital = db.Hospitals.Find(id);
            if (hospital == null)
            {
                return HttpNotFound();
            }
            return View(hospital);
        }

        // POST: Hospitals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Hospital hospital = db.Hospitals.Find(id);
            db.Hospitals.Remove(hospital);
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

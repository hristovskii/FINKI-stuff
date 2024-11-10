using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Pregledi.Context;
using Pregledi.Models;

namespace Pregledi.Controllers
{
    public class DoctorsController : Controller
    {
        private PreglediContext db = new PreglediContext();

        // GET: Doctors
        public ActionResult Index()
        {
            return View(db.Doctors.ToList());
        }

        // GET: Doctors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctor doctor = db.Doctors.Find(id);
            if (doctor == null)
            {
                return HttpNotFound();
            }
            return View(doctor);
        }

        // GET: Doctors/Create
        public ActionResult Create()
        {
            SelectHospitalViewModel viewModel = new SelectHospitalViewModel();
            viewModel.Doctor = new Doctor();
            viewModel.Hospitals = db.Hospitals.ToList();
            return View(viewModel);
        }

        // POST: Doctors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SelectHospitalViewModel viewModel)
        {
            var doctor = viewModel.Doctor;
            var selectedHospitalId = viewModel.SelectedHospitalId;

            var hospital = db.Hospitals.Find(selectedHospitalId);
            if (hospital != null)
            {
                doctor.Hospital = hospital;
                db.Doctors.Add(doctor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Selected hospital does not exist.");

            viewModel.Hospitals = db.Hospitals.ToList(); // Reload hospitals if the model state is not valid
            return View(viewModel);
        }


        // GET: Doctors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctor doctor = db.Doctors.Find(id);
            if (doctor == null)
            {
                return HttpNotFound();
            }
            return View(doctor);
        }

        // POST: Doctors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doctor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(doctor);
        }

        // GET: Doctors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctor doctor = db.Doctors.Find(id);
            if (doctor == null)
            {
                return HttpNotFound();
            }
            return View(doctor);
        }

        // POST: Doctors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Doctor doctor = db.Doctors.Find(id);
            db.Doctors.Remove(doctor);
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

        public ActionResult AddPatient()
        {
            AddPatientViewModel viewModel = new AddPatientViewModel();
            viewModel.Patients = db.Patients.ToList();
            viewModel.Doctors = db.Doctors.ToList();
            return View(viewModel);
        }

        // POST: AddPatientToDoctor
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddPatientToDoctor(AddPatientViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var selectedDoctorId = viewModel.SelectedDoctorId;
                var selectedPatientId = viewModel.SelectedPatientId;

                var doctor = db.Doctors.Include("Patients").FirstOrDefault(d => d.Id == selectedDoctorId);
                var patient = db.Patients.Find(selectedPatientId);

                if (doctor != null && patient != null)
                {
                    doctor.Patients.Add(patient);
                    db.SaveChanges();
                }

                return RedirectToAction("Index"); // Redirect to the appropriate action
            }

            // If we got this far, something failed; reload the data
            viewModel.Doctors = db.Doctors.ToList();
            viewModel.Patients = db.Patients.ToList();

            return View("AddPatient", viewModel);
        }
    }
}

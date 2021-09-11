using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Carinsurance.Models;

namespace Carinsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = QuoteGenerator(insuree);
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Admin");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = QuoteGenerator(insuree);
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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

        //Method to generate a quote
        public decimal QuoteGenerator(Insuree insuree)
        {
            insuree.Quote = 50.0m;
            int insureeAge = DateTime.Now.Year - insuree.DateOfBirth.Year;
            //if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear) insureeAge -= 1;
            
            //Check age
            if (insureeAge < 18)
            {
                insuree.Quote += 100;
            }
            if (insureeAge > 18 && insureeAge < 25)
            {
                insuree.Quote += 50;
            }
            if (insureeAge > 25)
            {
                insuree.Quote += 25;
            }

            //Check car
            //car year
            if (insuree.CarYear < 2000)
            {
                insuree.Quote += 25;
            }

            if (insuree.CarYear > 2015)
            {
                insuree.Quote += 25;
            }
            //car make
            if (insuree.CarMake == "Porsche")
            {
                insuree.Quote += 25;
            }
            //car model
            if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera")
            {
                insuree.Quote += 25;
            }

            for (int i = 0; i < insuree.SpeedingTickets; i++)
            {
                insuree.Quote += 10;
            }

            ////Driving record
            ////speeding tickets
            //int ticketCost = speedingTickets * 10;
            //insuree.Quote += ticketCost;

            //dui
            if (insuree.DUI == true)
            {
                insuree.Quote *= 1.25m;
            }

            //check coverage
            if (insuree.CoverageType == true)
            {
                insuree.Quote *= 1.50m;
            }

            return insuree.Quote;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Assignment_30.Models;

namespace Assignment_30.Controllers
{
    public class GetQuotesController : Controller
    {
        private CarInsuranceQuoteEntities db = new CarInsuranceQuoteEntities();

        // GET: GetQuotes
        public ActionResult Index()
        {
            return View(db.GetQuotes.ToList());
        }

        // GET: GetQuotes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GetQuote getQuote = db.GetQuotes.Find(id);
            if (getQuote == null)
            {
                return HttpNotFound();
            }
            return View(getQuote);
        }

        // GET: GetQuotes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GetQuotes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,Birthday,CarYear,CarMake,CarModel,DUI,SpeedingTix,FCorL")] GetQuote getQuote)
        {
            if (ModelState.IsValid)
            {
                
                db.GetQuotes.Add(getQuote);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(getQuote);
        }

        // GET: GetQuotes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GetQuote getQuote = db.GetQuotes.Find(id);
            if (getQuote == null)
            {
                return HttpNotFound();
            }
            return View(getQuote);
        }

        // POST: GetQuotes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,Birthday,CarYear,CarMake,CarModel,DUI,SpeedingTix,FCorL")] GetQuote getQuote)
        {
            if (ModelState.IsValid)
            {
                db.Entry(getQuote).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(getQuote);
        }

        // GET: GetQuotes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GetQuote getQuote = db.GetQuotes.Find(id);
            if (getQuote == null)
            {
                return HttpNotFound();
            }
            return View(getQuote);
        }

        // POST: GetQuotes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GetQuote getQuote = db.GetQuotes.Find(id);
            db.GetQuotes.Remove(getQuote);
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

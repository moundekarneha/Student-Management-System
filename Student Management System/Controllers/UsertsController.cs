using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Student_Management_System.Models;

namespace Student_Management_System.Controllers
{
    public class UsertsController : Controller
    {
        private StudentMSEntities db = new StudentMSEntities();

        // GET: Userts
        public ActionResult Index()
        {
            return View(db.Userts.ToList());
        }

        // GET: Userts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usert usert = db.Userts.Find(id);
            if (usert == null)
            {
                return HttpNotFound();
            }
            return View(usert);
        }

        // GET: Userts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Userts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,fname,lname,uname,pass")] Usert usert)
        {
            if (ModelState.IsValid)
            {
                db.Userts.Add(usert);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(usert);
        }

        // GET: Userts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usert usert = db.Userts.Find(id);
            if (usert == null)
            {
                return HttpNotFound();
            }
            return View(usert);
        }

        // POST: Userts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,fname,lname,uname,pass")] Usert usert)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usert).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usert);
        }

        // GET: Userts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usert usert = db.Userts.Find(id);
            if (usert == null)
            {
                return HttpNotFound();
            }
            return View(usert);
        }

        // POST: Userts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Usert usert = db.Userts.Find(id);
            db.Userts.Remove(usert);
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

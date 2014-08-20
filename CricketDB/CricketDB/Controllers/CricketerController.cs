using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CricketDB.Models;

namespace CricketDB.Controllers
{
    public class CricketerController : Controller
    {
        private CricketDBEntities db = new CricketDBEntities();

        // GET: /Cricketer/
        public ActionResult Index()
        {
            return View(db.Cricketers.ToList());
        }

        // GET: /Cricketer/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cricketer cricketer = db.Cricketers.Find(id);
            if (cricketer == null)
            {
                return HttpNotFound();
            }
            return View(cricketer);
        }

        // GET: /Cricketer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Cricketer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,Name,ODI,Test")] Cricketer cricketer)
        {
            if (ModelState.IsValid)
            {
                db.Cricketers.Add(cricketer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cricketer);
        }

        // GET: /Cricketer/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cricketer cricketer = db.Cricketers.Find(id);
            if (cricketer == null)
            {
                return HttpNotFound();
            }
            return View(cricketer);
        }

        // POST: /Cricketer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,Name,ODI,Test")] Cricketer cricketer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cricketer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cricketer);
        }

        // GET: /Cricketer/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cricketer cricketer = db.Cricketers.Find(id);
            if (cricketer == null)
            {
                return HttpNotFound();
            }
            return View(cricketer);
        }

        // POST: /Cricketer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cricketer cricketer = db.Cricketers.Find(id);

            foreach (var item in cricketer.Cricketer_Details.ToArray())
            {
                db.Cricketer_Details.Remove(item);
            }
            foreach (var item in cricketer.Cricketer_ODI_Statistics.ToArray())
            {
                db.Cricketer_ODI_Statistics.Remove(item);
            }
            foreach (var item in cricketer.Cricketer_Test_Statistics.ToArray())
            {
                db.Cricketer_Test_Statistics.Remove(item);
            }

            db.Cricketers.Remove(cricketer);
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

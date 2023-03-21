using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EquipmentManager.Models;

namespace EquipmentManager.Controllers
{
    public class ThietbisController : Controller
    {
        private EquipmentDbContext db = new EquipmentDbContext();

        // GET: Thietbis
        public ActionResult Index()
        {
            return View(db.Thietbis.ToList());
        }

        // GET: Thietbis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Thietbi thietbi = db.Thietbis.Find(id);
            if (thietbi == null)
            {
                return HttpNotFound();
            }
            return View(thietbi);
        }

        // GET: Thietbis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Thietbis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Tenthietbi,NgaySX,NhaSX,Handung,Ngaymua,DVT,Soluong,Tinhtrang")] Thietbi thietbi)
        {
            if (ModelState.IsValid)
            {
                db.Thietbis.Add(thietbi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(thietbi);
        }

        // GET: Thietbis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Thietbi thietbi = db.Thietbis.Find(id);
            if (thietbi == null)
            {
                return HttpNotFound();
            }
            return View(thietbi);
        }

        // POST: Thietbis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Tenthietbi,NgaySX,NhaSX,Handung,Ngaymua,DVT,Soluong,Tinhtrang")] Thietbi thietbi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(thietbi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(thietbi);
        }

        // GET: Thietbis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Thietbi thietbi = db.Thietbis.Find(id);
            if (thietbi == null)
            {
                return HttpNotFound();
            }
            return View(thietbi);
        }

        // POST: Thietbis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Thietbi thietbi = db.Thietbis.Find(id);
            db.Thietbis.Remove(thietbi);
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

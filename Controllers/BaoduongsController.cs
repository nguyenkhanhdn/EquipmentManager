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
    public class BaoduongsController : Controller
    {
        private EquipmentDbContext db = new EquipmentDbContext();

        // GET: Baoduongs
        public ActionResult Index()
        {
            return View(db.Baoduongs.ToList());
        }

        // GET: Baoduongs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Baoduong baoduong = db.Baoduongs.Find(id);
            if (baoduong == null)
            {
                return HttpNotFound();
            }
            return View(baoduong);
        }

        // GET: Baoduongs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Baoduongs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ThietbiId,Lanbaoduong,Noidung,Ngaybaoduong,Nhanvien,Ghichu")] Baoduong baoduong)
        {
            if (ModelState.IsValid)
            {
                db.Baoduongs.Add(baoduong);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(baoduong);
        }

        // GET: Baoduongs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Baoduong baoduong = db.Baoduongs.Find(id);
            if (baoduong == null)
            {
                return HttpNotFound();
            }
            return View(baoduong);
        }

        // POST: Baoduongs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ThietbiId,Lanbaoduong,Noidung,Ngaybaoduong,Nhanvien,Ghichu")] Baoduong baoduong)
        {
            if (ModelState.IsValid)
            {
                db.Entry(baoduong).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(baoduong);
        }

        // GET: Baoduongs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Baoduong baoduong = db.Baoduongs.Find(id);
            if (baoduong == null)
            {
                return HttpNotFound();
            }
            return View(baoduong);
        }

        // POST: Baoduongs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Baoduong baoduong = db.Baoduongs.Find(id);
            db.Baoduongs.Remove(baoduong);
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

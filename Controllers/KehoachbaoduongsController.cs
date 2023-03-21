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
    public class KehoachbaoduongsController : Controller
    {
        private EquipmentDbContext db = new EquipmentDbContext();

        // GET: Kehoachbaoduongs
        public ActionResult Index()
        {
            var kehoachbaoduongs = db.Kehoachbaoduongs.Include(k => k.Thietbi);
            return View(kehoachbaoduongs.ToList());
        }

        // GET: Kehoachbaoduongs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kehoachbaoduong kehoachbaoduong = db.Kehoachbaoduongs.Find(id);
            if (kehoachbaoduong == null)
            {
                return HttpNotFound();
            }
            return View(kehoachbaoduong);
        }

        // GET: Kehoachbaoduongs/Create
        public ActionResult Create()
        {
            ViewBag.ThietbiId = new SelectList(db.Thietbis, "Id", "Tenthietbi");
            return View();
        }

        // POST: Kehoachbaoduongs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ThietbiId,Lanbaoduong,Noidung,Ngaybaoduong,Ghichu")] Kehoachbaoduong kehoachbaoduong)
        {
            if (ModelState.IsValid)
            {
                db.Kehoachbaoduongs.Add(kehoachbaoduong);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ThietbiId = new SelectList(db.Thietbis, "Id", "Tenthietbi", kehoachbaoduong.ThietbiId);
            return View(kehoachbaoduong);
        }

        // GET: Kehoachbaoduongs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kehoachbaoduong kehoachbaoduong = db.Kehoachbaoduongs.Find(id);
            if (kehoachbaoduong == null)
            {
                return HttpNotFound();
            }
            ViewBag.ThietbiId = new SelectList(db.Thietbis, "Id", "Tenthietbi", kehoachbaoduong.ThietbiId);
            return View(kehoachbaoduong);
        }

        // POST: Kehoachbaoduongs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ThietbiId,Lanbaoduong,Noidung,Ngaybaoduong,Ghichu")] Kehoachbaoduong kehoachbaoduong)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kehoachbaoduong).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ThietbiId = new SelectList(db.Thietbis, "Id", "Tenthietbi", kehoachbaoduong.ThietbiId);
            return View(kehoachbaoduong);
        }

        // GET: Kehoachbaoduongs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kehoachbaoduong kehoachbaoduong = db.Kehoachbaoduongs.Find(id);
            if (kehoachbaoduong == null)
            {
                return HttpNotFound();
            }
            return View(kehoachbaoduong);
        }

        // POST: Kehoachbaoduongs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Kehoachbaoduong kehoachbaoduong = db.Kehoachbaoduongs.Find(id);
            db.Kehoachbaoduongs.Remove(kehoachbaoduong);
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QLBHWS.Models;

namespace QLBHWS.Controllers
{
    public class AdminChungLoaiController : Controller
    {
        private QLBanHang2DbContext db = new QLBanHang2DbContext();

        // GET: AdminChungLoai
        public ActionResult Index()
        {
            return View(db.ChungLoais.ToList());
        }

        // GET: AdminChungLoai/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChungLoai chungLoai = db.ChungLoais.Find(id);
            if (chungLoai == null)
            {
                return HttpNotFound();
            }
            return View(chungLoai);
        }

        // GET: AdminChungLoai/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminChungLoai/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,MaSo,Ten")] ChungLoai chungLoai)
        {
            if (ModelState.IsValid)
            {
                db.ChungLoais.Add(chungLoai);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(chungLoai);
        }

        // GET: AdminChungLoai/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChungLoai chungLoai = db.ChungLoais.Find(id);
            if (chungLoai == null)
            {
                return HttpNotFound();
            }
            return View(chungLoai);
        }

        // POST: AdminChungLoai/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,MaSo,Ten")] ChungLoai chungLoai)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chungLoai).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(chungLoai);
        }

        // GET: AdminChungLoai/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChungLoai chungLoai = db.ChungLoais.Find(id);
            if (chungLoai == null)
            {
                return HttpNotFound();
            }
            return View(chungLoai);
        }

        // POST: AdminChungLoai/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ChungLoai chungLoai = db.ChungLoais.Find(id);
            db.ChungLoais.Remove(chungLoai);
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

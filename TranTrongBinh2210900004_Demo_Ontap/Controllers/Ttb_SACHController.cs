using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TranTrongBinh2210900004_Demo_Ontap.Models;

namespace TranTrongBinh2210900004_Demo_Ontap.Controllers
{
    public class Ttb_SACHController : Controller
    {
        private TranTrongBinh2210900004_Demo_OnTapEntities db = new TranTrongBinh2210900004_Demo_OnTapEntities();

        // GET: Ttb_SACH
        public ActionResult TtbIndex()
        {
            var ttb_SACH = db.Ttb_SACH.Include(t => t.Ttb_TACGIA);
            return View(ttb_SACH.ToList());
        }

        // GET: Ttb_SACH/Details/5
        public ActionResult TtbDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ttb_SACH ttb_SACH = db.Ttb_SACH.Find(id);
            if (ttb_SACH == null)
            {
                return HttpNotFound();
            }
            return View(ttb_SACH);
        }

        // GET: Ttb_SACH/Create
        public ActionResult TtbCreate()
        {
            ViewBag.Ttb_MaTG = new SelectList(db.Ttb_TACGIA, "Ttb_MaTG", "Ttb_TenTacGia");
            return View();
        }

        // POST: Ttb_SACH/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TtbCreate([Bind(Include = "Ttb_MaSach,Ttb_TenSach,Ttb_SoTrang,Ttb_NamXB,Ttb_MaTG,Ttb_TrangThai")] Ttb_SACH ttb_SACH)
        {
            if (ModelState.IsValid)
            {
                db.Ttb_SACH.Add(ttb_SACH);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Ttb_MaTG = new SelectList(db.Ttb_TACGIA, "Ttb_MaTG", "Ttb_TenTacGia", ttb_SACH.Ttb_MaTG);
            return View(ttb_SACH);
        }

        // GET: Ttb_SACH/Edit/5
        public ActionResult TtbEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ttb_SACH ttb_SACH = db.Ttb_SACH.Find(id);
            if (ttb_SACH == null)
            {
                return HttpNotFound();
            }
            ViewBag.Ttb_MaTG = new SelectList(db.Ttb_TACGIA, "Ttb_MaTG", "Ttb_TenTacGia", ttb_SACH.Ttb_MaTG);
            return View(ttb_SACH);
        }

        // POST: Ttb_SACH/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TtbEdit([Bind(Include = "Ttb_MaSach,Ttb_TenSach,Ttb_SoTrang,Ttb_NamXB,Ttb_MaTG,Ttb_TrangThai")] Ttb_SACH ttb_SACH)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ttb_SACH).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Ttb_MaTG = new SelectList(db.Ttb_TACGIA, "Ttb_MaTG", "Ttb_TenTacGia", ttb_SACH.Ttb_MaTG);
            return View(ttb_SACH);
        }

        // GET: Ttb_SACH/Delete/5
        public ActionResult TtbDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ttb_SACH ttb_SACH = db.Ttb_SACH.Find(id);
            if (ttb_SACH == null)
            {
                return HttpNotFound();
            }
            return View(ttb_SACH);
        }

        // POST: Ttb_SACH/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Ttb_SACH ttb_SACH = db.Ttb_SACH.Find(id);
            db.Ttb_SACH.Remove(ttb_SACH);
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

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
    public class Ttb_TACGIAController : Controller
    {
        private TranTrongBinh2210900004_Demo_OnTapEntities db = new TranTrongBinh2210900004_Demo_OnTapEntities();

        // GET: Ttb_TACGIA
        public ActionResult TtbIndex()
        {
            return View(db.Ttb_TACGIA.ToList());
        }

        // GET: Ttb_TACGIA/Details/5
        public ActionResult TtbDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ttb_TACGIA ttb_TACGIA = db.Ttb_TACGIA.Find(id);
            if (ttb_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(ttb_TACGIA);
        }

        // GET: Ttb_TACGIA/Create
        public ActionResult TtbCreate()
        {
            return View();
        }

        // POST: Ttb_TACGIA/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TtbCreate([Bind(Include = "Ttb_MaTG,Ttb_TenTacGia")] Ttb_TACGIA ttb_TACGIA)
        {
            if (ModelState.IsValid)
            {
                db.Ttb_TACGIA.Add(ttb_TACGIA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ttb_TACGIA);
        }

        // GET: Ttb_TACGIA/Edit/5
        public ActionResult TtbEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ttb_TACGIA ttb_TACGIA = db.Ttb_TACGIA.Find(id);
            if (ttb_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(ttb_TACGIA);
        }

        // POST: Ttb_TACGIA/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TtbEdit([Bind(Include = "Ttb_MaTG,Ttb_TenTacGia")] Ttb_TACGIA ttb_TACGIA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ttb_TACGIA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ttb_TACGIA);
        }

        // GET: Ttb_TACGIA/Delete/5
        public ActionResult TtbDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ttb_TACGIA ttb_TACGIA = db.Ttb_TACGIA.Find(id);
            if (ttb_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(ttb_TACGIA);
        }

        // POST: Ttb_TACGIA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Ttb_TACGIA ttb_TACGIA = db.Ttb_TACGIA.Find(id);
            db.Ttb_TACGIA.Remove(ttb_TACGIA);
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

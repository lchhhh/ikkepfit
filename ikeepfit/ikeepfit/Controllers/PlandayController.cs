using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ikeepfit.Models;

namespace ikeepfit.Controllers
{
    public class PlandayController : Controller
    {
        private ikeepfitEFContext db = new ikeepfitEFContext();

        //
        // GET: /Planday/

        public ActionResult Index()
        {
            var mt_planday = db.mt_planday.Include(m => m.mt_plan);
            return View(mt_planday.ToList());
        }

        //
        // GET: /Planday/Details/5

        public ActionResult Details(string id = null)
        {
            mt_planday mt_planday = db.mt_planday.Find(id);
            if (mt_planday == null)
            {
                return HttpNotFound();
            }
            return View(mt_planday);
        }

        //
        // GET: /Planday/Create

        public ActionResult Create()
        {
            ViewBag.mt_plan_id = new SelectList(db.mt_plan, "mt_plan_id", "mt_plan_name");
            return View();
        }

        //
        // POST: /Planday/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(mt_planday mt_planday)
        {
            if (ModelState.IsValid)
            {
                db.mt_planday.Add(mt_planday);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.mt_plan_id = new SelectList(db.mt_plan, "mt_plan_id", "mt_plan_name", mt_planday.mt_plan_id);
            return View(mt_planday);
        }

        //
        // GET: /Planday/Edit/5

        public ActionResult Edit(string id = null)
        {
            mt_planday mt_planday = db.mt_planday.Find(id);
            if (mt_planday == null)
            {
                return HttpNotFound();
            }
            ViewBag.mt_plan_id = new SelectList(db.mt_plan, "mt_plan_id", "mt_plan_name", mt_planday.mt_plan_id);
            return View(mt_planday);
        }

        //
        // POST: /Planday/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(mt_planday mt_planday)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mt_planday).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.mt_plan_id = new SelectList(db.mt_plan, "mt_plan_id", "mt_plan_name", mt_planday.mt_plan_id);
            return View(mt_planday);
        }

        //
        // GET: /Planday/Delete/5

        public ActionResult Delete(string id = null)
        {
            mt_planday mt_planday = db.mt_planday.Find(id);
            if (mt_planday == null)
            {
                return HttpNotFound();
            }
            return View(mt_planday);
        }

        //
        // POST: /Planday/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            mt_planday mt_planday = db.mt_planday.Find(id);
            db.mt_planday.Remove(mt_planday);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
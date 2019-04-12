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
    public class PlanMarkController : Controller
    {
        private ikeepfitEntities db = new ikeepfitEntities();

        //
        // GET: /PlanMark/

        public ActionResult Index()
        {
            var mt_planmark = db.mt_planmark.Include(m => m.mt_mark).Include(m => m.mt_plan);
            return View(mt_planmark.ToList());
        }

        //
        // GET: /PlanMark/Details/5

        public ActionResult Details(string id = null)
        {
            mt_planmark mt_planmark = db.mt_planmark.Find(id);
            if (mt_planmark == null)
            {
                return HttpNotFound();
            }
            return View(mt_planmark);
        }

        //
        // GET: /PlanMark/Create

        public ActionResult Create()
        {
            ViewBag.mt_mark_id = new SelectList(db.mt_mark, "mt_mark_id", "mt_mark_name");
            ViewBag.mt_plan_id = new SelectList(db.mt_plan, "mt_plan_id", "mt_plan_name");
            return View();
        }

        //
        // POST: /PlanMark/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(mt_planmark mt_planmark)
        {
            if (ModelState.IsValid)
            {
                db.mt_planmark.Add(mt_planmark);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.mt_mark_id = new SelectList(db.mt_mark, "mt_mark_id", "mt_mark_name", mt_planmark.mt_mark_id);
            ViewBag.mt_plan_id = new SelectList(db.mt_plan, "mt_plan_id", "mt_plan_name", mt_planmark.mt_plan_id);
            return View(mt_planmark);
        }

        //
        // GET: /PlanMark/Edit/5

        public ActionResult Edit(string id = null)
        {
            mt_planmark mt_planmark = db.mt_planmark.Find(id);
            if (mt_planmark == null)
            {
                return HttpNotFound();
            }
            ViewBag.mt_mark_id = new SelectList(db.mt_mark, "mt_mark_id", "mt_mark_name", mt_planmark.mt_mark_id);
            ViewBag.mt_plan_id = new SelectList(db.mt_plan, "mt_plan_id", "mt_plan_name", mt_planmark.mt_plan_id);
            return View(mt_planmark);
        }

        //
        // POST: /PlanMark/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(mt_planmark mt_planmark)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mt_planmark).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.mt_mark_id = new SelectList(db.mt_mark, "mt_mark_id", "mt_mark_name", mt_planmark.mt_mark_id);
            ViewBag.mt_plan_id = new SelectList(db.mt_plan, "mt_plan_id", "mt_plan_name", mt_planmark.mt_plan_id);
            return View(mt_planmark);
        }

        //
        // GET: /PlanMark/Delete/5

        public ActionResult Delete(string id = null)
        {
            mt_planmark mt_planmark = db.mt_planmark.Find(id);
            if (mt_planmark == null)
            {
                return HttpNotFound();
            }
            return View(mt_planmark);
        }

        //
        // POST: /PlanMark/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            mt_planmark mt_planmark = db.mt_planmark.Find(id);
            db.mt_planmark.Remove(mt_planmark);
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
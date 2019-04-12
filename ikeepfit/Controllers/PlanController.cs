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
    public class PlanController : Controller
    {
        private ikeepfitEntities db = new ikeepfitEntities();

        //
        // GET: /Plan/

        public ActionResult Index()
        {
            return View(db.mt_plan.ToList());
        }

        //
        // GET: /Plan/Details/5

        public ActionResult Details(string id = null)
        {
            mt_plan mt_plan = db.mt_plan.Find(id);
            if (mt_plan == null)
            {
                return HttpNotFound();
            }
            return View(mt_plan);
        }

        //
        // GET: /Plan/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Plan/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(mt_plan mt_plan)
        {
            if (ModelState.IsValid)
            {
                db.mt_plan.Add(mt_plan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mt_plan);
        }

        //
        // GET: /Plan/Edit/5

        public ActionResult Edit(string id = null)
        {
            mt_plan mt_plan = db.mt_plan.Find(id);
            if (mt_plan == null)
            {
                return HttpNotFound();
            }
            return View(mt_plan);
        }

        //
        // POST: /Plan/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(mt_plan mt_plan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mt_plan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mt_plan);
        }

        //
        // GET: /Plan/Delete/5

        public ActionResult Delete(string id = null)
        {
            mt_plan mt_plan = db.mt_plan.Find(id);
            if (mt_plan == null)
            {
                return HttpNotFound();
            }
            return View(mt_plan);
        }

        //
        // POST: /Plan/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            mt_plan mt_plan = db.mt_plan.Find(id);
            db.mt_plan.Remove(mt_plan);
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
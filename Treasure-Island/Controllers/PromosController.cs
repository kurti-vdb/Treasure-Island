using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using vs_project.DAL;
using vs_project.Models;

namespace vs_project.Controllers
{
    public class PromosController : Controller
    {
        private BrandContext db = new BrandContext();


        [HttpPost]
        public ActionResult Validate(string Code)
        {
            var promos = db.Promos;
            int codeOK = (from promo in db.Promos
                          where promo.Code == Code
                          select promo).Count();

            if (codeOK == 0)
                return RedirectToAction("Index");
            else
            {
                Session["ID"] = Code;

                return RedirectToAction("Index", "Survey");
            }
                
        }

        public ActionResult ValidateCode(string Code)
        {
            var promos = db.Promos;
            int codeOK = (from promo in db.Promos
                          where promo.Code == Code
                          select promo).Count();

            if (codeOK == 0)
                return RedirectToAction("Index");
            else
                return RedirectToAction("Index", "Game");

        }


   

        // GET: Promos
        public ActionResult Index()
        {
            return View(db.Promos.ToList());
            //return View();
        }

        // GET: Promos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Promo promo = db.Promos.Find(id);
            if (promo == null)
            {
                return HttpNotFound();
            }
            return View(promo);
        }

        // GET: Promos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Promos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Code")] Promo promo)
        {
            if (ModelState.IsValid)
            {
                db.Promos.Add(promo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(promo);
        }

        // GET: Promos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Promo promo = db.Promos.Find(id);
            if (promo == null)
            {
                return HttpNotFound();
            }
            return View(promo);
        }

        // POST: Promos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Code")] Promo promo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(promo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(promo);
        }

        // GET: Promos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Promo promo = db.Promos.Find(id);
            if (promo == null)
            {
                return HttpNotFound();
            }
            return View(promo);
        }

        // POST: Promos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Promo promo = db.Promos.Find(id);
            db.Promos.Remove(promo);
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

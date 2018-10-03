using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vs_project.DAL;
using vs_project.Models;
using vs_project.Utils;

namespace vs_project.Controllers
{

    [SessionTimeout]
    public class SurveyController : Controller
    {
        private BrandContext db = new BrandContext();

        // GET: Survey
        public ActionResult Index()
        {
            //return View(db.Surveys.ToList());
            //return View(db.Surveys.First());

            ViewBag.Titles = db.Titles.ToList();
            ViewBag.Stores = db.Stores.ToList();

            return View(db.Questions.ToList());
        }

        public ActionResult ByID(int ID)
        {
            return View(db.Surveys.First(i => i.ID == ID));
        }

        //[HttpPost]
        //public ActionResult SurveySubmit(User user)
        //{
        //    return RedirectToAction("_prototype/bedankt.html");
        //}
    }
}
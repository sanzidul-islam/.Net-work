using SEF.Models.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SEF.Controllers
{
    public class StudentController : Controller
    {
        private int id;

        public int ID { get; private set; }

        // GET: Student
        public ActionResult Index()
        {
            StdEntities db = new StdEntities();
            var data = db.Students.ToList();
            return View(data);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student s)
        {
            if (ModelState.IsValid)
            {
                StdEntities db = new StdEntities();
                db.Students.Add(s);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public ActionResult Add(int id)
        {
            var db = new StdEntities();
            var data = (from d in db.Students where d.ID == id select d).SingleOrDefault();
        
            return View(data);

        }
        [HttpPost]
        public ActionResult Add(Student s)
        {
            var db = new StdEntities();
            var user = (from d in db.Students where d.ID == s.ID select d).FirstOrDefault();
            user.Name = s.Name;
            user.CGPA = s.CGPA;
            user.Fname = s.Fname;
            try
            {
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (DbEntityValidationException n)
            {
                return View(s);
            }
        }
        public ActionResult Delete(int ID)
        {
            var db = new StdEntities();
            var s = (from d in db.Students where d.ID == ID select d).SingleOrDefault();
            db.Students.Remove(s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
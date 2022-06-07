using reg_form.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace reg_form.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult form()
        {
            return View(new student());
        }
        [HttpPost]
        public ActionResult form(student s)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Home", "form");
            }
            return View(s);
        }
        [HttpPost]
        public ActionResult submit()
        {
            /* if (ModelState.IsValid)
             {
                 return View(s);
             }
             return RedirectToAction("form");*/
            return View();
        }
    }
}  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CV.Controllers
{
    public class workController : Controller
    {
        // GET: work
        public ActionResult Projects()
        {
            return View();
        }
    }
}
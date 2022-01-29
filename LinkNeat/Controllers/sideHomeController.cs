using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LinkNeat.Controllers
{
    public class sideHomeController : Controller
    {
        // GET: sideHome
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult TopMenu()
        {
            return PartialView();
        }

        public ActionResult Service()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LinkNeat.Controllers
{
    public class PartialController : Controller
    {
        // GET: Partial
        public PartialViewResult about()
        {
            return PartialView();
        }

        // GET: Partial
        public PartialViewResult Service()
        {
            return PartialView();
        }

        // GET: Partial
        public PartialViewResult Gallery()
        {
            return PartialView();
        }

        // GET: Partial
        public PartialViewResult InfoMy()
        {
            return PartialView();
        }

        // GET: Partial
        public PartialViewResult Alti()
        {
            return PartialView();
        }
    }
}
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LinkNeat.Controllers
{
    public class EmailController : Controller
    {
        ContectManager contManager = new ContectManager(new EfContectDal());
        // GET: Email
        public ActionResult Index()
        {
            var molan = contManager.GetAll();
            return View(molan);
        }

        public ActionResult ReadMasseg(int ID)
        {
            var items = contManager.GetById(ID);
            var mdates = items.contectDate.ToShortDateString();
            ViewBag.mdates = mdates;
            return View(items);
        }
        public ActionResult RemoveMasseg(int ID)
        {
            var remmove = contManager.GetById(ID);
            contManager.ContectRemove(remmove);
            return RedirectToAction("Index");
        }

    }
}
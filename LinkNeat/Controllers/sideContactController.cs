using BusinessLayer.Concrete;
using BusinessLayer.ValidationsRolls;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LinkNeat.Controllers
{
    public class sideContactController : Controller
    {
        ContectManager cm = new ContectManager(new EfContectDal());
        infoContectManager infoManager = new infoContectManager(new EfinfoContectDal());
        // GET: sideContact
        public ActionResult Index()
        {
            var mitem = infoManager.GetAll().Where(x => x.mcontectAct.Equals(true)).LastOrDefault();
            if (mitem != null)
            {
                return View(mitem);
            }
            return View();
        }

        [HttpGet]
        public PartialViewResult SendContact()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SendContact(Contect c)
        {

            ContactValidator mValidator = new ContactValidator();

            ValidationResult result = mValidator.Validate(c);
            if (result.IsValid)
            {
                c.contectDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                cm.ContectAdd(c);
                return PartialView();
            }
            else
            {
                foreach (var items in result.Errors)
                {
                    ModelState.AddModelError(items.PropertyName, items.ErrorMessage);
                }

            }

            return PartialView();
        }

        public PartialViewResult infContectim()
        {
            var ittem = infoManager.GetAll();
            return PartialView();
        }


    }
}
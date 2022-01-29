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
    public class CatagoryController : Controller
    {

        CatagoryManager mcatagory = new CatagoryManager(new EfCatagoryDal());
        // GET: Catagory
        public ActionResult Index()
        {
            var mitem = mcatagory.GetAll();
            return View(mitem);
        }

        public ActionResult CategoryView(Catagory c)
        {
            return View();
        }

        [HttpGet]
        public ActionResult addCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult addCategory(Catagory c)
        {
            CategoryValidator mValidator = new CategoryValidator();

            ValidationResult result = mValidator.Validate(c);
            if (result.IsValid)
            {
                c.catagoryAct = true;
                mcatagory.CatagoryAdd(c);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var items in result.Errors)
                {
                    ModelState.AddModelError(items.PropertyName, items.ErrorMessage);
                }

            }

            return View();
        }

        [HttpGet]
        public ActionResult EditCatagory(int ID)
        {
            var myCatagory = mcatagory.GetById(ID);
            return View(myCatagory);
        }

        [HttpPost]
        public ActionResult EditCatagory(Catagory catagory)
        {
            mcatagory.CatagoryUpdate(catagory);
            return RedirectToAction("Index");
        }

        public ActionResult removeCategory(int ID)
        {
            var mitems = mcatagory.GetById(ID);
            mcatagory.CatagoryRemove(mitems);
            return RedirectToAction("Index");
        }

        public ActionResult changeCategory(int ID)
        {
            var mitme = mcatagory.GetById(ID);
            if (mitme.catagoryAct.Equals(true))
            {
                mitme.catagoryAct = false;
            }
            else
            {
                mitme.catagoryAct = true;
            }
            mcatagory.CatagoryUpdate(mitme);
            return RedirectToAction("Index");
        }
    }
}
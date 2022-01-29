using BusinessLayer.Concrete;
using BusinessLayer.ValidationsRolls;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LinkNeat.Controllers
{
    public class EnployeeController : Controller
    {
        EmployeeUserManager employeeUserManager = new EmployeeUserManager(new EfEmployeeUserDal());
        CatagoryManager catManager = new CatagoryManager(new EfCatagoryDal());
        // GET: Enployee
        public ActionResult Index()
        {
            var mitemm = employeeUserManager.GetAll();
            return View(mitemm);
        }


        [HttpGet]
        public ActionResult addEmployee()
        {
            List<SelectListItem> CatList = (from x in catManager.GetAll()
                                            select new SelectListItem
                                            {
                                                Text = x.catagoryName,
                                                Value = x.catagoryID.ToString()
                                            }).ToList();
            ViewBag.mCatList = CatList;
            return View();
        }

        [HttpPost]
        public ActionResult addEmployee(EmployeeUser employeeUser)
        {
            EmployeeValidator mValidator = new EmployeeValidator();

            ValidationResult result = mValidator.Validate(employeeUser);


            if (result.IsValid)
            {
                employeeUser.SavedateTime = DateTime.Parse(DateTime.Now.ToShortDateString());
                employeeUser.employeeAct = false;                
                if (Request.Files.Count > 0)
                {
                    string dosyaAdi = Path.GetFileName(Request.Files[0].FileName);
                    string dosyaUznti = Path.GetExtension(Request.Files[0].FileName);
                    string yool = "~/EmployeePhoto/" + dosyaAdi + dosyaUznti;
                    Request.Files[0].SaveAs(Server.MapPath(yool));
                    employeeUser.employeePhoto = "/EmployeePhoto/" + dosyaAdi + dosyaUznti;


                }
                employeeUserManager.EmployeeUserAdd(employeeUser);
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

        public ActionResult removeEmployee(int ID)
        {
            var mitem = employeeUserManager.GetById(ID);
            employeeUserManager.EmployeeUserRemove(mitem);
            return RedirectToAction("Index");
        }

        public ActionResult changeEmployee(int ID)
        {
            var mitem = employeeUserManager.GetById(ID);
            if (mitem.employeeAct.Equals(true))
            {
                mitem.employeeAct = false;
            }
            else
            {
                mitem.employeeAct = true;
            }
            employeeUserManager.EmployeeUserUpdate(mitem);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult updateEmployee(int ID)
        {
            List<SelectListItem> CatList = (from x in catManager.GetAll()
                                            select new SelectListItem
                                            {
                                                Text = x.catagoryName,
                                                Value = x.catagoryID.ToString()
                                            }).ToList();
            ViewBag.mCatList = CatList;

            var mitems = employeeUserManager.GetById(ID);
            return View(mitems);
        }

        [HttpPost]
        public ActionResult updateEmployee(EmployeeUser employeeUser)
        {
            employeeUserManager.EmployeeUserUpdate(employeeUser);
            return RedirectToAction("Index");
        }

        public ActionResult viewEmployee(int ID)
        {
            var mitems = employeeUserManager.GetById(ID);
            var mdate = mitems.SavedateTime.ToShortDateString();
            ViewBag.mdate = mdate;
            return View(mitems);
        }

    }
}
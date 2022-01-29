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
    public class sideAddCompanyController : Controller
    {
        CompanyManager comManager = new CompanyManager(new EfCompanyDal());
        EmployeeUserManager employeeManger = new EmployeeUserManager(new EfEmployeeUserDal());

        CatagoryManager cotManager = new CatagoryManager(new EfCatagoryDal());
        // GET: sideAddCompany
        [HttpGet]
        public ActionResult addSideCompany()
        {
            List<SelectListItem> MyCatagory = (from x in cotManager.GetAll()
                                               select new SelectListItem
                                               {
                                                   Text = x.catagoryName,
                                                   Value = x.catagoryID.ToString()
                                               }).ToList();
            ViewBag.MyCatagory = MyCatagory;
            return View();
        }

        [HttpPost]
        public ActionResult addSideCompany(Company company)
        {
            CompanyValidator mValidator = new CompanyValidator();

            ValidationResult result = mValidator.Validate(company);


            if (result.IsValid)
            {
                company.companySaveDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                if (Request.Files.Count > 0)
                {
                    string dosyaAdi = Path.GetFileName(Request.Files[0].FileName);
                    string dosyaUznti = Path.GetExtension(Request.Files[0].FileName);
                    string yool = "~/CompanyLogo/" + dosyaAdi + dosyaUznti;
                    Request.Files[0].SaveAs(Server.MapPath(yool));
                    company.companyLogoPhoto = "/CompanyLogo/" + dosyaAdi + dosyaUznti;
                }
                comManager.CompanyAdd(company);
                return RedirectToAction("Index", "sideHome");
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
        public ActionResult addSideEmployee()
        {
            List<SelectListItem> CatList = (from x in cotManager.GetAll().Where(x=>x.catagoryAct.Equals(true))
                                               select new SelectListItem
                                               {
                                                   Text = x.catagoryName,
                                                   Value = x.catagoryID.ToString()
                                               }).ToList();
            ViewBag.mCatList = CatList;
            return View();
        }

        [HttpPost]
        public ActionResult addSideEmployee(EmployeeUser employeeUser)
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
                employeeManger.EmployeeUserAdd(employeeUser);
                return RedirectToAction("Index", "sideHome");
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

    }
}
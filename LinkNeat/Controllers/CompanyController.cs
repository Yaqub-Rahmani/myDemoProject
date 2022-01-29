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
    public class CompanyController : Controller
    {
        CompanyManager copManager = new CompanyManager(new EfCompanyDal());
        CatagoryManager cotManager = new CatagoryManager(new EfCatagoryDal());
        // GET: Company
        public ActionResult Index()
        {
            var mData = copManager.GetAll();
            return View(mData);
        }

        [HttpGet]
        public ActionResult AddCompany()
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
        public ActionResult AddCompany(Company com)
        {
            CompanyValidator mValidator = new CompanyValidator();

            ValidationResult result = mValidator.Validate(com);


            if (result.IsValid)
            {
                com.companySaveDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                if (Request.Files.Count > 0)
                {
                    string dosyaAdi = Path.GetFileName(Request.Files[0].FileName);
                    string dosyaUznti = Path.GetExtension(Request.Files[0].FileName);
                    string yool = "~/CompanyLogo/" + dosyaAdi + dosyaUznti;
                    Request.Files[0].SaveAs(Server.MapPath(yool));
                    com.companyLogoPhoto = "/CompanyLogo/" + dosyaAdi + dosyaUznti;
                }
                copManager.CompanyAdd(com);
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
        public ActionResult UpdateCompany(int ID)
        {
            List<SelectListItem> MyCatagory = (from x in cotManager.GetAll()
                                               select new SelectListItem
                                               {
                                                   Text = x.catagoryName,
                                                   Value = x.catagoryID.ToString()
                                               }).ToList();
            ViewBag.MyCatagory = MyCatagory;

            var companyValue = copManager.GetById(ID);            
            return View(companyValue);
        }
        
        [HttpPost]
        public ActionResult UpdateCompany(Company company)
        {
            copManager.CompanyUpdate(company);
            return RedirectToAction("Index");
        }

        public ActionResult RemoveCompany(int ID)
        {
            var remove = copManager.GetById(ID);
            copManager.CompanyRemove(remove);
            return RedirectToAction("Index");
        }

        public ActionResult viewCompany(int ID)
        {
            var miiteems = copManager.GetById(ID);
            var mdate = miiteems.companySaveDate.ToShortDateString();
            ViewBag.mdate = mdate;
            return View(miiteems);
        }
    }
}
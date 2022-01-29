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
    public class AboutController : Controller
    {
        AboutManager abtman = new AboutManager(new EfAboutDal());
        // GET: About
        public ActionResult Index()
        {
            var kimat = abtman.GetAll();
            return View(kimat);
        }
        [HttpGet]
        public ActionResult addAbout()
        {

            return View();
        }
        [HttpPost]
        public ActionResult addAbout(About about)
        {
            AboutValidator mValidator = new AboutValidator();

            ValidationResult result = mValidator.Validate(about);


            if (result.IsValid)
            {
                about.aboutDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                about.aboutAct = true;
                if (Request.Files.Count > 0)
                {
                    string dosyaAdi = Path.GetFileName(Request.Files[0].FileName);
                    string dosyaUznti = Path.GetExtension(Request.Files[0].FileName);
                    string yool = "~/AboutPhoto/" + dosyaAdi + dosyaUznti;
                    Request.Files[0].SaveAs(Server.MapPath(yool));
                    about.aboutPhotoUrl = "/AboutPhoto/" + dosyaAdi + dosyaUznti;
                }
                abtman.AboutAdd(about);
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

        public ActionResult changeAbout(int ID)
        {
            var mitim = abtman.GetById(ID);
            if (mitim.aboutAct.Equals(true))
            {
                mitim.aboutAct = false;
                
            }
            else
            {
                mitim.aboutAct = true;
            }
            abtman.AboutUpdate(mitim);
            return RedirectToAction("Index");
        }

        public ActionResult removeAbout(int ID)
        {
            var mittm = abtman.GetById(ID);
            abtman.AboutRemove(mittm);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult updateAbout(int ID)
        {
            var mmitem = abtman.GetById(ID);
            return View(mmitem);
        }

        [HttpPost]
        public ActionResult updateAbout(About about)
        {
            abtman.AboutUpdate(about);
            return RedirectToAction("Index");
        }

    }
}
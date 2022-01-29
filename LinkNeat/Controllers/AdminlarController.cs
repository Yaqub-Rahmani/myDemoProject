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
using System.Web.Security;

namespace LinkNeat.Controllers
{
    public class AdminlarController : Controller
    {
        AdminLarManager madmin = new AdminLarManager(new EfAdminLarDal());
        // GET: Adminlar
        public ActionResult Index()
        {
            var manigData = madmin.GetAll();
            return View(manigData);
        }

        [HttpGet]
        public ActionResult LoginIN()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginIN(AdminLar adminLar)
        {


            var admininfo = madmin.GetByUserNameForLogin(adminLar);
            if (admininfo != null)
            {
                FormsAuthentication.SetAuthCookie(adminLar.AdminUserName, false);
                return RedirectToAction("Index", "AnaPage");
            }
            return RedirectToAction("LoginIN");
        }
        public ActionResult logOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "sideHome");
        }


        [HttpGet]
        public ActionResult addAdmin()
        {
            return View();
        }


        [HttpPost]
        public ActionResult addAdmin(AdminLar adminLar)
        {
            AdminValidator mValidator = new AdminValidator();

            ValidationResult result = mValidator.Validate(adminLar);


            if (result.IsValid)
            {
                adminLar.AdminAct = true;
                if (Request.Files.Count > 0)
                {
                    string dosyaAdi = Path.GetFileName(Request.Files[0].FileName);
                    string dosyaUznti = Path.GetExtension(Request.Files[0].FileName);
                    string yool = "~/AdminPhoto/" + dosyaAdi + dosyaUznti;
                    Request.Files[0].SaveAs(Server.MapPath(yool));
                    adminLar.AdminPhotoUrl = "/AdminPhoto/" + dosyaAdi + dosyaUznti;
                }
                madmin.AdminLarAdd(adminLar);
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

        public ActionResult changeAdmin(int ID)
        {
            var mitems = madmin.GetById(ID);
            if (mitems.AdminAct.Equals(true))
            {
                mitems.AdminAct = false;
                madmin.AdminLarUpdate(mitems);
                return RedirectToAction("Index");
            }
            else
            {
                mitems.AdminAct = true;
                madmin.AdminLarUpdate(mitems);
                return RedirectToAction("Index");
            }
        }

        public ActionResult removeAdmin(int ID)
        {
            var miitem = madmin.GetById(ID);
            madmin.AdminLarRemove(miitem);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult updateAdmin(int ID)
        {
            var mitems = madmin.GetById(ID);
            return View(mitems);
        }

        [HttpPost]
        public ActionResult updateAdmin(AdminLar adminLar)
        {
            madmin.AdminLarUpdate(adminLar);
            return RedirectToAction("Index");
        }

    }
}
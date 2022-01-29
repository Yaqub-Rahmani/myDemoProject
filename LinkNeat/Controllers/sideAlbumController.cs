using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LinkNeat.Controllers
{
    public class sideAlbumController : Controller
    {
        AboutManager AM = new AboutManager(new EfAboutDal());
        // GET: sideAlbum
        public ActionResult Index()
        {
            var miltem = AM.GetAll(); 
            return View(miltem);
        }
    }
}
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Web.WebPages.Html;

namespace MVCproject.Controllers
{
    public class HeadingController : Controller
    {
        //HeadingManager(); içerisin parametre değeri veriyoruz.
        HeadingManager hm = new HeadingManager(new EfHeadingDal());

        public ActionResult Index()
        {
            var headingvalues = hm.GetList();   
            return View(headingvalues);
        }

        [HttpGet]
        public ActionResult AddHeading()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {
            //Bugünün kısa tarihini getirir.
            p.HeadingDate= DateTime.Parse(DateTime.Now.ToShortDateString());
            hm.HeadingAdd(p);
            return RedirectToAction("Index");
        }
    }
}
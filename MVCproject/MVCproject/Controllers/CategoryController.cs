using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCproject.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        //BusinessLayer da bulunan CategoryManager sınıfımızı çağırıyoruz
        CategoryManager cm = new CategoryManager();

        public ActionResult Index()
        {
            return View();
        }

        //GetCategoryList sql tablodaki verileri çekmek için yazdığımız metod.
        public ActionResult GetCategoryList() 
        {
            // categoryvalues değişikenimizin içerisine kategori tablodaki veriler gelicek.
            var categoryvalues = cm.GetAllBl();
            return View(categoryvalues);
        }

        //Sayfa yüklendikten sonra [HttpGet] çalışacak.
        //Aynı isimli ActionResult ın üzerinde çalışacak.
        [HttpGet]
        public ActionResult AddCategory()
        {
            //Sayfayı geri göndürür.
            return View();
        }

        //Yeni kategori eklemek için kullanacağımız metod.
        //Kategori ekleme işleminde üzerinde çalıştığımız entitiden türetilmiş bir parametre göndermemiz gerekiyor.
        //Sayfada bir butona tıkladığımız zaman [HttpPost] çalışacak.
        [HttpPost]
        public ActionResult AddCategory(Category p) 
        {
            cm.CategoryADDBl(p);
            //Ekleme işlemini gerçekleştikten sonra bizi tanımlamış olduğumuz GetCategoryList metoduna yönlendir.
            //RedirectToAction => Aksiyona doğru yönlendir.
            return RedirectToAction("GetCategoryList");
        }
    }
} 
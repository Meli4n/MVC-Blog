﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCproject.Controllers
{
    public class GalleryController : Controller
    {

        ImageFileManager ifm = new ImageFileManager(new EFImageDal());
        public ActionResult Index()
        {
            var files = ifm.GetList();
            return View(files);
        }
    }
}
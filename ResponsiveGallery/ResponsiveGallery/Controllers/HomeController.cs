using ResponsiveGallery.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResponsiveGallery.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            List<GalleryImage> images = new List<GalleryImage>();
            GalleryImage testimage = new GalleryImage(true, "Cat Image", Url.Content("~/Images/DSC00885.jpg"), new List<Tag>() ) ;
            for (int i = 0; i < 10; i++)
                images.Add(testimage);
            return View(images);
        }
    }
}

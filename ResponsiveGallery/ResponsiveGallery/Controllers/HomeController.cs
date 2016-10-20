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
            GalleryImage longnameimage = new GalleryImage(true, "Another Cat Image but this time with a really long title", Url.Content("~/Images/DSC00885.jpg"), new List<Tag>());
            images.Add(longnameimage);
            for (int i = 0; i < 10; i++)
                images.Add(testimage);
            images.Add(longnameimage);
            images.Add(longnameimage);
            for (int i = 0; i < 15; i++)
                images.Add(testimage);
            return View(images);
        }
    }
}

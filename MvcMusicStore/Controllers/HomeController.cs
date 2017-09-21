using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Message()
        {
            ViewBag.Message = "This is a partial view";
            ViewBag.WatchThis = "this is another line for the partial view to be rendered";
            return PartialView();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Details()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF6Sample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Manoj_PlaygroundEntities dbCtxt = new Manoj_PlaygroundEntities();
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
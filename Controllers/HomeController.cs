using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Logging1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ILog log = LogManager.GetLogger("mylog");
            log.Info("Home Page request");
            log.Error("This is an error message");
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
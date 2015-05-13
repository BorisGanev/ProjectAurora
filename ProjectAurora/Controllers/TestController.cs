using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectAurora.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult GameCatalogTemp()
        {
            return View();
        }
        
        public ActionResult Dota2()
        {
            return View();
        }

        public ActionResult BloodborneNews()
        {
            return View();
        }

        public ActionResult NewsPageTemp()
        {
            return View();
        }
    }
}
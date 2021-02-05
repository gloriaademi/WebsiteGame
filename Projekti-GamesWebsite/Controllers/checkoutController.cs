using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekti_GamesWebsite.Controllers
{
    public class checkoutController : Controller
    {
        // GET: checkout
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult checkout()
        {
            return View();
        }
    }
}
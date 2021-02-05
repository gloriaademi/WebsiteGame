using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekti_GamesWebsite.Controllers
{
    public class CartController : Controller
    {
        [HttpGet]
        public ActionResult Cart()
        {
            return View();
        }
    }
}
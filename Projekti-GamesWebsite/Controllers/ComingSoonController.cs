﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekti_GamesWebsite.Controllers
{
    public class comingsoonController : Controller
    {[HttpGet]
        
        public ActionResult comingsoon()
        {
            return View();
        }
    }
}
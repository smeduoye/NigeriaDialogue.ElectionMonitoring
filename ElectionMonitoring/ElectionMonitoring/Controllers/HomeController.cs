﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElectionMonitoring.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EnterResults()
        {
            return View();
        }

        public ActionResult Projects()
        {
            return View();
        }
    }
}

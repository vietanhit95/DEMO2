﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DEMO2.Controllers
{
    public class C1Controller : Controller
    {
        //
        // GET: /C1/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Detail(int id)
        {
            return View();
        }
        public ActionResult MiuMiu()
        {
            return View();
        }
	}
}
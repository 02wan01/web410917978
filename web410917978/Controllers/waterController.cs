﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web410917978.Controllers
{
    public class waterController : Controller
    {
        // GET: water
        public ActionResult Index(string name, float? weight)
        {
            var result = "";
            if (weight.HasValue)
            {
                result = (weight * 30) + "cc";
            }

            ViewBag.name = name;
            ViewBag.result = result;
            return View();
        }
    }
}
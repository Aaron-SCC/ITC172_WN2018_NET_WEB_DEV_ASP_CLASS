﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataEntitiesWizards.Models;

namespace DataEntitiesWizards.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Community_AssistEntities db = new Community_AssistEntities();
            return View(db.GrantTypes.ToList());
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
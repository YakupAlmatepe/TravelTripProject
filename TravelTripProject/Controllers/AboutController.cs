﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Sınıflar;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context context = new Context();
  
        public ActionResult Index()
        {
            //var degerler = context.Hakkimizdas.ToList();   
            var values =context.Hakkimizdas.ToList();
          
            return View(values);
        }
    }
}
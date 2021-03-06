﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IspolarSite.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.ShowBanner = false;
            ViewBag.ShowCarousel = true;
            return View();
        }

        [Route("About")]
        public IActionResult About()
        {
            ViewBag.ShowBanner = true;
            ViewBag.ShowCarousel = false;
            return View();
        }

        [Route("Species")]
        public IActionResult Species()
        {
            ViewBag.ShowBanner = true;
            ViewBag.ShowCarousel = false;
            return View();
        }

        [Route("Contact")]
        public IActionResult Contact()
        {
            ViewBag.ShowBanner = true;
            ViewBag.ShowCarousel = false;
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace IspolarSite.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.ShowBanner = true;
            return View();
        }

        [Route("About")]
        public IActionResult About()
        {
            ViewBag.ShowBanner = true;
            return View();
        }

        [Route("Species")]
        public IActionResult Species()
        {
            ViewBag.ShowBanner = true;
            return View();
        }

        [Route("Contact")]
        public IActionResult Contact()
        {
            ViewBag.ShowBanner = true;
            return View();
        }
    }
}

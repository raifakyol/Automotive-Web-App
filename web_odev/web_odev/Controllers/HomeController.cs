using BusinessLayer.Concrete;
using DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using web_odev.Models;

namespace web_odev.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        AracManager arm = new AracManager(new AracRepository());
        OpsiyonlarManager om = new OpsiyonlarManager(new OpsiyonlarRepository());
        GalleryManager gm = new GalleryManager(new GalleryRepository());
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var values = gm.GetList();
            return View(values);
        }
        public IActionResult FiyatListeleri()
        {
            var values = arm.GetList();     
            return View(values);
        }
        public IActionResult Opsiyon()
        {
            var values = om.GetList();
            return View(values);
        }
        public IActionResult ServisRandevu()
        {
            return View();
        }
        public IActionResult Kesfet()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}


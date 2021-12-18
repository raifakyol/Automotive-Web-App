using BusinessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_odev.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FiyatController : Controller
    {
        AracManager arcm = new AracManager(new AracRepository());
        public IActionResult Index()
        {
            var values = arcm.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddArac()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddArac(Arac a)
        {
            arcm.AracAdd(a);
            return RedirectToAction("Index", "Fiyat");
        }
    }
}

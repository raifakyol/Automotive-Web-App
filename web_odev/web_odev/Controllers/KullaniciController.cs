using BusinessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_odev.Controllers
{
    [AllowAnonymous]
    public class KullaniciController : Controller
    {
        KullaniciManager kmn = new KullaniciManager(new KullaniciRepository());
        
        public IActionResult Kullanici()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Kullanici(Kullanici k)
        {
            kmn.KullaniciAdd(k);
            return RedirectToAction("Kullanici","Kullanici");
        }
    }
}

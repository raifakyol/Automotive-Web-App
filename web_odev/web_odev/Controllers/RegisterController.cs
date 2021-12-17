using BusinessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_odev.Controllers
{
    public class RegisterController : Controller
    {
        AdminManager adm = new AdminManager(new AdminRepository());
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Admin a)
        {
            a.AdminRole = "B";
            adm.AdminAdd(a);

            return RedirectToAction("Index","Home");
        }
    }
}

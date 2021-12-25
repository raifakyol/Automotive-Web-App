using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_odev.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        AdminManager adm = new AdminManager(new AdminRepository());
        Context c = new Context();
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
            var datavalue = c.Admins.FirstOrDefault(x => x.Admin_UserName == a.Admin_UserName && x.Password == a.Password);
            if (datavalue != null)
            {
                HttpContext.Session.SetString("Admin_UserName", a.Admin_UserName);  
            }
            return RedirectToAction("Login", "Login");
        }
    }
}

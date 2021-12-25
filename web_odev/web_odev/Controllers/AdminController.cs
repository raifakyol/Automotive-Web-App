using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace web_odev.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        Context c = new Context();
       
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AdminLogin()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> AdminLogin(Admin p)
        {
            var datavalue = c.Admins.FirstOrDefault(x => x.Admin_UserName == p.Admin_UserName && x.Password == p.Password);
            if (datavalue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.Admin_UserName)
                };
                var useridentity = new ClaimsIdentity(claims, "A");
                if(p.Admin_UserName=="g191210017@sakarya.edu.tr" && p.Password == "123")
                {
                    ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                    await HttpContext.SignInAsync(principal);
                    return RedirectToAction("Index", "Admin");
                }
                if (p.Admin_UserName == "G191210017@sakarya.edu.tr" && p.Password == "123")
                {
                    ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                    await HttpContext.SignInAsync(principal);
                    return RedirectToAction("Index", "Admin");
                }
                else
                    return View();

            }
            return View();
        }
    }
}

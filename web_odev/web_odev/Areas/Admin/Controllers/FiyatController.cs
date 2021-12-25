using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation.Results;
using ValidationResult = FluentValidation.Results.ValidationResult;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;

namespace web_odev.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class FiyatController : Controller
    {
        AracManager arcm = new AracManager(new AracRepository());
        OpsiyonlarManager opm = new OpsiyonlarManager(new OpsiyonlarRepository());
        KullaniciManager km = new KullaniciManager(new KullaniciRepository());

        public IActionResult Index()
        {
            var values = km.GetList();
            return View(values);
        }
        public IActionResult Fiyat()
        {
            var values = arcm.GetList();
            return View(values);
        }
        public IActionResult Opsiyon()
        {
            var values = opm.GetList();
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
            AracValidator av = new AracValidator();
            ValidationResult results = av.Validate(a);
            if (results.IsValid)
            {
                arcm.AracAdd(a);
                return RedirectToAction("Fiyat", "Fiyat");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult AddOpsiyonlar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddOpsiyonlar(Opsiyonlar op)
        {
            OpsiyonlarValidator ov = new OpsiyonlarValidator();
            ValidationResult results = ov.Validate(op);
            if (results.IsValid)
            {
                opm.OpsiyonlarAdd(op);
                return RedirectToAction("Opsiyon", "Fiyat");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeleteOpsiyonlar(int id)
        {
            var value = opm.GetById(id);
            opm.OpsiyonlarDelete(value);
            return RedirectToAction("Opsiyon", "Fiyat");
        }
        public IActionResult DeleteArac(int id)
        {
            var value = arcm.GetById(id);
            arcm.AracDelete(value);
            return RedirectToAction("Fiyat", "Fiyat");
        }

        
        [HttpGet]
        public IActionResult UpdateOpsiyonlar(int id)
        {
            var value = opm.GetById(id);
            return View(value);
        }  
        [HttpPost]
        public IActionResult UpdateOpsiyonlar(Opsiyonlar opsiyonlar)
        {
            var value = opm.GetById(opsiyonlar.Opsiyon_ID);           
            opm.OpsiyonlarUpdate(opsiyonlar);
            return RedirectToAction("Opsiyon");
        }
        
        [HttpGet]
        public IActionResult AddKullanici()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddKullanici(Kullanici k)
        {
            KullaniciValidator kv = new KullaniciValidator();
            ValidationResult results = kv.Validate(k);
            if (results.IsValid)
            {
                km.KullaniciAdd(k);
                return RedirectToAction("Index", "Fiyat");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeleteKullanici(int id)
        {
            var value = km.GetById(id);
            km.KullaniciDelete(value);
            return RedirectToAction("Index", "Fiyat");
        }
    }
}

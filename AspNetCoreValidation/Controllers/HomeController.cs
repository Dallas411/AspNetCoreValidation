using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreValidation.Models;

namespace AspNetCoreValidation.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View(new IndexViewModel());
        //}

        public IActionResult Index(IndexViewModel indexViewModel)
        {
            ViewBag.ElaborationTime = DateTime.Now;
            ViewBag.ModelStateIsValid = ModelState.IsValid;
            return View(new IndexViewModel());
        }
    }
}

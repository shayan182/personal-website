using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Personal_mvc.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Personal_mvc.Controllers
{
    public class HomeController : Controller
    {
       
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }
       
        [HttpPost]
        public IActionResult Index(Form form)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.error = "عملیات با شکست مواجه شد!";
                return View(form);
            }
            else
            {
                ModelState.Clear();
                ViewBag.success = "عملیات با موفقیت انجام شد!";


                return View();
            }
            
        }
          public IActionResult redirectindex()
        {
            return RedirectToAction("Index");
        }
 
      

     
    }
}

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
            return new OkResult();
        }
          public IActionResult redirectindex()
        {
            return RedirectToAction("Index");
        }

      

     
    }
}

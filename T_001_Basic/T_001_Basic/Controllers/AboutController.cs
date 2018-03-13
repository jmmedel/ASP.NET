using Microsoft.AspNetCore.Mvc;
// crtl r g to delete all not use liblirary
using System;
namespace T_001_Basic.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
       
    }
}

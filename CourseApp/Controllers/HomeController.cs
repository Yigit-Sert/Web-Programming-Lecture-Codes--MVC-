using System;
using System.ComponentModel.Design;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(){
            ViewBag.Greeting= DateTime.Now.Hour > 12 ? "Good Days" : "GoodMorning";
            ViewBag.User="Deniz";

            return View();   //localhost:7260/home/index
        }

        public IActionResult About(){
            return View();   //localhost:7260/home/about
        }
    }
}
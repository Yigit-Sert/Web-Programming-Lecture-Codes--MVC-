using System.ComponentModel.Design;
using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;


namespace CourseApp.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index(){
            return View();
        }

        public IActionResult List(){
            var s=Repository.studs.Where(i=> i.Confirm==true);
            return View(s);
        }

        public IActionResult Details(){
            var course= new course();
            course.Name="ASP.Net Core MVC";
            course.Description="MVC Fundamentals";
            course.IsOpened=true;
            return View(course);
        }

        [HttpGet]
        public IActionResult Apply(){   //for only view Apply.cshtml
            return View();       //localhost/course/apply
        }
        [HttpPost]
        public IActionResult Apply(student std){   //for save form data into server
            if(ModelState.IsValid){
                //save data in  repository
                 Repository.AddStudent(std);
                 return View("Thanks", std);   //redirect Thanks.cshtml for listing data
            }
            else{
                return View(std);
            }
           
        }
    }
}
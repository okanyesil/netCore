using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;


namespace CourseApp.Controllers
{
    public class CourseController:Controller
    {
        // action method
        public IActionResult Index() {
            return View();
        }
        // localhost:500/course/apply
        [HttpGet]
        public IActionResult Apply()
        {
          
          return View();
        }
        [HttpPost]
        public IActionResult Apply(string Name, string Email, string Phone, bool Confirm)
        {
            
          return View();
        }

        public IActionResult List() {
            return View();
        }
        public IActionResult Details() {
            var course = new Course();
            course.Name ="Core MCV Kursu";
            course.description = "Güzel bir kurs";
            course.isPublished = true;
            
            return View(course);
        }
    }
    
}
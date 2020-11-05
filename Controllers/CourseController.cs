using System.Linq;
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
        public IActionResult Apply(Student student)
        {
            if(ModelState.IsValid) {
                Repository.AddStudent(student);
            } else {
                return View(student);
            }
            

          return View("Thanks", student);
        }

        public IActionResult List() {
            var students = Repository.Students.Where(i => i.Confirm == true);
            return View(students);
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
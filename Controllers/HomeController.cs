using System;
using Microsoft.AspNetCore.Mvc;


namespace CourseApp.Controllers
{
    public class HomeController:Controller
    {
        // localhost:5000/home/index
        public IActionResult Index() {
            int saat = DateTime.Now.Hour;

            ViewBag.Greeting = saat > 12 ? "iyi günler": "Günaydın";
            ViewBag.UserName = "Ahmet";

            return View();
        }
        // localhost:5000/home/about
        public IActionResult About() {
            return View();
        }

    }
    
}
using Microsoft.AspNetCore.Mvc;
using ViewImports.Models;

namespace ViewImports.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> az1 = new List<Student>
            {
                new Student { Id = 1, Name = "Ammad", Gender = "Male" },
                new Student { Id = 2, Name = "Moiz", Gender = "Male" },
                new Student { Id = 3, Name = "Shan", Gender = "Male" } 
            };

            return View(az1);
        }
        public IActionResult About()
        {
            List<Student> az1 = new List<Student>
            {
                new Student { Id = 1, Name = "Ammad", Gender = "Male" },
                new Student { Id = 2, Name = "Moiz", Gender = "Male" },
                new Student { Id = 3, Name = "Shan", Gender = "Male" }
            };

            return View(az1);

        }
        public IActionResult Contact()
        {
            List<Student> az1 = new List<Student>
            {
                new Student { Id = 1, Name = "Ammad", Gender = "Male" },
                new Student { Id = 2, Name = "Moiz", Gender = "Male" },
                new Student { Id = 3, Name = "Shan", Gender = "Male" }
            };

            return View(az1);
        }
    }
}

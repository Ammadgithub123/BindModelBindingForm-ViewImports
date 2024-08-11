using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TagHelperDemo.Models;

namespace TagHelperDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("Index")]
        public string Index(Employee az)
        {
            return " Name: " + az.Name + " Gender: " + az.Gender + " Age: " + az.Age + " Designation: " + az.Designation + " Salary: " + az.Salary + " Married: " + az.Married + " Description: " + az.Description;
        }

        public IActionResult Contact()
        {
            return View();
        }

        //public int Contact(int id)
        //{
        //    return id;
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

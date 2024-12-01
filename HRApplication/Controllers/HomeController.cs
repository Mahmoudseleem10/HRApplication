using HRApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HRApplication.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Employees()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Employees(Employees employees)
        {
            if (ModelState.IsValid)
            {
                Repository.AddEmployees(employees);
                return View("confirmation", employees);

            }
            else
                return View();
           
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
       public IActionResult AllEmployees()
        {
            return View(Repository.getEmployees().Where(Employees => Employees.isActive == true));
        }
    }
}
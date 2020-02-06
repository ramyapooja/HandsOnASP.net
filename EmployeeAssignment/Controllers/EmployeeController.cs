using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeAssignment.Models;
using EmployeeAssignment.Controllers;
using EmployeeAssignment.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace EmployeeAssignment.Controllers
{
    public class EmployeeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SignUp()
        {
            ViewBag.Designation = new SelectList(new string[] { "Worker", "Manager", "Accountant", "Employee" });
            ViewBag.ProjectName = new SelectList(new string[] { "Employee Management", "City Bank","Online registration" });
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(Employee item)
        {
            EmployeeRepository repository = new EmployeeRepository();
            repository.Add(item);
            return RedirectToAction("Login");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(int Eid, string pwd)
        {
            EmployeeRepository repository = new EmployeeRepository();
            Employee employee = repository.Validate(Eid, pwd);
            if (employee != null)
            {
                return RedirectToAction("Details", employee);
                
            }
            else
            {
                ViewData["err"] = "Invalid Credentials";
                return View();
            }
        }
        public IActionResult Details(Employee item)
        {
            return View(item);
        }
    }
}

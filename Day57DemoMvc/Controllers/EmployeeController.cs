using Day57DemoMvc.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace Day57DemoMvc.Controllers;

public class EmployeeController : Controller
{
    public IActionResult Index()
    {
        // Get a list of employees
        var employeeService = new EmployeeService();
        var employees = employeeService.GetAll();

        return View(employees);
    }

    public IActionResult Details(int id)
    {
        var employeeService = new EmployeeService();
        var employee = employeeService.GetById(id);

        return View(employee);
    }
}

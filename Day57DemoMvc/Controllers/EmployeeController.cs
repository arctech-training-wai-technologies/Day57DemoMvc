using Microsoft.AspNetCore.Mvc;

namespace Day57DemoMvc.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

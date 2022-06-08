using Microsoft.AspNetCore.Mvc;

namespace Day57DemoMvc.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

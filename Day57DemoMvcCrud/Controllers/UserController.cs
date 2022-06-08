using Day57DemoMvcCrud.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace Day57DemoMvcCrud.Controllers;

public class UserController : Controller
{
    public async Task<IActionResult> IndexAsync()
    {
        var userService = new UserService();
        var users = await userService.GetAllAsync();

        return View(users);
    }

    public async Task<IActionResult> DetailsAsync(int id)
    {
        var userService = new UserService();
        var user = await userService.GetByIdAsync(id);

        return View(user);
    }

    public IActionResult Create()
    {
        return View();
    }

    public IActionResult Update()
    {
        return View();
    }

    public IActionResult Delete()
    {
        return View();
    }
}
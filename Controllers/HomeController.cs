using Microsoft.AspNetCore.Mvc;

namespace HelloWorldApp.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        // return Content("Hello from HomeController!");
        return View();
    }
}
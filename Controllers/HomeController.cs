using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NTN123.Models;

namespace NTN123.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
[HttpPost]
    public IActionResult Index(string fullName,string Email)
    {
        ViewBag.name = "hello:"+ " "+ fullName+"-"+ Email;
        return View();
    }
}

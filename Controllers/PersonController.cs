using Microsoft.AspNetCore.Mvc;
using NTN123.Models;
namespace NTN123.Controllers
{
public class PersonController : Controller 
{
      
        [HttpGet]
        public IActionResult  Nguoi()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Nguoi(Person std)
        {
            ViewBag.Nguoi = std.TenNguoi + "-"+ std.Sothich + "-"+ std.Namsinh;
            return View();
        }
}
}
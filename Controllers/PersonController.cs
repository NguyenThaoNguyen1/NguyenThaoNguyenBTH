using Microsoft.AspNetCore.Mvc;
using NTN123.Models;
namespace NTN123.Controllers
{
public class PersonController : Controller 
{
      public IActionResult Index()

        {
            //Khởi tạo list student
            List<Person> StdList =new List<Person>()
            {
               new Person{ TenNguoi="Nguyen Văn M", Sothich="Ăn cơm", Namsinh=2001},
               new Person{ TenNguoi="Nguyen Văn H", Sothich="đi học", Namsinh=2020},
                

            };
            // ViewBag.DanhsachSV = StdList.Count();
            ViewData["Person"] = StdList;
            return View(StdList);
        }
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
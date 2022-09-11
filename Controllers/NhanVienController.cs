using Microsoft.AspNetCore.Mvc;
using NTN123.Models;
namespace NTN123.Controllers
{
public class NhanVienController : Controller 
{
      
        [HttpGet]
        public IActionResult TaoMoi()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TaoMoi(NhanVien std)
        {
            ViewBag.NhanVien = std.MaNV + "-"+ std.TenNV + "-"+ std.Quequan;
            return View();
        }
}
}
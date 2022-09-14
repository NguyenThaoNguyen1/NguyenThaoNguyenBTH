using Microsoft.AspNetCore.Mvc;
using NTN123.Models;
namespace NTN123.Controllers
{
public class NhanVienController : Controller 
{
     public IActionResult NhanVien()

        {
            //Khởi tạo list student
            List<NhanVien> StdList =new List<NhanVien>()
            {
                new NhanVien{ MaNV=1, TenNV="Nguyễn Văn A", Quequan=" Hà Nội"},
                new NhanVien{ MaNV=6, TenNV="Nguyễn Văn B", Quequan="Quảng Ninh"},
                new NhanVien{ MaNV=3, TenNV="Nguyễn Văn C", Quequan="Hòa Binh"},
                
            };
            // ViewBag.DanhsachSV = StdList.Count();
            ViewData["NhanVien"] = StdList;
            return View(StdList);
        }
      
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
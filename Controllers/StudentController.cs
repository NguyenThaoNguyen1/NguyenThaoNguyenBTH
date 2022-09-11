using Microsoft.AspNetCore.Mvc;
using NTN123.Models;

namespace NTN123.Controllers
{
public class StudentController : Controller 
{
        // viết các phương thức thao tác CRUD
        //Lấy dữ liệu của đối tượng Student
        public IActionResult Index()

        {
            //Khởi tạo list student
            List<Student> StdList =new List<Student>()
            {
                new Student{ StudentID=1, StudentName="Nguyễn Văn A", Age=14},
                new Student{ StudentID=2, StudentName="Nguyễn Văn B", Age=19},
                new Student{ StudentID=3, StudentName="Nguyễn Văn H", Age=25},
                new Student{ StudentID=4, StudentName="Nguyễn Văn K", Age=17},
                new Student{ StudentID=5, StudentName="Nguyễn Văn E", Age=10},
                new Student{ StudentID=5, StudentName="Nguyễn Văn E", Age=15},



            };
            ViewBag.DanhsachSV = StdList.Count();
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student std)
        {
            ViewBag.Sinhvien ="Hello:  "+ std.StudentID + "-"+ std.StudentName + "-"+ std.Age;
            return View();
        }
    }
}
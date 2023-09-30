using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using System.Diagnostics;
using System.Dynamic;
using website.Models;
using static website.Models.Studentdata;

namespace website.Controllers
{
    [Authorize]
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

        List<Student> students = new List<Student>();
        List<StudentInfo> studentInfo = new List<StudentInfo>();

        public IActionResult Studentdetails()
        {
            insertDummyData();

            var studentViewModel = from s in students
                                   join st in studentInfo on s.Id equals st.StdId into st2
                                   from st in st2.DefaultIfEmpty()
                                   select new StudentViewModel { studentVm = s, studentInfoVm = st };

            return View(studentViewModel);
            
        }
        public void insertDummyData()
        {

            students.Add(new Student { Id = 1, Name = "Monu", Stream = "Computer Science" });
            students.Add(new Student { Id = 2, Name = "Tony", Stream = "Life Sciences" });
            students.Add(new Student { Id = 3, Name = "Jhon", Stream = "Robotics" });
            students.Add(new Student { Id = 4, Name = "Jack", Stream = "Computer Science" });
            students.Add(new Student { Id = 5, Name = "Sonu", Stream = "Avaiation" });

            studentInfo.Add(new StudentInfo { Id = 100, StdId = 1, FatherName = "Mahesh", Address = "Noida" });
            studentInfo.Add(new StudentInfo { Id = 101, StdId = 2, FatherName = "Ramesh", Address = "Greater Noida" });
            studentInfo.Add(new StudentInfo { Id = 102, StdId = 3, FatherName = "Suresh", Address = "Merrut" });
            studentInfo.Add(new StudentInfo { Id = 103, StdId = 4, FatherName = "Ganesh", Address = "Delhi" });
            studentInfo.Add(new StudentInfo { Id = 109, StdId = 5, FatherName = "Hitesh", Address = "Haryana" });

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

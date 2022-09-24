using CourseRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CourseRegistration.Controllers
{
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

        public IActionResult Instructors()
        {
            InstructorViewModel ivm = new InstructorViewModel();

            List<DTO.Instructors> instructors = new List<DTO.Instructors>()
            {
                 new DTO.Instructors { InstructorId = 213, InstructorFirstName = "John", InstructorLastName = "Smith", InstructorEmail = "JSmith@KnightUniversity.com", CourseTaught = "Biology 101" },
                 new DTO.Instructors { InstructorId = 235, InstructorFirstName = "Rebecca", InstructorLastName = "Hanson", InstructorEmail = "RHanson@KnightUniversity.com", CourseTaught = "Psychology 200" },
                 new DTO.Instructors { InstructorId = 257, InstructorFirstName = "Stewart", InstructorLastName = "Johnson", InstructorEmail = "SJohnson@KnightUniversity.com", CourseTaught = "Accounting 318" },
                 new DTO.Instructors { InstructorId = 279, InstructorFirstName = "Eric", InstructorLastName = "Hallow", InstructorEmail = "EHallow@KnightUniversity.com", CourseTaught = "English 104" },
                 new DTO.Instructors { InstructorId = 290, InstructorFirstName = "Samantha", InstructorLastName = "Pearl", InstructorEmail = "SPearl@KnightUniversity.com", CourseTaught = "Finance 301" }
            };
            ivm.Instructors = instructors;
            return View(ivm);
        }


        public IActionResult Students()
        {
            StudentViewModel svm = new StudentViewModel();
            List<DTO.Students> stu = new List<DTO.Students>()
            {
                new DTO.Students{ StudentId = 170124, StudentFirstName = "Navi", StudentLastName = "Chana", StudentEmail = "ChanaN@KnightUniversity.com", StudentPhoneNumber = "587-985-2092"},
                new DTO.Students{ StudentId = 170124, StudentFirstName = "Shawn", StudentLastName = "Lautner", StudentEmail = "LautnerS@KnightUniversity.com", StudentPhoneNumber = "780-117-2035"},
                new DTO.Students{ StudentId = 170124, StudentFirstName = "Leonard", StudentLastName = "Potter", StudentEmail = "PotterL@KnightUniversity.com", StudentPhoneNumber = "587-162-8870"},
                new DTO.Students{ StudentId = 170124, StudentFirstName = "Bartholemew", StudentLastName = "Singh", StudentEmail = "SinghB@KnightUniversity.com", StudentPhoneNumber = "403-133-1904"},
                new DTO.Students{ StudentId = 170124, StudentFirstName = "Shania", StudentLastName = "Kaur", StudentEmail = "KaurS@KnightUniversity.com", StudentPhoneNumber = "403-187-5014"}
            };
            svm.Students = stu;
            return View(svm);
        }

        public IActionResult Courses()
        {
            CoursesViewModel cvm = new CoursesViewModel();
            List<DTO.Courses> courses = new List<DTO.Courses>()
            {
                new DTO.Courses{ CourseName = "Biology 101", CourseId = "BIO101", CourseNumber = 101, CourseDescription = "Introduction to Biology.", InstructorId = 213},
                new DTO.Courses{ CourseName = "Psychology 200", CourseId = "PSYCH200", CourseNumber = 200, CourseDescription = "Intermediate Psychology.", InstructorId = 235},
                new DTO.Courses{ CourseName = "Accounting 318", CourseId = "ACCT318", CourseNumber = 318, CourseDescription = "Managerial Accounting III.", InstructorId = 257},
                new DTO.Courses{ CourseName = "English 104", CourseId = "ENG104", CourseNumber = 104, CourseDescription = "Beginner level English Studies.", InstructorId = 279},
                new DTO.Courses{ CourseName = "Finance 301", CourseId = "ACCT301", CourseNumber = 301, CourseDescription = "Intermediate Financial Accounting.", InstructorId = 290}
            };
            cvm.Courses = courses;
            return View(cvm);
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
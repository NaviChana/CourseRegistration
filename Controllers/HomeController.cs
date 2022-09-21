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
            return View();
        }

        public IActionResult Courses()
        {
            return View();
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
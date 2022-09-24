using System.ComponentModel.DataAnnotations;

namespace CourseRegistration.DTO
{
    public partial class Courses
    {
        public string? CourseId { get; set; }
        public int CourseNumber { get; set; }
        public string? CourseName { get; set; }
        public string? CourseDescription { get; set; }

        public int InstructorId { get; set; }
    }
}

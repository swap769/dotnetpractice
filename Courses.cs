using System.ComponentModel.DataAnnotations;

namespace website.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        public string? CourseName { get; set; }

        [Required]
        public string? Coursetype { get; set; }
    }
}

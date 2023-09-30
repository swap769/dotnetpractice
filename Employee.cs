using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace website.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Email { get; set; }
        [Required]
        public int CourseId { get; set; }
        [Required]
        public Course? Course { get; set; }
        public Student? student{ get; set; }
    }
}

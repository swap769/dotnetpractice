using System.ComponentModel.DataAnnotations;

namespace website.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required]
        public string? DepartmentName { get; set; }
        [Required]
        public string? DepartmentCategory { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace website.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public string? PhoneNo { get; set; }

        [Required]
        public string? Address { get; set; }

        [Required]
        public string? Address { get; set; }

        public int DesignationId { get; set; }
        public Designation? Designation { get; set; }
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
    }
}

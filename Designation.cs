using System.ComponentModel.DataAnnotations;

namespace website.Models
{
    public class Designation
    {
        [Key]
        public int DesignationId { get; set; }

        [Required]
        public string? DesignationName { get; set; }
    }
}

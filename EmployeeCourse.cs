namespace website.Models
{
    public class EmployeeCourse
    {
        [key]
        public Employee EmployeeVm { get; set; }
        [Required]
        public Course CourseVm { get; set; }
    }      
    [Required]
        public Course CourseVm { get; set; }
     
}

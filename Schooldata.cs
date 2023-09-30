namespace website.Models
{
    public class Schooldata
    {
        public class Student
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            public string? Stream { get; set; }
        }

        public class StudentInfo
        {
            public int Id { get; set; }
            public int StdId { get; set; }
            public string? FatherName { get; set; }
            public string? Address { get; set; }
        }

        public class StudentViewModel {
         public Student? studentVm { get; set; }
         public StudentInfo? studentInfoVm { get; set; }
        }

    }
}

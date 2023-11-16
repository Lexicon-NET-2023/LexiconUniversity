using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace University.Core.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
        public ICollection<Student> Students { get; set; }
    }

    //public class Employee
    //{
    //    ICollection<Jobb> Jobb { get; set; }
    //}

    //public class Jobb
    //{
    //    ICollection<Employee> Employee { get; set; }
    //}
}

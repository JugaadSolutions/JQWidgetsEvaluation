using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFDemo.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseType { get; set; }
        public virtual ICollection<Student> Student { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFDemo.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int StudentProfileId { get; set; }
        public virtual StudentProfile StudentProfile { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public int BranchId { get; set; }
        public virtual Branch Branch { get; set; }
    }
}
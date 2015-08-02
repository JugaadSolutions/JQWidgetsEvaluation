using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFDemo.Models
{
    public class StudentProfile
    {
        public int StudentProfileId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Religion { get; set; }
        public string Caste { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}
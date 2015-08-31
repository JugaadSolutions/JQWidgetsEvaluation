using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EFDemo.Models
{
    public class StudentProfile
    {
        [Key, ForeignKey("Student")]
        public int StudentId { get; set; }
        public int StudentProfileId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Religion { get; set; }
        public string Caste { get; set; }
        
     
        public virtual Student Student { get; set; }
    }
}
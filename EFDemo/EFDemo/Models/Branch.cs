using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFDemo.Models
{
    public class Branch
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public virtual ICollection<Student> Student { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFDemo.Models
{
    public class EFDemoContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentProfile> StudentProfile { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public EFDemoContext()
            : base("name=EFDemoConnection")
    {
        this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }
    }
}
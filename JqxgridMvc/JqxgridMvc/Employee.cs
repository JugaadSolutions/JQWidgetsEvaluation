namespace JqxgridMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HumanResources.Employee")]
    public partial class Employee
    {
        public Employee()
        {
            Employee1 = new HashSet<Employee>();
        }

        public int EmployeeID { get; set; }

        [Required]
        [StringLength(15)]
        public string NationalIDNumber { get; set; }

        public int ContactID { get; set; }

        [Required]
        [StringLength(256)]
        public string LoginID { get; set; }

        public int? ManagerID { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public DateTime BirthDate { get; set; }

        [Required]
        [StringLength(1)]
        public string MaritalStatus { get; set; }

        [Required]
        [StringLength(1)]
        public string Gender { get; set; }

        public DateTime HireDate { get; set; }

        public bool SalariedFlag { get; set; }

        public short VacationHours { get; set; }

        public short SickLeaveHours { get; set; }

        public bool CurrentFlag { get; set; }

        public Guid rowguid { get; set; }

        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<Employee> Employee1 { get; set; }

        public virtual Employee Employee2 { get; set; }
    }
}

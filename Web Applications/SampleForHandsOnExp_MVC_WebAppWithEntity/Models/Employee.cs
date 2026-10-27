namespace SampleForHandsOnExp_MVC_WebAppWithEntity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeId { get; set; }

        [StringLength(100)]
        public string EmployeeName { get; set; }

        public int? Salary { get; set; }

        public int? DeptId { get; set; }

        public virtual Department Department { get; set; }
    }
}

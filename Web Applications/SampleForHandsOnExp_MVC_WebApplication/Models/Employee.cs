using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SampleForHandsOnExp_MVC_WebApplication.Models
{
    [Table("Employee")]
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int DeptId { get; set; }
        public string EmployeeName { get; set; }
        public int Salary { get; set; }

    }
}
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SampleForHandsOnExp_MVC_WebAppWithEntity.Models
{
    public partial class EmployeeDataModel : DbContext
    {
        public EmployeeDataModel()
            : base("name=EmployeeContext")
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

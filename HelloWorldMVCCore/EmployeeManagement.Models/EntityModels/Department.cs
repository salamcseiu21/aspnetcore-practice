using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Models.EntityModels
{
   public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public virtual List<Employee> Employees { get; set; }

    }
}

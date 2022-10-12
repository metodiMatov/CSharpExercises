namespace Organization.Departments
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Organization.Employees;

    internal class Department : Team
    {
        public Department(string departmentName, DepartmentManager manager)
        {
            this.DepartmentName = departmentName;
            this.Manager = manager;
        }

        public string? DepartmentName { get; set; }

        public DepartmentManager? Manager { get; set; }

    }
}

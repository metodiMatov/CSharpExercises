using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    internal class Department : Team
    {
        public Department(string departmentName, DepartmentManager manager)
        {
            DepartmentName = departmentName;
            Manager = manager;
        }

        public string? DepartmentName { get; set; }
        public DepartmentManager? Manager { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    internal class Team
    {
        public string Name { get; set; }
        protected Employee Teamlead { get; set; }
        public  List<Employee> TeamMembers { get; set; }
    }
}

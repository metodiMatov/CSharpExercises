using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    internal class Department : Team
    {
        //public Manager Manager { get; set; }

        protected List<Team> TeamList { get; set; }
    }
}

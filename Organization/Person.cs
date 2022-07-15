using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    abstract class Person
    {
        protected internal string? FirstName { get; set; }
        protected internal string? LastName { get; set; }
        protected internal int Age { get; set; }
        protected internal string? Country { get; set; }
        protected internal string? City { get; set; }
        protected internal string? Address { get; set; }
        protected internal int PersonalId { get; set; }
        protected internal string? Profession { get; set; }

        public abstract void PresentYourself();
    }
}

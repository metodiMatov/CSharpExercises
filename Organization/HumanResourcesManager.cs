using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Organization.Organization;

namespace Organization
{
    
    internal abstract class HumanResourcesManager : Employee, IManagement
    {
        public Dictionary<string, Approval> _employeeApprovals = new Dictionary<string, Approval>();
        public HumanResourcesManager(
            string firstName,
            string lastName, 
            int age, 
            string country, 
            string city, 
            string address, 
            int personalId, 
            string profession,
            List<EmploymentRecord> employmentRecords)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Country = country;
            City = city;
            Address = address;
            PersonalId = personalId;
            Profession = profession;
            EmploymentRecords = employmentRecords;
        }
        public Dictionary<string, Approval>? EmployeeApprovals { get; set; }

        public abstract Approval ApproveEmployee(Approval approval, Person person);

        public void HireEmployee(Dictionary<string, Approval> _employeeApprovals)
        {

        }
    }
}

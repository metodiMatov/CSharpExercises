using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    internal class Organization
    {
        public interface IManagement
        {
            public Approval ApproveEmployee(Person person);
        }

        public List<Employee>? _employees = new List<Employee>();
        public ChiefExecutive _chiefExecutive;
        public Department _developmentDepartment;
        public Department _humanResourcesDepartment;

        public Organization(string organizationName, string organizationDescription)
        {
            OrganizationName = organizationName;
            OrganizationDescription = organizationDescription;
        }

        public string OrganizationName { get; set; }
        public string OrganizationDescription { get; set; }
        public ChiefExecutive ChiefExecutive => _chiefExecutive;
        public Department DevelopmentDepartment => _developmentDepartment;
        public Department HumanResourcesDepartment => _humanResourcesDepartment;

        public void AddChiefExecutive()
        {
            var chiefExecutiveEmploymentRecords = new List<EmploymentRecord>();
            chiefExecutiveEmploymentRecords.Add(new EmploymentRecord(new DateTime(2000, 12, 11), new DateTime(2015, 12, 20), "Test", "Carpenter suupervisor"));
            _chiefExecutive = new ChiefExecutive("Toni", "Smith", 45, "USA", "washington DC", "Test", 12345678, "Carpenter", chiefExecutiveEmploymentRecords);
        }

        public void AddHumanResourcesDepartment()
        {
            var humanResourcesDepartmentManagerEmploymentRecords = new List<EmploymentRecord>();
            humanResourcesDepartmentManagerEmploymentRecords.Add(new EmploymentRecord(new DateTime(2005, 11, 20), new DateTime(2010, 02,27 ), "Test2", "Full Stack Developer"));
            humanResourcesDepartmentManagerEmploymentRecords.Add(new EmploymentRecord(new DateTime(2010, 03, 1), new DateTime(2012, 08,  30), "Test2", "Techlead Developer"));
            humanResourcesDepartmentManagerEmploymentRecords.Add(new EmploymentRecord(new DateTime(2015, 09, 1), new DateTime(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year), "Test3", "Development Department Manager"));

            _developmentDepartment = new Department("HumanResources Department", new DepartmentManager("Tess", "Smith", 30, "USA", "washington DC", "Test", 12345678, "Development Department Manager", humanResourcesDepartmentManagerEmploymentRecords));
        }

        public void AddDevelopmentDepartment() {
            var developmentDepartmentManagerEmploymentRecords = new List<EmploymentRecord>();
            developmentDepartmentManagerEmploymentRecords.Add(new EmploymentRecord(new DateTime(2005, 11,  20), new DateTime(2010, 02, 27), "Test2", "Full Stack Developer"));
            developmentDepartmentManagerEmploymentRecords.Add(new EmploymentRecord(new DateTime(2010, 03, 1), new DateTime(2012, 08, 30), "Test2", "Techlead Developer"));
            developmentDepartmentManagerEmploymentRecords.Add(new EmploymentRecord(new DateTime(2015, 09,  1), new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day), "Test3", "Development Department Manager"));
            _humanResourcesDepartment = new Department("Development Department", new DepartmentManager("Johnny", "Smith", 35, "USA", "washington DC", "Test", 12345678, "Development Department Manager", developmentDepartmentManagerEmploymentRecords));
        }

        public void IntroduceEmployees()
        {
            foreach (var employee in _employees)
            {
                employee.PresentYourself();
            }
        }
    }
}

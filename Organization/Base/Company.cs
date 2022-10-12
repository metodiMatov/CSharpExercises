using Organization.Departments;
using Organization.Employees;
using Organization.Utilities;

namespace Organization.Base
{
    internal class Company
    {
        private List<Employee>? employees = new List<Employee>();
        private ChiefExecutive chiefExecutive;
        private Department developmentDepartment;
        private Department humanResourcesDepartment;

        public Company(string organizationName, string organizationDescription)
        {
            this.OrganizationName = organizationName;
            this.OrganizationDescription = organizationDescription;
        }

        public string OrganizationName { get; set; }

        public string OrganizationDescription { get; set; }

        public ChiefExecutive ChiefExecutive
        {
            get
            {
                return this.chiefExecutive;
            }

            set
            {
                var chiefExecutiveEmploymentRecords = new List<EmploymentRecord>();
                chiefExecutiveEmploymentRecords.Add(new EmploymentRecord(new DateTime(2000, 12, 11), new DateTime(2015, 12, 20), "Test", "Carpenter suupervisor"));
                this.chiefExecutive = new ChiefExecutive("Toni", "Smith", 45, "USA", "washington DC", "Test", 12345678, "Carpenter", chiefExecutiveEmploymentRecords);
            }
        }

        public Department DevelopmentDepartment
        {
            get
            {
                return this.developmentDepartment;
            }

            set
            {
                var developmentDepartmentManagerEmploymentRecords = new List<EmploymentRecord>();
                developmentDepartmentManagerEmploymentRecords.Add(new EmploymentRecord(new DateTime(2005, 11, 20), new DateTime(2010, 02, 27), "Test2", "Full Stack Developer"));
                developmentDepartmentManagerEmploymentRecords.Add(new EmploymentRecord(new DateTime(2010, 03, 1), new DateTime(2012, 08, 30), "Test2", "Techlead Developer"));
                developmentDepartmentManagerEmploymentRecords.Add(new EmploymentRecord(new DateTime(2015, 09, 1), new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day), "Test3", "Development Department Manager"));
                this.developmentDepartment = new Department("Development Department", new DepartmentManager("Johnny", "Smith", 35, "USA", "washington DC", "Test", 12345678, "Development Department Manager", developmentDepartmentManagerEmploymentRecords));
            }
        }

        public Department HumanResourcesDepartment
        {
            get
            {
                return this.humanResourcesDepartment;
            }

            set
            {
                var humanResourcesDepartmentManagerEmploymentRecords = new List<EmploymentRecord>();
                humanResourcesDepartmentManagerEmploymentRecords.Add(new EmploymentRecord(new DateTime(2005, 11, 20), new DateTime(2010, 02, 27), "Test2", "Full Stack Developer"));
                humanResourcesDepartmentManagerEmploymentRecords.Add(new EmploymentRecord(new DateTime(2010, 03, 1), new DateTime(2012, 08, 30), "Test2", "Techlead Developer"));
                humanResourcesDepartmentManagerEmploymentRecords.Add(new EmploymentRecord(new DateTime(2015, 09, 1), new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day), "Test3", "Development Department Manager"));

                this.humanResourcesDepartment = new Department("HumanResources Department", new DepartmentManager("Tess", "Smith", 30, "USA", "washington DC", "Test", 12345678, "Development Department Manager", humanResourcesDepartmentManagerEmploymentRecords));
            }
        }

        public void IntroduceEmployees()
        {
            foreach (var employee in this.employees)
            {
                employee.PresentYourself();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    internal class OrganizationClass
    {
        public List<Employee>? _employees = new List<Employee>(); 
        public OrganizationClass(string organizationName, string organizationDescription, string OrganizationCEO)
        {

        }

        private string? OrganizationName { get; set; }
        private string? OrganizationDescription { get; set; }

        private string? OrganizationCEO { get; set; }

        //private List<Department>? Departments { get; set; }


        public List<Employee> CreateEmloyees()
        {
            bool isCreatingEmployee = true;
            

            while (isCreatingEmployee)
            {
                Console.WriteLine("Creating Employee: ");
                Console.WriteLine("");
                Console.WriteLine("First Name: ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Last Name: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Country: ");
                string country = Console.ReadLine();
                Console.WriteLine("City: ");
                string city = Console.ReadLine();
                Console.WriteLine("Address: ");
                string address = Console.ReadLine();
                Console.WriteLine("Id: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Profession: ");
                string profession = Console.ReadLine();
                Console.WriteLine("Salary: ");
                float salary = float.Parse(Console.ReadLine());
                Console.WriteLine("hourlyRate: ");
                float hourlyRate = float.Parse(Console.ReadLine());

                Console.WriteLine("Team: ");
                string team = Console.ReadLine();

                var employeeRecords = new List<EmploymentRecord>();
                var employeeRecordIndex = 0;

                while (true)
                {
                    if (employeeRecordIndex == 0)
                    {
                        Console.WriteLine("Create Employment record");
                    }
                    else
                    {
                        Console.WriteLine("Create more Employment records for this Employee?(y/n)");
                        string isCreatingMoreRecords = Console.ReadLine().ToLower();
                        if (isCreatingMoreRecords == "yes" || isCreatingMoreRecords == "y")
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }

                    }
                    Console.WriteLine("Job starting day: ");
                    int startDay = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Job starting month: ");
                    int startMonth = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Job starting year: ");
                    int startYear = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Job end starting day: ");
                    int endDay = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Job end starting month: ");
                    int endMonth = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Jobend starting year: ");
                    int endYear = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Company Name: ");
                    string companyName = Console.ReadLine();

                    Console.WriteLine("latest position: ");
                    string position = Console.ReadLine();
                    var employeeRecord = new EmploymentRecord(new DateTime(startDay, startMonth, startYear), new DateTime(endDay, endMonth, endYear), companyName, position);
                    employeeRecords.Add(employeeRecord);
                    employeeRecordIndex++;
                }

                _employees.Add(new Employee(firstName, lastName, age, country, city, address,id, profession, salary, hourlyRate, team, employeeRecords));

                Console.WriteLine("Add more employees?(y/n)");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            
            return _employees;

        }
        public void IntroduceEmployees()
        {
            foreach( var employee in _employees)
            {
                employee.PresentYourself();
            }
        }
    }
}

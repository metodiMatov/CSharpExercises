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

                _employees.Add(new Employee(firstName, lastName, age, country, city, address,id, profession, salary, hourlyRate, team));
                Console.WriteLine("Add more employees?");
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

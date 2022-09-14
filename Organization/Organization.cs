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
            public Approval ApproveEmployee( Person person)
            {
                Console.Write("Enter a month: ");
                int month = int.Parse(Console.ReadLine());
                Console.Write("Enter a day: ");
                int day = int.Parse(Console.ReadLine());
                Console.Write("Enter a year: ");
                int year = int.Parse(Console.ReadLine());

                bool isApproved;
                string isApprovedStr;
                do
                {
                    Console.Write("Do you approve the Person(y/n): ");
                    isApprovedStr = Console.ReadLine();
                } while (isApprovedStr == "y" || isApprovedStr == "n");

                if (isApprovedStr == "y")
                {
                    isApproved = true;
                }
                else
                {
                    isApproved = false;
                }

                Console.Write("Add your notes: ");
                string note = Console.ReadLine();

                return new Approval(new DateTime(year, month, day), person.PersonalId, isApproved, note);
            }
        }

        public List<Employee>? _employees = new List<Employee>();

        public Organization(string organizationName, string organizationDescription, ChiefExecutive organizationChiefExecutive, Department developmentDepartment,Department humanResourcesDepartment)
        {
            OrganizationName = organizationName;
            OrganizationDescription = organizationDescription;
            OrganizationChiefExecutive = organizationChiefExecutive;
            DevelopmentDepartment = developmentDepartment;
            HumanResourcesDepartment = humanResourcesDepartment;
        }

        public string OrganizationName { get; set; }
        public string OrganizationDescription { get; set; }

        public ChiefExecutive OrganizationChiefExecutive { get; set; }

        public Department DevelopmentDepartment { get; set; }

        public Department HumanResourcesDepartment { get; set; }


       
        public void IntroduceEmployees()
        {
            foreach( var employee in _employees)
            {
                employee.PresentYourself();
            }
        }
    }
}

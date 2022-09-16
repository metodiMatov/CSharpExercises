using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Organization.Organization;

namespace Organization
{
    public class ChiefExecutive : Person, IManagement
    {
        public ChiefExecutive(string firstName, string lastName, int age, string country, string city, string address, int personalId, string profession, List<EmploymentRecord> employmentRecords) : base(firstName, lastName, age, country, city, address, personalId, profession, employmentRecords)
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
        public Approval ApproveEmployee(Person person)
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
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    internal class Employee : Person
    {
        public Employee(string firstName, string lastName, int age, string country, string city, string address, int personalId, string profession, float salary, float hourlyRate, string teamName)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Country = country;
            City = city;
            Address = address;
            PersonalId = personalId;
            Profession = profession;
            Salary = salary;
            HourlyRate = hourlyRate;
            TeamName = teamName;
        }
        protected internal float? Salary { get; set; }
        protected internal float? HourlyRate { get; set; }
        protected internal string? TeamName { get; set; }

        public override void PresentYourself()
        {
            Console.WriteLine("Hello, my name is {0}. I am from {1}. I live in {2}. My profession is {3}", FirstName, Country, City, Profession);
        }
    }
}

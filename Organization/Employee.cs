using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    internal class Employee : Person
    {
        public Employee(string firstName, string lastName, int age, string country, string city, string address, int personalId, string profession, List<EmploymentRecord> employmentRecords):base ( firstName,  lastName,  age,  country,  city,  address,  personalId,  profession, employmentRecords)   
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
    }
}

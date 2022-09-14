using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    
    public record EmploymentRecord
    {
        public EmploymentRecord(DateTime startDate, DateTime endDate, string? companyName, string? position)
        {
            StartDate = startDate;
            EndDate = endDate;
            CompanyName = companyName;
            Position = position;
        }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? CompanyName { get; set; }
        public string? Position { get; set; }
    }


    public class Person
    {
        public Person(string firstName, string lastName, int age, string country, string city, string address, int personalId, string profession, List<EmploymentRecord> employmentRecords)
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

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Address { get; set; }
        public int PersonalId { get; set; }
        public string? Profession { get; set; }
        public List<EmploymentRecord>? EmploymentRecords { get; set; }
        public void PresentYourself()
        {
            Console.WriteLine("Hello, my name is {0}. I am from {1}. I live in {2}. My profession is {3}", FirstName, Country, City, Profession);
        }

        public Dictionary<string, double>? GetTotalWorkExperience()
        {
            if (EmploymentRecords == null || EmploymentRecords.Count == 0)
            {
                Console.WriteLine("The Employee doesn't have work experience!");
                return null;
            }

            double totalExperiance = 0;
            
            foreach (var employmentRecord in EmploymentRecords)
            {
                TimeSpan interval = employmentRecord.StartDate - employmentRecord.EndDate;
                totalExperiance += interval.TotalMilliseconds;
            }

            var years = Math.Floor(totalExperiance / 12);
            var months = Math.Floor((totalExperiance / 12 - Math.Floor(totalExperiance / 12)) * 12);
            
            var personTotalExperience = new Dictionary<string, double>();
            personTotalExperience.Add("years", years);
            personTotalExperience.Add("months", months);

            return personTotalExperience;
        }
    }
}

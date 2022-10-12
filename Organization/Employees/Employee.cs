using Organization.Base;
using Organization.Utilities;

namespace Organization.Employees
{
    public class Employee : Person
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="age"></param>
        /// <param name="country"></param>
        /// <param name="city"></param>
        /// <param name="address"></param>
        /// <param name="personalId"></param>
        /// <param name="profession"></param>
        /// <param name="employmentRecords"></param>
        public Employee(string firstName, string lastName, int age, string country, string city, string address, int personalId, string profession, List<EmploymentRecord> employmentRecords)
            : base(firstName, lastName, age, country, city, address, personalId, profession, employmentRecords)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Country = country;
            this.City = city;
            this.Address = address;
            this.PersonalId = personalId;
            this.Profession = profession;
            this.EmploymentRecords = employmentRecords;
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
            Console.WriteLine("Hello, my name is {0}. I am from {1}. I live in {2}. My profession is {3}", this.FirstName, this.Country, this.City, this.Profession);
        }
    }
}

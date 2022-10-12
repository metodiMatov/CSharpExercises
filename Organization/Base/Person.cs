using Organization.Utilities;

namespace Organization.Base
{ 
    public class Person
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
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
        public Person(string firstName, string lastName, int age, string country, string city, string address, int personalId, string profession, List<EmploymentRecord> employmentRecords)
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

        public Dictionary<string, double>? GetTotalWorkExperience()
        {
            if (this.EmploymentRecords == null || this.EmploymentRecords.Count == 0)
            {
                Console.WriteLine("The Employee doesn't have work experience!");
                return null;
            }

            double totalExperiance = 0;

            foreach (var employmentRecord in this.EmploymentRecords)
            {
                TimeSpan interval = employmentRecord.StartDate - employmentRecord.EndDate;
                totalExperiance += interval.TotalMilliseconds;
            }

            var years = Math.Floor(totalExperiance / 12);
            var months = Math.Floor(((totalExperiance / 12) - Math.Floor(totalExperiance / 12)) * 12);

            var personTotalExperience = new Dictionary<string, double>();
            personTotalExperience.Add("years", years);
            personTotalExperience.Add("months", months);

            return personTotalExperience;
        }
    }
}

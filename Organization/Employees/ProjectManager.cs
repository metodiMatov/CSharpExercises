namespace Organization.Employees
{
    using Organization.Utilities;

    internal class ProjectManager : Employee
    {
        public ProjectManager(
            string firstName,
            string lastName,
            int age,
            string country,
            string city,
            string address,
            int personalId,
            string profession,
            List<EmploymentRecord> employmentRecords) : base(firstName, lastName, age, country, city, address, personalId, profession, employmentRecords)
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
        public virtual void PresentYourself()
        {
            Console.WriteLine("Hello, my name is {0}. I am from {1}. I live in {2}. My profession is {3}", FirstName, Country, City, Profession);
        }
    }
}

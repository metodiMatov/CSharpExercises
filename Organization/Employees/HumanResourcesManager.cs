namespace Organization.Employees
{
    using Organization.Base;
    using Organization.Interfaces;
    using Organization.Utilities;

    public class HumanResourcesManager : Employee, IManagement
    {
        public Dictionary<string, Approval> employeeApprovals = new Dictionary<string, Approval>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HumanResourcesManager"/> class.
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
        public HumanResourcesManager(
            string firstName,
            string lastName,
            int age,
            string country,
            string city,
            string address,
            int personalId,
            string profession,
            List<EmploymentRecord> employmentRecords)
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

        public Dictionary<string, Approval>? EmployeeApprovals { get; set; }

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

        public void HireEmployee(Dictionary<string, Approval> employeeApprovals)
        {

        }
    }
}

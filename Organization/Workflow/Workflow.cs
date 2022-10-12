using Organization.Base;
using Organization.Utilities;

namespace Organization.Workflow;

public class Workflow
{
    public List<Person>? people = new List<Person>();

    public void SetWorkflow()
    {
        Workflow workflow = this;
        var people = workflow.CreatePeople(this);

        var organization = new Company("Webspector", "QA company that ensure your Web project is in tune");

        foreach (var person in people)
        {
            var chiefExecutive = organization.ChiefExecutive;
            var devManager = organization.DevelopmentDepartment.Manager;
            var hrManager = organization.HumanResourcesDepartment.Manager;

            hrManager.ApproveEmployee(person);
        }
    }

    public List<Person> CreatePeople(Workflow wrokFlow)
    {
        bool isCreatingPeople = true;


        while (isCreatingPeople)
        {

            var person = wrokFlow.AddPerson();
            people.Add(person);

            Console.Write("Add more employees?(y/n)");
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

        return people;
    }

    public Person AddPerson()
    {
        Console.WriteLine("Creating Employee: ");
        Console.WriteLine("");
        Console.Write("First Name: ");
        string firstName = Console.ReadLine();
        Console.Write("Last Name: ");
        string lastName = Console.ReadLine();
        Console.Write("Age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Country: ");
        string country = Console.ReadLine();
        Console.Write("City: ");
        string city = Console.ReadLine();
        Console.Write("Address: ");
        string address = Console.ReadLine();
        Console.Write("Id: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Profession: ");
        string profession = Console.ReadLine();

        var personEmploymentRecords = new List<EmploymentRecord>();
        var personRecordIndex = 0;

        while (true)
        {
            Console.WriteLine("Create Employment record");

            Console.Write("Job starting day: ");
            int startDay = Convert.ToInt32(Console.ReadLine());
            Console.Write("Job starting month: ");
            int startMonth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Job starting year: ");
            int startYear = Convert.ToInt32(Console.ReadLine());

            Console.Write("Job end day: ");
            int endDay = Convert.ToInt32(Console.ReadLine());
            Console.Write("Job end month: ");
            int endMonth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Job end year: ");
            int endYear = Convert.ToInt32(Console.ReadLine());

            Console.Write("Company Name: ");
            string companyName = Console.ReadLine();

            Console.Write("Latest position: ");
            string position = Console.ReadLine();
            var personEmploymentRecord = new EmploymentRecord(new DateTime(startYear, startMonth, startDay), new DateTime(endYear, endMonth, endDay), companyName, position);
            personEmploymentRecords.Add(personEmploymentRecord);

            personRecordIndex++;

            Console.WriteLine("Create more Employment records for this Employee?(y/n)");
            string isCreatingMoreRecords = Console.ReadLine().ToLower();
            if (isCreatingMoreRecords == "yes" || isCreatingMoreRecords == "y")
            {
                continue;
            }
            else
            {
                break;
            }
        }
        return new Person(firstName, lastName, age, country, city, address, id, profession, personEmploymentRecords);
    }
}

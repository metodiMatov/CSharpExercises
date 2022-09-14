using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organization;
namespace Organization;

public class Workflow
{
    public List<Person>? _people = new List<Person>();
    public void SetWorkflow()
    {
        Workflow workflow = this;
        workflow.CreatePersons();

        var chiefExecutiveEmploymentRecords = new List<EmploymentRecord>();
        chiefExecutiveEmploymentRecords.Add(new EmploymentRecord(new DateTime(11, 12, 2000), new DateTime(20, 12, 2015), "Test", "Carpenter suupervisor"));
        var chiefExecutive = new ChiefExecutive("Toni","Smith", 45, "USA", "washington DC", "Test", 12345678, "Carpenter", chiefExecutiveEmploymentRecords);
        
        var developmentResourcesDepartment = new Department("Development Department", new DepartmentManager(""));
        var humanResourcesDepartment = new Department("HumanResourcesDepartment", new DepartmentManager());
        var organization = new Organization("Webspector", "QA company that ensure your Web project is in tune", chiefExecutive, developmentResourcesDepartment, humanResourcesDepartment);
    }
    public List<Person> CreatePersons()
    {
        bool isCreatingPeople = true;


        while (isCreatingPeople)
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
                if (personRecordIndex == 0)
                {
                    Console.WriteLine("Create Employment record");
                }
                else
                {
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
                Console.Write("Job starting day: ");
                int startDay = Convert.ToInt32(Console.ReadLine());
                Console.Write("Job starting month: ");
                int startMonth = Convert.ToInt32(Console.ReadLine());
                Console.Write("Job starting year: ");
                int startYear = Convert.ToInt32(Console.ReadLine());

                Console.Write("Job end starting day: ");
                int endDay = Convert.ToInt32(Console.ReadLine());
                Console.Write("Job end starting month: ");
                int endMonth = Convert.ToInt32(Console.ReadLine());
                Console.Write("Jobend starting year: ");
                int endYear = Convert.ToInt32(Console.ReadLine());

                Console.Write("Company Name: ");
                string companyName = Console.ReadLine();

                Console.Write("latest position: ");
                string position = Console.ReadLine();
                var personEmploymentRecord = new EmploymentRecord(new DateTime(startDay, startMonth, startYear), new DateTime(endDay, endMonth, endYear), companyName, position);
                personEmploymentRecords.Add(personEmploymentRecord);
                personRecordIndex++;
            }

            _people.Add(new Person(firstName, lastName, age, country, city, address, id, profession, personEmploymentRecords));

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

        return _people;
    }
}

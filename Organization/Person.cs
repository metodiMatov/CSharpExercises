using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    
    public record EmploymentRecord
    {
        private DateTime dateTime1;
        private DateTime dateTime2;

        public EmploymentRecord(DateTime dateTime1, DateTime dateTime2, string? companyName, string? position)
        {
            this.dateTime1 = dateTime1;
            this.dateTime2 = dateTime2;
            CompanyName = companyName;
            Position = position;
        }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? CompanyName { get; set; }
        public string? Position { get; set; }
    }

    abstract class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Address { get; set; }
        public int PersonalId { get; set; }
        public string? Profession { get; set; }
        public List<EmploymentRecord>? EmploymentRecords { get; set; }
        public abstract void PresentYourself();
        public void GetTotalWorkExperience()
        {
            if (EmploymentRecords == null || EmploymentRecords.Count == 0)
            {
                Console.WriteLine("The Employee doesn't have work experience!");
                return;
            }

            double totalExperiance = 0;
            foreach (var employmentRecord in EmploymentRecords)
            {
                TimeSpan interval = employmentRecord.StartDate - employmentRecord.EndDate;
                totalExperiance += interval.TotalMilliseconds;
            }
            var years = Math.Floor(totalExperiance / 12);
            var months = Math.Floor((totalExperiance / 12 - Math.Floor(totalExperiance / 12)) * 12);
            Console.WriteLine("The Employee total experience is {0} years and {1}", years, months);
        }
    }
}

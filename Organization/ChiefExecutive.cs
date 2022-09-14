﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Organization.Organization;

namespace Organization
{
    public class ChiefExecutive : Person, IManagement
    {
        public ChiefExecutive(string firstName, string lastName, int age, string country, string city, string address, int personalId, string profession, List<EmploymentRecord> employmentRecords) : base(firstName, lastName, age, country, city, address, personalId, profession, employmentRecords)
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

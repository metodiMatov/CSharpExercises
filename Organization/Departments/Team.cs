namespace Organization.Departments
{
    using Organization.Employees;

    internal class Team
    {
        public string Name { get; set; }

        protected Employee Teamlead { get; set; }

        public List<Employee> TeamMembers { get; set; }
    }
}

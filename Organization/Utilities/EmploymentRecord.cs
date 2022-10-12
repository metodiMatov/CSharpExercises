namespace Organization.Utilities
{
    public class EmploymentRecord
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmploymentRecord"/> class.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="companyName"></param>
        /// <param name="position"></param>
        public EmploymentRecord(DateTime startDate, DateTime endDate, string? companyName, string? position)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.CompanyName = companyName;
            this.Position = position;
        }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string? CompanyName { get; set; }

        public string? Position { get; set; }
    }
}

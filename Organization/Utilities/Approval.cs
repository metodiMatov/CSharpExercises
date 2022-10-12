namespace Organization.Utilities
{
    public class Approval
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Approval"/> class.
        /// </summary>
        /// <param name="approvaleDate"></param>
        /// <param name="emploeeId"></param>
        /// <param name="isApproved"></param>
        /// <param name="note"></param>
        public Approval(DateTime approvaleDate, int emploeeId, bool isApproved, string note)
        {
            this.ApprovaleDate = approvaleDate;
            this.EmploeeId = emploeeId;
            this.IsApproved = isApproved;
            this.Note = note;
        }
        public DateTime ApprovaleDate { get; set; }

        public int? EmploeeId { get; set; }

        public bool IsApproved { get; set; }

        public string? Note { get; set; }
    }
}

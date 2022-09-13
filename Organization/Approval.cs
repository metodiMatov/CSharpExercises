using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    public class Approval
    {
        public Approval(DateTime approvaleDate, int emploeeId, bool isApproved, string note)
        {
            ApprovaleDate = approvaleDate;
            EmploeeId = emploeeId;
            IsApproved = isApproved;
            Note = note;
        }
        public DateTime ApprovaleDate { get; set; }
        public int? EmploeeId { get; set; }
        public bool IsApproved { get; set; }
        public string? Note { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    public class Approval
    {
        public DateTime ApprovaleDate { get; set; }
        public string? EmploeeId { get; set; }
        public bool IsApproved { get; set; }
        public string? Note { get; set; }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeonOps.models
{
    internal class Assignment
    {
        public int ID { get; set; }
        public int OperatorID { get; set; }
        public string SampleRequestNo { get; set; }
        public DateTime? PlannedStartDate { get; set; }
        public DateTime? PlannedFinishDate { get; set; }
        public int? ReassignedFromOperatorID { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeonOps.models
{
    public class Style
    {
        public string SampleRequestNo { get; set; }
        public string Customer { get; set; }
        public string SampleFitType { get; set; }
        public string StyleNo { get; set; }
        public int Quantity { get; set; }
        public int? Priority { get; set; }
        public string CurrentStage { get; set; }
        public int StatusID { get; set; }
        public string Status { get; set; }
        public string FinalStatus { get; set; }
        public DateTime? StatusUpdateDateTime { get; set; }
        public int TotalCountofOperations { get; set; }
        public DateTime PlannedStartDateTime { get; set; }
        public DateTime? ActualStartDateTime { get; set; }
        public DateTime PlannedFinishDateTime { get; set; }
        public DateTime? ActualFinishDateTime { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public int OperatorID { get; set; }
        public DateTime StatusUpdateTrackingDateTime { get; set; } = DateTime.Now;
        public string OperatorEPFName { get; set; }
        public string OperatorStatus { get; set; }
    }
}

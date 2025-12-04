using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeonOps.models
{
    internal class Tracking
    {
        public int ID { get; set; }
        public int OperatorID { get; set; }
        public string SRNumber { get; set; }
        public string SampleRequestNo { get; set; }
        public string StyleStatus { get; set; }
        public int StatusID { get; set; }
        public string Sequence { get; set; }
        public int? CountofOperations { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}

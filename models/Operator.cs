using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeonOps.data;

namespace EyeonOps.models
{
    public class Operator
    {
        public int ID { get; set; }
        public string OperatorEPFName { get; set; }
        public string EPF { get; set; }
        public string Name { get; set; }
        public string SampleRoom { get; set; }
        public string Grade { get; set; }
        public string Sequence { get; set; }
        public DateTime JoinDate { get; set; }
        public int StatusID { get; set; }
        public string Status => new StatusAccess().GetOperatorStatusByID(StatusID);
        public DateTime? StatusUpdateDateTime { get; set; } = null;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

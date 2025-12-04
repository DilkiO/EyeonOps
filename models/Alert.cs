using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeonOps.models
{
    public class Alert
    {
        public int AlertID { get; set; }
        public string Type { get; set; }
        public string Message { get; set; }
        public string EntityType { get; set; }
        public string Status { get; set; }
        public int OwnerUserID { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeonOps.models
{
    public class Dashboard
    {
        public int Total { get; set; }
        public int Idle { get; set; }
        public int Active { get; set; }
        public int Waiting { get; set; }
    }
}

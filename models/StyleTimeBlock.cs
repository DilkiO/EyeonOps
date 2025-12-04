using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeonOps.models
{
    public class StyleTimeBlock
    {
        public string Label { get; set; }
        public DateTime PlannedStartTime { get; set; }
        public DateTime PlannedEndTime { get; set; }
        public Color Color { get; set;}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeonOps.models
{
    internal class WipTracker
    {
        public int ID { get; set; }
        public string OperatorEPFName {  get; set; }

        public List<Style> Styles { get; set; } = new List<Style>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeonOps.models
{
    public class Row
    {
        public string Label { get; set; }
        public List<StyleTimeBlock>StyleTimeBlocks { get; set; }=new List<StyleTimeBlock>();
    }
}

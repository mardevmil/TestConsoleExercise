using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.FactoryPattern
{
    class SegmentedBlock : IBlock
    {
        public string GetName()
        {
            return "Segmented";
        }
    }
}

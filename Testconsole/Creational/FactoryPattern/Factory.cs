using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.FactoryPattern
{
    class Factory
    {
        public enum Type
        {
            Basic,
            Segmented
        }

        public IBlock CreateBlock(Type type)
        {
            switch (type)
            {
                case Type.Basic: return new BasicBlock();
                    break;
                case Type.Segmented: return new SegmentedBlock();
                    break;
                    default: throw new NotSupportedException();
            }            
        }
    }
}

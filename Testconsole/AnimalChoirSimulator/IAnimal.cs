using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testconsole.AnimalChoirSimulator
{
    public enum Loudness
    {
        LOW,
        MEDIUM,
        HIGH
    }

    interface IAnimal
    {
        Loudness Loudness { get; set; }
        void Sing();
    }    
}

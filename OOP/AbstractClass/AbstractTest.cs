using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.AbstractClass
{
    abstract class Person
    {
        private int _height = 198;
        protected int Result = 11;
        public int Age { get; set; } = 21;
        public abstract void PrintName();

        public virtual void PrintHeight()
        {
            Console.WriteLine($"Student height is {_height}");
        }

        public void CalculateSomething()
        {
            Console.WriteLine($"Result is {Result}");
        }
    }

    class Student : Person
    {
        public string Name { get; set; }
        public override void PrintName()
        {
            Console.WriteLine($"Student name is {Name} and is {Age}");
        }

        // this is possible, but abstract class doesn't 
        // force dervied class to override this method        
        //public override void PrintHeight() 
        //{                                  
        //    Console.WriteLine("Student height is nn");
        //}
    }
}

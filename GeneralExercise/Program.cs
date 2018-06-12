using System;
using Testconsole.CalculationExercise;

namespace GeneralExercise
{
    class Program
    {
        static void Main(string[] args)
        {
           Calculation calculation = new Calculation();
           calculation.CalculateFactorial(10);
           ConsoleKeyInfo keyinfo = Console.ReadKey();
        }
    }
}

using System;
using System.Text;
using Testconsole.CalculationExercise;

namespace GeneralExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation = new Calculation();                        
            ConsoleKeyInfo keyinfo;
            int n = 0;
            Console.WriteLine("Please press some number!");
            StringBuilder sb = new StringBuilder();
            do
            {
                keyinfo = Console.ReadKey(true);

                if (keyinfo.Key != ConsoleKey.Enter)
                {
                    if (Char.IsNumber(keyinfo.KeyChar))
                    {
                        Console.Write(keyinfo.KeyChar);
                        sb.Append(keyinfo.KeyChar);
                    }                                    
                }                                  
                else
                {
                    n = int.Parse(sb.ToString());
                    Console.WriteLine("\nkeyChar: " + sb + " n: " + n + "\n");
                    if (n > 0)
                    {
                        calculation.CalculateFactorial(n);
                    }
                    sb.Clear();
                    Console.WriteLine("\n\n");
                }                

            }
            while (keyinfo.Key != ConsoleKey.Spacebar);

        }
    }
}

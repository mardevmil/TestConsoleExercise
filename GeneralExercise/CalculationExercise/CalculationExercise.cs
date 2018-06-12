using System;

namespace Testconsole.CalculationExercise
{
    class Calculation
    {
        int[] array1 = new int[] { 1, 3, 5, 7, 9 };
        string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };


        public int CalculateFactorial(int n)
        {
            if (n == 1)
                return 1;


            int res = n * CalculateFactorial(n-1);

            Console.WriteLine("{0} : {1}", n, res);
            return res;
        }

        public void Arrays1()
        {
            int offset = 4;
            string[] copiedDays = new string[weekDays.Length + offset];
            //copiedDays = weekDays.ToList<string>().Where(element => element.Contains("T")).ToArray<string>();
            weekDays.CopyTo(copiedDays,offset);
            for (int i = 0; i < copiedDays.Length; i++)
            {
                Console.WriteLine("\nelement: " + copiedDays[i]);
            }
            //copiedDays.ToList<string>().ForEach(x => Console.WriteLine("\nelement: " + x));            
        }
    }
}

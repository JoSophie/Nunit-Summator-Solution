using System;

namespace Summator
{
    class Program
    {
        static void Main(string[] args)
        {
            long result = Summator.Sum(new int[] { 1, 2, 3, 4, 5, 6, });
            if (result == 21)
            {
                Console.WriteLine("TEST PASS");
            } else
            {
                Console.WriteLine("TEST FAIL");
            }
 
        
            long avrg = Summator.Average(new int[] { 5, 10, 15 });
            if (avrg == 10)
            {
                Console.WriteLine("TEST PASS");
            }   else
            {
                Console.WriteLine("TEST FAIL");
            }
        }
    }
}

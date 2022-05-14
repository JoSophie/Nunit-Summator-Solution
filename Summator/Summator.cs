using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summator
{
    public static class Summator
    {
        public static long Sum(int[] arr)
        {
                long sum = 0;   //arr[0];

                for (long i = 0; i < arr.Length; i++)   //instead of  int i = 1;
                {
                    sum += arr[i];
                }

                return sum;
        }
        public static int Average(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)  
            {
                sum += arr[i] ;
            }

            return sum/arr.Length;
        }
    }
}

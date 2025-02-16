using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.main.arrays_operations
{
    public class FindMissingNumbers
    {
        public static void FindMissingNumberMethod(int[] arr) {
           int  n = arr.Length + 1;
            int total = n * (n + 1) / 2;
            foreach (int num in arr) { 
                total -= num;
            }
            Console.WriteLine("The missing number is: " + total);
        }
    }
}

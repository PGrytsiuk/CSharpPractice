using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.main.simple_apps
{
    public class FindMaxNumberInArray
    {
        public static void FindMaxNumberInArrayMethod(int[] arr)
        {
            var maxNumber = 0;
            var minNumber = 0;
            foreach (var item in arr)
            {
                if (item > maxNumber)
                {
                    maxNumber = item;
                }
                else if (item < minNumber)
                {
                    minNumber = item;
                }
                    
            }

            Console.WriteLine("Max number in the array: " + maxNumber);
            Console.WriteLine("Min number in the array: " + minNumber);
        }
    }
}

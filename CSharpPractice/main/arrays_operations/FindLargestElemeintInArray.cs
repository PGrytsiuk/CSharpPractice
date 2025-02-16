using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.main.arrays_operations
{
    public class FindLargestElemeintInArray
    {
        public static void FindLargestElementMethod(int[] arr)
        {
            int largestElemet = arr[0];
            foreach (int num in arr)
            {
                if (num > largestElemet)
                {
                    largestElemet = num;
                }
            }
            Console.WriteLine("Largest element in the array is: " + largestElemet);
        }
    }
}

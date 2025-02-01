using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.main.arrays_operations
{
    internal class CountDuplicates
    {
        public void CountDuplicatesMethod(int[] arr)
        {
            Dictionary<int, int> elementCount = new Dictionary<int, int>();

            foreach (int num in arr)
            { 
                elementCount[num] = elementCount.ContainsKey(num) ? elementCount[num] + 1 : 1;
            }

            Console.WriteLine("Duplicate elements and their count:");
            foreach (int key in elementCount.Keys)
            {
                int count = elementCount.ContainsKey(key)
                    ? elementCount[key]
                    : 0;
                if (count > 1)
                {
                    Console.WriteLine(key + " - " + count);
                }
            }
        }
    }
}

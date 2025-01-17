using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.main.arrays_operations
{
    internal class ArraySort
    {
        public void arraySort(int[] arr)
        { 
            Array.Sort(arr);
            Console.WriteLine("Array elements after sorting:" + string.Join(", ",arr));
        }
    }
}

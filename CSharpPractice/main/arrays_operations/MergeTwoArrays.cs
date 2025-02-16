using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.main.arrays_operations
{
    internal class MergeTwoArrays
    {
        public static void MergeTwoArraysMethod(int[] arr, int[] arr2)
        {
            int[] mergedArray = new int[arr.Length + arr2.Length];
            arr.CopyTo(mergedArray, 0);
            arr2.CopyTo(mergedArray, arr.Length);
            Console.WriteLine("Merged array: " + string.Join(", ", mergedArray));
        }
    }
}

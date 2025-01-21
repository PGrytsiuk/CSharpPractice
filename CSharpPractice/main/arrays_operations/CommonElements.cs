using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.main.arrays_operations
{
    internal class CommonElements
    {
        public void CommonElementsMethod(int[] arr1, int[] arr2)
        {
            HashSet<int> commonElements = new HashSet<int>();
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        commonElements.Add(arr1[i]);
                    }
                }
            }
            Console.WriteLine("Common elements are: " + string.Join(", ", commonElements));
        }

        public void CommonElementsMethod2(int[] arr1, int[] arr2)
        { 
            HashSet<int> hashSet = new HashSet<int>();
            foreach (int num in arr1)
            { 
                hashSet.Add(num);
            }
            foreach (int num in arr2)
            { 
                if (hashSet.Contains(num))
                {
                    Console.WriteLine("Common elements are: " + num);
                }
            }
        }

        public void CommonElementsMethod3(int[] arr1, int[] arr2)
        {
            HashSet<int> hashSet = new HashSet<int>();
            var commonElements = arr1.Intersect(arr2);
            Console.WriteLine("Intersection (common elements): " + string.Join(", ", commonElements));
        }
    }
}

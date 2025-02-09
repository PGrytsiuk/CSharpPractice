using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.main.arrays_operations
{
    internal class FindDuplicatesIntegers
    {
        public static HashSet<int> FindDuplicates(int[] arr)
        { 
            HashSet<int> seen = new HashSet<int>();
            HashSet<int> duplicates = new HashSet<int>();

            foreach (int num in arr)
            {
                if (seen.Contains(num))
                { 
                    duplicates.Add(num);
                }
                else
                {
                    seen.Add(num);
                }
            }
            return duplicates;
        }
    }
}

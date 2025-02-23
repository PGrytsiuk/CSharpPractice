using System.Net.NetworkInformation;

namespace CSharpPractice.main.arrays_operations
{
    public class RemoveDuplicatesInArray
    {
        public void RemoveDuplicatesInArrayMethod(int[] arr)
        {
            HashSet<int> hashSet = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            { 
                hashSet.Add(arr[i]);
            }
            Console.WriteLine("Array after removing duplicates: " + string.Join(", ", hashSet));
        }

        public void RemoveDuplicatesWithStreams(int[] arr)
        {
            int[] uniqueArray = arr.Distinct().ToArray();
            Console.WriteLine("Array after removing duplicates: " + string.Join(", ", uniqueArray));
        }
    }
}

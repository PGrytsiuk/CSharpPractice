namespace CSharpPractice.main.arrays_operations
{
    public class SelectionSort
    {
        public static void SelectionSortMethod(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            { 
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
            Console.WriteLine("Sorted array:");
            foreach (int num in arr)
            { 
                Console.Write(num + " ");
            }
        }
    }
}

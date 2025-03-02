namespace CSharpPractice.main.arrays_operations
{
    public class FindSecondLargestArray
    {
        public static int FindSecondLargestElementInArrayMethod(int[] arr)
        {
            int first = int.MinValue;
            int second = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > first)
                {
                    second = first;
                    first = arr[i];
                }
                else if (arr[i] > second && arr[i] != first)
                {
                    second = arr[i];
                }
            }
            return second;
        }
    }
}

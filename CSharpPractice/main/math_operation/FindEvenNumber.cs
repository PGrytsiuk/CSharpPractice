namespace CSharpPractice.main.math_operation
{
    public class FindEvenNumber
    {
        public static void FindEvenNumberMethod(int[] numbers)
        {
            var isEven = numbers.Where(num => num % 2 == 0).ToList();
            Console.WriteLine("Even numbers are: " + String.Join(", ", isEven));
        }
    }
}

using System;

namespace CSharpPractice.main.simple_apps
{
    public class SumOfPreviouslyCalulatedNumbers
    {
        public static void SumOfPreviouslyCalulatedNumbersMethod()
        {
            int sum = 0;
            Console.WriteLine("Enter numbers to sum. Type 'OK' to finish.");

            while (true)
            {
                var inputString = Console.ReadLine();
                if (inputString.Equals("OK", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("OK");
                    Console.WriteLine("Sum of previously entered numbers is " + sum);
                    break;
                }

                if (int.TryParse(inputString, out int number))
                {
                    sum += number;
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a valid integer or 'OK' to finish.");
                }
            }
        }
    }
}

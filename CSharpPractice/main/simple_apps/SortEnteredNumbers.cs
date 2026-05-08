using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.main.simple_apps
{
    public class SortEnteredNumbers
    {
        public static void SortEnteredNumbersMethod()
        {
            int numberLimit = 5;
            var numberToReturn = new List<int>();

            while (numberToReturn.Count < numberLimit)
            {
                Console.Write($"Enter number {numberToReturn.Count + 1}: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                {
                    if (numberToReturn.Contains(number))
                    {
                        Console.WriteLine("ERROR: You have already entered this number, please re-enter.");
                    }
                    else
                    {
                        numberToReturn.Add(number);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }

            numberToReturn.Sort();
            Console.WriteLine("Sorted numbers: " + string.Join(", ", numberToReturn));
        }

    }
}


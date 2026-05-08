using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.main.simple_apps
{
    public class DisplayThreeSmallestNumInList
    {

        public static void DisplayThreeSmallestNumInListMethod()
        {
            Console.WriteLine("Write up to 5 numbers separated by comma");

            while (true)
            {
                var inputList = new List<int>();

                string? input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Input cannot be empty. Please retry.");
                    continue;
                }

                var parts = input.Split(',');

                if (parts.Length > 5)
                {
                    Console.WriteLine("List cannot exceed 5 numbers. Please retry.");
                    continue;
                }

                bool hasParsingError = false;
                foreach (var part in parts)
                {
                    string trimmed = part.Trim();
                    if (int.TryParse(trimmed, out int value))
                    {
                        inputList.Add(value);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid number '{trimmed}'. Please enter only integers.");
                        hasParsingError = true;
                        break;
                    }
                }

                if (hasParsingError)
                    continue;

                if (inputList.Count < 5)
                {
                    Console.WriteLine("Invalid list: need exactly 5 numbers. Please retry.");
                    continue;
                }

                inputList.Sort();
                var smallestThree = inputList.Take(3);
                Console.WriteLine("Three smallest numbers: " + string.Join(", ", smallestThree));
                break;
            }
        }

    }
}

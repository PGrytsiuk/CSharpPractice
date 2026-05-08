using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.main.simple_apps
{
    public class Duplicate
    {
        public static void DuplicateMethod()
        {
            while (true)
            {
                Console.WriteLine("Enter a few numbers separated by hyphens");

                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Input cannot contain whitespaces or null or contain strings");
                    return;
                }

                var hyphenInput = input.Split('-')
                                        .Select(x => x.Trim())
                                        .Where(x => !string.IsNullOrEmpty(x))
                                        .ToList();

                var numbers = new List<int>();
                bool allNumbers = hyphenInput.All(n => int.TryParse(n, out _)); // Fixed the issue by passing 'n' instead of 'hyphenInput'  

                if (!allNumbers)
                {
                    Console.WriteLine("Input must contain only numbers separated by hyphens.");
                    continue;
                }

                foreach (var n in hyphenInput)
                {
                    if (int.TryParse(n, out int number))
                    {
                        numbers.Add(number);
                    }
                }

                bool duplicates = false;


                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    for (int j = i + 1; j < numbers.Count; j++) // Fixed the inner loop to start from i + 1  
                    {
                        if (numbers[i].Equals(numbers[j]))
                        {
                            duplicates = true;
                            break;
                        }
                    }
                    if (duplicates)
                        break;

                }

                if (duplicates)
                {
                    Console.WriteLine("Duplicate");
                }
                else
                {
                    break;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.DevTools.V130.Memory;

namespace CSharpPractice.main.simple_apps
{
    public class ShowIfRowIsConsecutive
    {
        public static void ShowIfRowIsConsecutiveMethod()
        {
            while (true)
            {
                Console.WriteLine("Enter a few numbers separated by hyphen");
                var inputRow = Console.ReadLine();
                
                if (string.IsNullOrWhiteSpace(inputRow))
                {
                    Console.WriteLine("Input cannot be null or empty.");
                    continue;
                }

                var row = inputRow.Split('-')
                                    .Select(n => n.Trim())
                                    .Where(n => !string.IsNullOrEmpty(n))
                                    .ToList(); // Convert IEnumerable<string> to List<string>    

                var numbers = new List<int>();
                bool allNumbers = row.All(n => int.TryParse(n, out _));
                if (!allNumbers)
                {
                    Console.WriteLine("Input must contain only numbers separated by hyphens.");
                    continue;
                }

                foreach (var n in row)
                {
                    if (int.TryParse(n, out int number))
                    {
                        numbers.Add(number);
                    }
                }

                bool isConsecutive = true;
                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers[i + 1] != numbers[i] + 1 && numbers[i + 1] != numbers[i] - 1)
                    {
                        isConsecutive = false;
                        break;
                    }
                }

                Console.WriteLine(isConsecutive ? "Consecutive" : "Not Consecutive");
            }
        }
    }
}

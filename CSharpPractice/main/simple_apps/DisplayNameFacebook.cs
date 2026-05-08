using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.main.simple_apps
{
    public class DisplayNameFacebook
    {
        public static void DisplayNameFacebookMethod()
        {
            Console.Write("Enter a name (or press Enter to finish): ");
            var inputNamesList = new List<string>();

            while (true)
            {
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                // Support multiple names separated by commas
                var names = input.Split(',')
                                 .Select(n => n.Trim())
                                 .Where(n => !string.IsNullOrEmpty(n));

                bool hasInvalid = false;
                foreach (var name in names)
                {
                    if (int.TryParse(name, out _))
                    {
                        Console.WriteLine($"Error: '{name}' is not a valid name (cannot be an integer).");
                        hasInvalid = true;
                        continue;
                    }
                    inputNamesList.Add(name);
                }

                if (hasInvalid)
                {
                    Console.Write("Enter a name (or press Enter to finish): ");
                    continue;
                }

                if (inputNamesList.Count == 1)
                {
                    Console.WriteLine($"{inputNamesList[0]} likes your post");
                }
                else if (inputNamesList.Count == 2)
                {
                    Console.WriteLine($"{inputNamesList[0]} and {inputNamesList[1]} like your post");
                }
                else if (inputNamesList.Count > 2)
                {
                    Console.WriteLine($"{inputNamesList[0]}, {inputNamesList[1]} and {inputNamesList.Count - 2} others like your post");
                }

                Console.Write("Enter a name (or press Enter to finish): ");
            }
        }
    }
}

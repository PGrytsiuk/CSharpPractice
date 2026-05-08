using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.main.simple_apps
{
    public class PascalCase
    {
        public static void PascalCaseMethod()
        {
            string exit = "Exit";
            
            while (true)
            {
                Console.WriteLine("Enter initials to convert them to Pascal case");
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input) || int.TryParse(input, out _))
                {
                    Console.WriteLine("Input cannot be a whitespace or Null or number");
                    continue;
                }

                var pascalCase = string.Concat(input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(word => char.ToUpper(word[0]) + word.Substring(1).ToLower()));

                Console.WriteLine(pascalCase);

                //var components = input.Split(' ')
                //                        .Select(x => x.Trim())
                //                        .Where(x => !string.IsNullOrEmpty(x))
                //                        .ToList(); ;

                //var initials = new List<string>();

                //foreach (var component in components)
                //{
                //    initials.Add(component);
                //}

                //var modifiedCollection = new List<string>();

                //foreach (var initial in initials)
                //{
                //    var modifiedInitinal = initial.ToLower();
                //    var afterConverting = char.ToUpper(modifiedInitinal[0]) + modifiedInitinal.Substring(1);
                //    modifiedCollection.Add(afterConverting);
                //}
                //Console.WriteLine("" + String.Join("", modifiedCollection));

            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.main.simple_apps
{
    public class DisplayUniqueNumbers
    {
        public static void DisplayUniqueNumbersMethod()
        {
            var exit = "Quit";
            var inputNumbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a number or Quit to display");
                var inputValue = Console.ReadLine();
                if (inputValue != null && inputValue.Contains(exit)) // Fix for CS8602  
                {
                    Console.WriteLine("Display unique numbers: " + String.Join(", ", inputNumbers));
                    break;
                }
                if (int.TryParse(inputValue, out int number))
                {
                    if (!inputNumbers.Contains(number))
                    {
                        inputNumbers.Add(number);
                    }                 
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.main.simple_apps
{
    public class ValidTime
    {
        public static void ValidTimeMethod()
        {
            while (true)
            {
                Console.WriteLine("Enter time (HH:mm):");

                var inputTime = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(inputTime))
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                var components = inputTime.Split(':');

                if (components.Length > 2)
                {
                    Console.WriteLine("Invalid format");
                    continue;
                }

                if(TimeSpan.TryParse(inputTime, out TimeSpan time))
                { 
                    var hours = Convert.ToInt32(components[0]);
                    var minutes = Convert.ToInt32(components[1]);
                    //var minTime = TimeSpan.Zero;
                    //var maxTime = new TimeSpan(23, 59, 0);

                    //if (time >= minTime && time <= maxTime)
                    if (hours >= 0 && minutes >=0 && hours <= 23 && minutes <= 59)
                    {
                        Console.WriteLine("OK");
                    }
                    else
                    {
                        Console.WriteLine("Invalid time");
                    }
                }else
                    
                    Console.WriteLine("Invalid input");
            }
        }
    }
}

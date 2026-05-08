using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.main.simple_apps
{
    public class NumbersDevisibleBy3
    {
        public static void NumbersDevisibleBy3Method()
        {
            int count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                { 
                    count++;
                }
            }

            Console.WriteLine("Count between 1 and 100 devisible by 3: " + count);
        }
    }
}

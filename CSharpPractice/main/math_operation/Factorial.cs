using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.main.math_operation
{
    internal class Factorial
    {
        public void FactorialMethod(int num)
        {
           int factorial = 1;
           for (int i = 1;  i <= num; i ++)
            {
                factorial *= i;
            }
            Console.WriteLine("Factorial of " + num + " is " + factorial);
        }
    }
}

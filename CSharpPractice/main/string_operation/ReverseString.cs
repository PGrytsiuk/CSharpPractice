using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.main.string_operation
{
    internal class ReverseString
    {
        public void ReverseStringMethod(String str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            Console.WriteLine("Reversed string: " + new string(chars));
        }
    }
}

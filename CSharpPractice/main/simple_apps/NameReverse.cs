using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.main.simple_apps
{
    public class NameReverse
    {
        public static void NameReverseMethod(string[] name)
        {
            Array.Reverse(name);
            var reversedName = String.Join("", name);
            Console.WriteLine("Reversed Name " + reversedName);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.main.arrays_operations
{
    public class FuzzBizz
    {
        public static void FuzzBizzOperation(int[] arr )
        {
            foreach(int num in arr)
            {
                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine("FuzzBizz");
                }
                else if (num % 3 == 0 )
                {
                    Console.WriteLine("Fuzz");
                }
                else if (num % 5 == 0)
                {
                    Console.WriteLine("Bizz");
                }
                else if(num % 3 != 0 && num % 5 != 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}

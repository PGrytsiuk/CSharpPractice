using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.main.math_operation
{
    public class FibonacciLinQ
    {
        public static IEnumerable<int> FibonacciViaLinq(int n)
        {
            if (n < 1)
            {
                throw new ArgumentException(
                    $"Can't generate Fibonacci sequence " +
                    $"for {n} elements. N must be a " +
                    $"positive number");
            }

            if (n == 1)
            {
                return new[] { 0 };
            }

            return Enumerable.Range(1, n - 2).Aggregate(new List<int> { 0, 1 } as IEnumerable<int>, (acc, nextNum) => acc.Append(acc.ElementAt(nextNum - 1) + acc.ElementAt(nextNum))
           );
        }
    }
}

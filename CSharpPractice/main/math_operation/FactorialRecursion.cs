namespace CSharpPractice.main.math_operation
{
    public class FactorialRecursion
    {
        public static int FactorialRecursionMethod(int factorial)
        {
            if (factorial == 0)
            {
                return 1;
            }
            return factorial * FactorialRecursionMethod(factorial - 1);
        }
    }
}

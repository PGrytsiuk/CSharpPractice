namespace CSharpPractice.main.math_operation
{
    public class YearIsLeap
    {

        public static void YearIsLeapMethod(int year)
        {
            bool isLeap = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            Console.WriteLine(isLeap ? $"{year} is a leap year" : $"{year} is not a leap year");
        }
    }
}

namespace CSharpPractice.main.math_operation
{
    public class ArmstrongNumber
    {
        public static void CheckArmStrongNumber(int n)
        {
            int sum = 0;
            int temp = n;
            while (n > 0)
            {
                int reminder = n % 10;
                sum += (int)Math.Pow(reminder, 3);
                n /= 10;
            }
            if (temp == sum)
            {
                Console.WriteLine(temp + " is an Armstrong number");
            }
            else
            {
                Console.WriteLine(temp + " is not an Armstrong number");
            }
        }
    }
}

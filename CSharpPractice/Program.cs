// See https://aka.ms/new-console-template for more information
using CSharpPractice.main.math_operation;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //int a = 5;
        //int b = 6;
        //string str = "TEst test test test";
        //int fact = 5;
        //Console.WriteLine(countFactorial(fact));
        //NewMethod(a, b);
        //countProbils(str);
        //static void NewMethod(int a, int b)
        //{
        //    int sum = a + b;
        //    Console.WriteLine(sum);
        //}
        //static void countProbils(string str)
        //{
        //    int length = str.Length;
        //    for (int i = 0; i < length; i++)
        //    {
        //        if (str[i] == ' ')
        //            Console.WriteLine("Space found by index " + i);
        //    }
        //}
        //static int countFactorial(int fact)
        //{
        //    if (fact == 0)
        //    {
        //        return 1;
        //    }
        //    return fact * countFactorial(fact - 1);
        //}
        //Console.WriteLine("Enter your surname: ");
        //string surname = Console.ReadLine();
        //Console.WriteLine("Enter your name: ");
        //string name = Console.ReadLine();
        //Console.WriteLine("Hello, " + name + "!" + " " + surname);
        //Fibonacci fibonacci = new Fibonacci();
        //fibonacci.GenerateFibonacciSeries(10);
        while (true) {

            Console.WriteLine("\nSelect an operation");
            Console.WriteLine("1. Count Fibonacci");
            Console.WriteLine("2. Exit");
            String choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Fibonacci fibonacci = new Fibonacci();
                    Console.WriteLine("Enter the number of Fibonacci numbers to generate:");
                    int n = Convert.ToInt32(Console.ReadLine());
                    fibonacci.GenerateFibonacciSeries(n);
                    break;
                case "2":
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;

                    Console.WriteLine("\nSelect an operation");
                    Console.WriteLine("1. Count Fibonacci");
                    Console.WriteLine("2. Exit");
                    choice = Console.ReadLine();
            }

        }
        
    }
}
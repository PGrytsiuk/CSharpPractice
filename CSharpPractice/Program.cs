// See https://aka.ms/new-console-template for more information
using CSharpPractice.main.math_operation;

class Program
{
    static void Main(string[] args)
    {
        while (true) {

            Console.WriteLine("\nSelect an operation");
            Console.WriteLine("1. Count Fibonacci");
            Console.WriteLine("2. Count Spaces");
            Console.WriteLine("3. Exit");
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
                    CountSpaces countSpaces = new CountSpaces();
                    Console.WriteLine("Enter a string:");
                    string str = Console.ReadLine();
                    countSpaces.countProbils(str);
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;

                Console.WriteLine("\nSelect an operation");
                Console.WriteLine("1. Count Fibonacci");
                Console.WriteLine("2. Count Spaces");
                Console.WriteLine("3. Exit");
                choice = Console.ReadLine();
            }

        }
        
    }
}
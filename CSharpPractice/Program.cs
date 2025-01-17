// See https://aka.ms/new-console-template for more information
using CSharpPractice.main.arrays_operations;
using CSharpPractice.main.math_operation;
using CSharpPractice.main.simple_login;
using CSharpPractice.main.string_operation;

class Program
{
    static void Main(string[] args)
    {
        while (true) {

            Console.WriteLine("\nSelect an operation");
            Console.WriteLine("1. Count Fibonacci");
            Console.WriteLine("2. Count Spaces");
            Console.WriteLine("3. Sort array");
            Console.WriteLine("4. Simple login");
            Console.WriteLine("5. Exit");
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
                    ArraySort sortArray = new ArraySort();
                    Console.WriteLine("Enter the array elements separated by space:");
                    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    sortArray.arraySort(arr);
                    break;
                case "4":
                    SimpleLogin simpleLogin = new SimpleLogin();
                    simpleLogin.Login();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;

                Console.WriteLine("\nSelect an operation");
                Console.WriteLine("1. Count Fibonacci");
                Console.WriteLine("2. Count Spaces");
                Console.WriteLine("3. Sort array");
                Console.WriteLine("4. Simple login");
                Console.WriteLine("5. Exit");
                choice = Console.ReadLine();
            }
        }
    }
}
// See https://aka.ms/new-console-template for more information
using CSharpPractice.main.arrays_operations;
using CSharpPractice.main.math_operation;
using CSharpPractice.main.simple_login;
using CSharpPractice.main.string_operation;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nSelect an operation");
            Console.WriteLine("1. Array operations");
            Console.WriteLine("2. Math operations");
            Console.WriteLine("3. String operations");
            Console.WriteLine("4. Simple login");
            Console.WriteLine("5. Exit");
            String choice = Console.ReadLine();
            NewMethod(choice);
            if (choice == "5" )
            {
                break;
            }
        }
    }

    private static void NewMethod(string choice)
    {
        switch (choice)
        {
            case "1":
                Console.WriteLine("\nSelect an operation");
                Console.WriteLine("1. Bubble Sort");
                Console.WriteLine("2. Array Sort");
                Console.WriteLine("3. Find common elements in array");
                Console.WriteLine("4. Count duplicates in array");
                Console.WriteLine("5. Find duplicates integers in array");
                Console.WriteLine("6. Find missing number");
                Console.WriteLine("7. Find largest number");
                Console.WriteLine("8. Merge two arrays");
                Console.WriteLine("9. Remove Dublicates from the array");
                string selectedArrayOperation = Console.ReadLine();
                switch (selectedArrayOperation)
                {
                    case "1":
                        BubbleSort bubbleSort = new BubbleSort();
                        Console.WriteLine("Enter the array elements separated by space:");
                        int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                        bubbleSort.BubbleSortMethod(arr1);
                        break;
                    case "2":
                        ArraySort sortArray = new ArraySort();
                        Console.WriteLine("Enter the array elements separated by space:");
                        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                        sortArray.arraySortMethod(arr);
                        break;
                    case "3":
                        CommonElements commonElements = new CommonElements();
                        Console.WriteLine("Select the common elements method from 1 - 3");
                        String commonElementsMethod = Console.ReadLine();
                        switch (commonElementsMethod)
                        {
                            case "1":
                                Console.WriteLine("Enter the first array elements separated by space:");
                                int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                                Console.WriteLine("Enter the second array elements separated by space:");
                                int[] arr3 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                                commonElements.CommonElementsMethod(arr2, arr3);
                                break;
                            case "2":
                                Console.WriteLine("Enter the first array elements separated by space:");
                                int[] arr4 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                                Console.WriteLine("Enter the second array elements separated by space:");
                                int[] arr5 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                                commonElements.CommonElementsMethod2(arr4, arr5);
                                break;
                            case "3":
                                Console.WriteLine("Enter the first array elements separated by space:");
                                int[] arr6 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                                Console.WriteLine("Enter the second array elements separated by space:");
                                int[] arr7 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                                commonElements.CommonElementsMethod3(arr6, arr7);
                                break;
                        }
                        break;
                    case "4":
                        CountDuplicates countDuplicates = new CountDuplicates();
                        Console.WriteLine("Enter the array elements separated by space:");
                        int[] arr8 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                        countDuplicates.CountDuplicatesMethod(arr8);
                        break;
                    case "5":
                        Console.WriteLine("Enter the array elements separated by space:");
                        int[] arr9 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                        HashSet<int> duplicates = FindDuplicatesIntegers.FindDuplicates(arr9);
                        Console.WriteLine("Duplicates are: " + string.Join(", ", duplicates));
                        break;
                    case "6":
                        Console.WriteLine("Enter the array row separated by space with missing elements inside");
                        int[] arr10 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                        FindMissingNumbers.FindMissingNumberMethod(arr10);
                        break;
                    case "7":
                        Console.WriteLine("Enter the array elements separated by space:");
                        int[] arr11 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                        FindLargestElemeintInArray.FindLargestElementMethod(arr11);
                        break;
                    case "8":
                        Console.WriteLine("Enter the first array elements separated by space:");
                        int[] arr12 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                        Console.WriteLine("Enter the second array elements separated by space:");
                        int[] arr13 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                        MergeTwoArrays.MergeTwoArraysMethod(arr12, arr13);
                        break;
                    case "9":
                        RemoveDuplicatesInArray removeDuplicatesInArray = new RemoveDuplicatesInArray();
                        Console.WriteLine("Select a method from 1 - 2 to remove duplicates from the Array:");
                        String removeDuplicatesMethod = Console.ReadLine();
                        switch (removeDuplicatesMethod)
                        {
                            case "1":
                                Console.WriteLine("Enter the array elements separated by space:");
                                int[] arr14 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                                removeDuplicatesInArray.RemoveDuplicatesInArrayMethod(arr14);
                                break;
                            case "2":
                                Console.WriteLine("Enter the array elements separated by space:");
                                int[] arr15 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                                removeDuplicatesInArray.RemoveDuplicatesWithStreams(arr15);
                                break;
                        }
                        break;
                }
                break;
            case "2":
                Console.WriteLine("\nSelect an math operation");
                Console.WriteLine("1. Fibonacci");
                Console.WriteLine("2. Factorial");
                string selectedMathOperation = Console.ReadLine();
                switch (selectedMathOperation)
                {
                    case "1":
                        Fibonacci fibonacci = new Fibonacci();
                        Console.WriteLine("Enter the number of Fibonacci numbers to generate:");
                        int n = Convert.ToInt32(Console.ReadLine());
                        fibonacci.GenerateFibonacciSeries(n);
                        break;
                    case "2":
                        Factorial factorial = new Factorial();
                        Console.WriteLine("Enter the number to calculate factorial:");
                        int num = Convert.ToInt32(Console.ReadLine());
                        factorial.FactorialMethod(num);
                        break;
                }
                break;
            case "3":
                Console.WriteLine("\nSelect an string operation");
                Console.WriteLine("1. Count spaces");
                Console.WriteLine("2. Reverse string");
                string selectedStringOperation = Console.ReadLine();
                switch (selectedStringOperation)
                {
                    case "1":
                        CountSpaces countSpaces = new CountSpaces();
                        Console.WriteLine("Enter a string:");
                        string str = Console.ReadLine();
                        countSpaces.CountProbils(str);
                        break;
                    case "2":
                        ReverseString reverseString = new ReverseString();
                        Console.WriteLine("Enter a string:");
                        string str1 = Console.ReadLine();
                        reverseString.ReverseStringMethod(str1);
                        break;
                }
                break;
            case "4":
                SimpleLogin simpleLogin = new SimpleLogin();
                simpleLogin.Login();
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}
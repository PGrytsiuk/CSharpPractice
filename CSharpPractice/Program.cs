// See https://aka.ms/new-console-template for more information
using CSharpPractice.main.arrays_operations;
using CSharpPractice.main.math_operation;
using CSharpPractice.main.simple_apps;
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
            Console.WriteLine("4. Simple apps");
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
                Console.WriteLine("10. Find second largest element in the array");
                Console.WriteLine("11. Selection sort");
                Console.WriteLine("12. FuzzBizz");
                Console.WriteLine("13. Stack");
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
                    case "10":
                        Console.WriteLine("Enter the array elements separated by space:");
                        int[] arr16 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                        int secondLargest = FindSecondLargestArray.FindSecondLargestElementInArrayMethod(arr16);
                        Console.WriteLine("Second largest element in the array is: " + string.Join(",", secondLargest));
                        break;
                    case "11":
                        Console.WriteLine("Enter the array elements separated by space:");
                        int[] arr17 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                        SelectionSort.SelectionSortMethod(arr17);
                        break;
                    case "12":
                        Console.WriteLine("Enter the number to play FuzzBizz:");
                        int[] fuzzBizzArr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                        FuzzBizz.FuzzBizzOperation(fuzzBizzArr);
                        break;
                    case "13":
                        var stack = new Stack();
                        stack.Push(1);
                        stack.Push(2);
                        stack.Push(3);
                        stack.Push("Hello");
                        stack.Push(new DateTime(1997, 12, 26));
                        stack.Push(4);

                        Console.WriteLine(stack.Pop());
                        Console.WriteLine(stack.Pop());
                        Console.WriteLine(stack.Pop());
                        Console.WriteLine(stack.Pop());
                        Console.WriteLine(stack.Pop());
                        stack.Clear();
                        break;
                }
                break;
            case "2":
                Console.WriteLine("\nSelect an math operation");
                Console.WriteLine("1. Fibonacci");
                Console.WriteLine("2. Factorial");
                Console.WriteLine("3. Armstrong number");
                Console.WriteLine("4. Convert to Binary number");
                Console.WriteLine("5. Factorial using recursion");
                Console.WriteLine("6. Find even numbers in array");
                Console.WriteLine("7. Find GCD of two numbers");
                Console.WriteLine("8. Year is leap year");

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
                    case "3":
                        
                        Console.WriteLine("Enter the number to check if it is Armstrong number:");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        ArmstrongNumber.CheckArmStrongNumber(num1);
                        break;
                    case "4":
                        Console.WriteLine("Enter the number to convert to binary:");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        string binaryResult = ConvertToBinary.ConvertToBinaryMethod(num2);
                        Console.WriteLine("Binary number is: " + binaryResult);
                        break;
                    case "5":
                        Console.WriteLine("Enter the factorial number");
                        int num3 = Convert.ToInt32(Console.ReadLine());
                        int factorialResult = FactorialRecursion.FactorialRecursionMethod(num3);
                        Console.WriteLine("Factorial of " + num3 + " is: " + factorialResult);
                        break;
                    case "6":
                        Console.WriteLine("Enter the array elements separated by space:");
                        int[] arr18 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                        FindEvenNumber.FindEvenNumberMethod(arr18);
                        break;
                    case "7":
                        Console.WriteLine("Enther first number:");
                        int num4 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enther second number:");
                        int num5 = Convert.ToInt32(Console.ReadLine());
                        int gcd = FindGCDofTwoIntegers.FindGCDofTwoItegersMethod(num4, num5);
                        Console.WriteLine("GCD of " + num4 + " and " + num5 + " is: " + gcd);
                        break;
                    case "8":
                        Console.WriteLine("Enter the year to check if it is a leap year:");
                        int year = Convert.ToInt32(Console.ReadLine());
                        YearIsLeap.YearIsLeapMethod(year);
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
                Console.WriteLine("\nSelect an app");
                Console.WriteLine("1. Simple login");
                Console.WriteLine("2. Stopwatch");
                Console.WriteLine("3. Post class");
                string selectedApp = Console.ReadLine();
                switch (selectedApp)
                {
                    case "1":
                        SimpleLogin simpleLogin = new SimpleLogin();
                        simpleLogin.Login();
                        break;
                    case "2":
                        Stopwatch stopwatch = new Stopwatch();
                        while (true)
                        {
                            Console.WriteLine("Press Enter to start the stopwatch, or Esc to exit.");
                            var key = Console.ReadKey(intercept:true);

                            if (key.Key == ConsoleKey.Escape)
                                break;
                            if (key.Key == ConsoleKey.Enter)
                            {
                                try
                                {
                                    stopwatch.Start();
                                    Console.WriteLine("---Stopwatch is running---");
                                    Console.WriteLine("Press Enter to stop the stopwatch, or Esc to exit.");
                                    Console.ReadLine();
                                    stopwatch.Stop();
                                    Console.WriteLine($"Elapsed time: {stopwatch.ElapsedTime.Seconds} seconds");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("An error occurred: " + ex.Message);
                                }
                            }
                            Console.WriteLine("Press R to reset the Stopwatch or Enter to continue");
                            var resetKey = Console.ReadKey(intercept: true);

                            if (resetKey.Key == ConsoleKey.R)
                            {
                                Console.WriteLine("Time is reset");
                                stopwatch.Reset();
                            }
                        }
                        break;
                    case"3":
                        Post myPost = new Post(
                        "Hello World",
                        "This is my first post using the Post class.",
                        DateTime.Now);
                        Console.WriteLine("Title " + myPost.Title);
                        myPost.DisplayPost();
                        myPost.Title = "Updated Title";
                        myPost.Description = "This is an updated description for my post.";
                        myPost.PublishDate = DateTime.Now.AddDays(1);
                        myPost.UpVote();
                        myPost.UpVote();
                        myPost.UpVote();
                        myPost.DownVote();
                        myPost.DisplayVotes();
                        myPost.DisplayPost();
                        break;
                }
                break;
            case "5":
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}
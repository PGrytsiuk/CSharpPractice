﻿namespace CSharpPractice.main.math_operation
{
    public class FindGCDofTwoIntegers
    {
        public static int FindGCDofTwoItegersMethod(int num1, int num2)
        {
            while (num2 != 0)
            {
                int temp = num2;
                num2 = num1 % num2;
                num1 = temp;

            }
             return num1;
        }
    }
}

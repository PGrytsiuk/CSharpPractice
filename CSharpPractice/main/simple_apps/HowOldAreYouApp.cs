using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.main.simple_apps
{
    public class HowOldAreYouApp
    {
        public static void WhatIsYourAge(int birthYear, int expectedYear)
        { 
            int Result = expectedYear - birthYear;
            Console.WriteLine("You are " + Result + " years old.");
        }
    }
}

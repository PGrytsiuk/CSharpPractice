using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.main.simple_apps
{
    public class GuessNumberGame
    {
        public static void GuessNumberGameMethod()
        { 
            Random rnd = new Random();
            var rndinput = rnd.Next(10)+1;
            var amountOfChancess = 4;
            Console.WriteLine("For testing purposes: " + rndinput);
            while (true)
            {
                var num = int.Parse(Console.ReadLine());
                try
                {
                    if (num == rndinput)
                    {
                        Console.WriteLine("You Won");
                        break;
                    }
                    else
                    {
                        if (num != rndinput)
                            amountOfChancess--;
                        Console.WriteLine(amountOfChancess + " amount of chancess left");
                    }
                    if (amountOfChancess == 0)
                    {
                        Console.WriteLine("You lost");
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input");
                }
            }

        }
    }
}

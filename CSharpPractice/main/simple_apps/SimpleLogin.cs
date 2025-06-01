using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.main.simple_apps
{
    public class SimpleLogin
    {
        private string name = "admin";
        private string password = "pw";
        public void Login()
        {
            while (true)
            {
                Console.WriteLine("Enter your name:");
                string inputName = Console.ReadLine();
                Console.WriteLine("Enter your password:");
                string inputPassword = Console.ReadLine();
                if (inputName == name && inputPassword == password)
                {
                    Console.WriteLine("Login successful");
                    break;
                }
                else
                {
                    Console.WriteLine("Login failed");
                }
            }
        }
    }    
}
       


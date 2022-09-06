using System;
using System.Collections.Generic;
using System.Text;

namespace Assesment_Test
{
    class Program_4
    {
        static void Program(string[] args)
        {
            Console.WriteLine("Assesment Program 4");
            Console.WriteLine("\n------------------------------------------------------------------------------");
            Console.WriteLine("\n\nWrite a program in C# Sharp to check the username and password.");

            string username, password;
            bool flag;
            Console.Write("\nEnter User Name : ");
            username = Console.ReadLine();
            Console.Write("Enter Password : ");
            password = Console.ReadLine();

            if (username == "bhavika" && password == "passwordB")
            {
                Console.WriteLine("\nPassword Entered successfully");
            }
            else
            {
                Console.WriteLine("\nIncorrect username or password!");
            }

        }
    }
}

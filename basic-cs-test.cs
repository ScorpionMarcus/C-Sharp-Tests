using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ReadLine and WriteLine
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            

            // Conditions (if statements)
            if (name == "Cool Guy")
            {
                Console.WriteLine("Hey Cool Guy!");
            } else
            {
                Console.WriteLine("Your name is {0}", name);
            }

            // While Loops

            var code = "";

            while(code != "secret")
            {
                Console.WriteLine("What is the pass code?");
                code = Console.ReadLine();

                if (code != "secret")
                    Console.WriteLine("Not Authenticated");

                Console.WriteLine("Authenticated");
            }

            // For Loops

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
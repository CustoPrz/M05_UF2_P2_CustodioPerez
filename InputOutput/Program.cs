using System;

namespace InputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Please write yes/no");
                string response = Console.ReadLine().ToLower();
                if (response == "yes")
                {
                    Console.WriteLine("Hello world");
                    running = false;
                }
                else if (response == "no")
                {
                    Console.WriteLine("Goodbye world");
                    running = false;
                }
                else
                {
                    Console.WriteLine("Not recognized");
                }
            }
        }
    }
}

using System;
using System.Threading;

// A simple text adventure to learn C# and .NET!
class Program
{
    static void Main(string[] args)
    {
        // main loop
        while (true)
        {
            Console.WriteLine("S Y N T H E S I S");
            Thread.Sleep(500);
            Console.Write(" *");
            Thread.Sleep(500);
            Console.Write(" *");
            Thread.Sleep(500);
            Console.WriteLine(" *");
            Thread.Sleep(500);
            Console.WriteLine("Start? Y/N");


            Console.WriteLine("Waiting for input...");
            
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                Quit();
            }
            if (input.ToLower() == "n")
            {
                Quit();
            }
            if (input.ToLower() == "y")
            {
                // Start();
            }
        }

        static void Quit()
        {
            Console.WriteLine("See ya!");
            Environment.Exit(0);
        }

        // TODO - make wait() method and start()
    }
}

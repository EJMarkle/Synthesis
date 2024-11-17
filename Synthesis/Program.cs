using System;

// A simple text adventure to learn C# and .NET!
class Program
{
    static void Main(string[] args)
    {
        // main loop
        while (true)
        {
            Console.WriteLine("Waiting for input...");
            
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                Console.WriteLine("See ya!");
                break;
            }
        }
    }
}

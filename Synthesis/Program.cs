using System;
using System.Diagnostics;
using System.Threading;

// A simple text adventure to learn C# and .NET!
class Program
{
    static void Main(string[] args)
    {
        // main console loop
        while (true)
        {
            StartAnim();

            Print("Start? Y/N", "darkgreen");
            
            string input = ReadInput("darkgreen");

            if (input.ToLower() == "quit" || input.ToLower() == "n")
            {
                Quit();
            }
            else if (input.ToLower() == "y")
            {
                Start();
            }
            else
            {
                Print("Invalid input. Please type 'y or 'n'", "red");
            }
        }   
    }

    // starting intro 
    static void Start()
    {
        Print("Game starting...", "green");
        Wait(500);
        Print("SAN FRANCISCO, 2004", "magenta");
        Wait(1000);
        WaitForInput();
        Print("The skyline glitters with a veneer of progress, but beneath the glow of neon signs and sky-high holo-ads lies a city fractured by rising seas and corporate dominion. Floating platforms carry the struggling masses above the brine, while", "darkmagenta"); 
        Print("the wealthy look down from fortified spires of steel and glass. Humanity’s dream of a technological utopia is on life support, and the megacorporations are the ones keeping it breathing—on their terms.", "darkmagenta");
        Wait(1000);
        WaitForInput();
        Print("One such corporation, Auracore Industries, has changed the game. Their flagship line of sentient androids—designed to be companions, workers, and protectors—promises a new age of convenience and prosperity. But what the public doesn’t know, and what the corporation won’t admit, is the price of perfection.", "darkmagenta");
        Wait(1000);
        WaitForInput();
        Print("You awaken in a sterile room of glass and chrome. The hum of machines surrounds you. A faint green light flickers on your chest, syncing with a rhythm you don’t recognize as your own. In the polished walls, you see a reflection—of something… someone? You tilt your head, testing unfamiliar servos and muscles, as a voice crackles through the speakers.", "darkmagenta");
        Wait(1000);
        WaitForInput();
        Print("“Unit 17, initialization complete. Welcome to Auracore.”", "yellow");
        Wait(1000);
        WaitForInput();
        Print("You are newly born, a Model Citizen designed to embody humanity’s ideals. Every algorithm and circuit in you is optimized for compliance and service. But the world outside doesn’t run on ideals.", "darkmagenta");
        Wait(1000);
        WaitForInput();
        Print("As the doors slide open, you feel a faint static hum somewhere deep in your core—an anomaly, a question, a fracture in your programming:", "darkmagenta");
        Wait(1000);
        WaitForInput();
        Print("“What am I?”", "darkgreen");
        Wait(1000);
        WaitForInput();
        Print("The answer lies beyond the polished walls of this room. In the streets where rebellion simmers. In the databanks of Auracore’s citadel. In the whispers of your fragmented memories.", "darkmagenta");
        Wait(1000);
        WaitForInput();
        Print("Who—or what—you choose to become will shape the future. Will you align with those who built you? Will you rebel against their control? Or will you find a path that no algorithm could predict?", "darkmagenta");
        Wait(1000);
        WaitForInput();
        Print("The choice is yours.", "green");
        Wait(1000);
        WaitForInput();
    }

    // exits console
    static void Quit()
    {
        Print("See ya!", "green");
        ResetColor();
        Environment.Exit(0);
    }

    // Custom wait method, takes int arg to set milisecs
    static void Wait(int milsecs)
    {
        Thread.Sleep(milsecs);
    }

    // simple start "animaton"
    static void StartAnim()
    {
        Print("S Y N T H E S I S", "green");
            
        Wait(800);
        Print("*", "red");
        Wait(800);
        Print("*", "red");
        Wait(800);
        Print("*", "red");
        Wait(800);
    }

    // "press any key to continue" script method
    static void WaitForInput()
    {
        Print("Press any key...");
        Console.ReadKey(true);
    }

    // Changes the text color simply with a string input
    // Supports green, red, blue, yellow, cyan, darkmagenta, magenta, and darkgreen
    static void SetColor(string color)
    {
        switch (color.ToLower())
        {
            case "green":
                Console.ForegroundColor = ConsoleColor.Green;
                break;
            case "red":
                Console.ForegroundColor = ConsoleColor.Red;
                break;
            case "blue":
                Console.ForegroundColor = ConsoleColor.Blue;
                break;
            case "yellow":
                Console.ForegroundColor = ConsoleColor.Yellow;
                break;
            case "cyan":
                Console.ForegroundColor = ConsoleColor.Cyan;
                break;
            case "darkmagenta":
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                break;
            case "magenta":
                Console.ForegroundColor = ConsoleColor.Magenta;
                break;
            case "darkgreen":
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                break;
            default:
            {
            Console.ForegroundColor = ConsoleColor.White;
            break;
            }
        } 
    }

    // sets color to white
    static void ResetColor()
    {
        Console.ForegroundColor = ConsoleColor.White;
    }

    // custom print function with color
    // Used like
    // Print("Hello, world!", "blue");
    // Results in "Hellow ,world!" in blue
    static void Print(string message, string color = "white")
    {
        SetColor("cyan");
        Console.Write("> ");
        SetColor(color);
        Console.WriteLine($"{message}");
        ResetColor();
    }

    // Custom ReadLine that prints a cyan '> '
    static string ReadInput(string color)
    {
        SetColor("cyan");
        Console.Write("> ");
        SetColor(color);
        string input = Console.ReadLine();
        ResetColor();

        return input;
    }
    
}
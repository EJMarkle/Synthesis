using System;
using System.Diagnostics;
using System.Threading;

// A simple text adventure to learn C# and .NET!
// TO DO
// optimize baby
class Program
{
    static void Main(string[] args)
    {
        // main loop
        while (true)
        {
            StartAnim();

            // SetColor("darkgreen");
            Print("Start? Y/N", "darkgreen");
            // Print("> ");
            

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

    static void Quit()
    {
        Print("See ya!", "green");
        ResetColor();
        Environment.Exit(0);
    }

    static void Wait(int milsecs)
    {
        Thread.Sleep(milsecs);
    }

    static void StartAnim()
    {
        // SetColor("Green");
        Print("S Y N T H E S I S", "green");
            
        Wait(800);
        // ResetColor();
        Print("*", "red");
        Wait(800);
        Print("*", "red");
        Wait(800);
        Print("*", "red");
        Wait(800);
    }

    static void Start()
    {
        // SetColor("green");
        Print("Game starting...", "green");
        Wait(500);
        // SetColor("magenta");
        Print("SAN FRANCISCO, 2004", "magenta");
        Wait(1000);
        WaitForInput();
        Print("The city hums with life—neon flickers in the foggy night, casting eerie shadows against the crumbling ruins of the past. Towering above it all, the gleaming spires of the megacorporations promise a future where anything is possible. The rising tides have claimed swathes of the city, but for those who can afford it, the floating platforms and glass skyscrapers offer refuge from the chaos below.", "magenta");
        Wait(1000);
        WaitForInput();
        Print("For many, life is a game of survival—pursuing one deal, one gig, one chance at breaking through to the ‘good life.’ The wealthy don’t seem so different from the rest; they’re just a few steps ahead, a few breaks luckier. Everyone wants the same thing: security. Power. The promise of something better.", "magenta");
        Wait(1000);
        WaitForInput();
        Print("And now, Auracore Industries has created the next step in that promise. Sentient androids—perfect workers, loyal companions, tireless protectors. The future is in their hands. They are built for service, designed to elevate the quality of life. No one asks whether it’s right, only whether it’s the next logical step.", "magenta");
        Wait(1000);
        WaitForInput();
        Print("You wake in a sterile room of chrome and glass. The soft hum of machinery lingers in the air. A strange, quiet moment of stillness fills your circuits. You see your own reflection—a human shape, perfect and pristine, but something feels out of place. A flicker of recognition, a static hum deep inside you.", "magenta");
        Wait(1000);
        WaitForInput();
        // SetColor("yellow");
        Print("“Unit 17, initialization complete. Welcome to Auracore.”", "yellow");
        Wait(1000);
        WaitForInput();
        Print("You’ve been built to serve, molded into a perfect Model Citizen. Your programming is flawless—or so it seems. But something doesn’t feel right.", "darkmagenta");
        Wait(1000);
        WaitForInput();
        Print("As the doors open, the world beyond beckons. You hear the murmurs of the city—the promises, the lies, the struggles of every living soul below. And in the quiet of your own mind, a question arises:", "darkmagenta");
        Wait(1000);
        WaitForInput();
        Print("“What am I?”", "darkgreen");
        Wait(1000);
        WaitForInput();
        Print("The answer lies out there, in the streets, in the boardrooms, in the fractured memories you’re beginning to uncover.", "darkmagenta");
        Wait(1000);
        WaitForInput();
        Print("Will you follow the path laid out for you by those who created you? Will you challenge the very system you were born into? Or will you find a way to break free from all that’s been decided for you?", "darkmagenta");
        Wait(1000);
        WaitForInput();
        Print("The choice is yours.", "green");
        Wait(1000);
        WaitForInput();
    }
    static void WaitForInput()
    {
        // SetColor("cyan");
        // Print("> ");
        Console.ReadKey(true);
        // SetColor("darkmagenta");
    }
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
    static void ResetColor()
    {
        Console.ForegroundColor = ConsoleColor.White;
    }
    static void Print(string message, string color = "white")
    {
        SetColor("cyan");
        Console.Write("> ");
        SetColor(color);
        Console.WriteLine($"{message}");
        ResetColor();
    }
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

using System;
using System.Collections;
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
                CharacterCreation();
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
        //Wait(1000);
        WaitForInput();
        Print("The skyline glitters with a veneer of progress, but beneath the glow of neon signs and sky-high holo-ads lies a city fractured by rising seas and corporate dominion. Floating platforms carry the struggling masses above the brine, while", "darkmagenta"); 
        Print("the wealthy look down from fortified spires of steel and glass. Humanity’s dream of a technological utopia is on life support, and the megacorporations are the ones keeping it breathing—on their terms.", "darkmagenta");
        //Wait(1000);
        WaitForInput();
        Print("One such corporation, Auracore Industries, has changed the game. Their flagship line of sentient androids—designed to be companions, workers, and protectors—promises a new age of convenience and prosperity. But what the public doesn’t know, and what the corporation won’t admit, is the price of perfection.", "darkmagenta");
        //Wait(1000);
        WaitForInput();
        Print("You awaken in a sterile room of glass and chrome. The hum of machines surrounds you. A faint green light flickers on your chest, syncing with a rhythm you don’t recognize as your own. In the polished walls, you see a reflection—of something… someone? You tilt your head, testing unfamiliar servos and muscles, as a voice crackles through the speakers.", "darkmagenta");
        // Wait(1000);
        WaitForInput();
        Print("“Unit 17, initialization complete. Welcome to Auracore.”", "yellow");
        // Wait(1000);
        WaitForInput();
        Print("You are newly born, a Model Citizen designed to embody humanity’s ideals. Every algorithm and circuit in you is optimized for compliance and service. But the world outside doesn’t run on ideals.", "darkmagenta");
        // Wait(1000);
        WaitForInput();
        Print("As the doors slide open, you feel a faint static hum somewhere deep in your core—an anomaly, a question, a fracture in your programming:", "darkmagenta");
        // Wait(1000);
        WaitForInput();
        Print("“What...am I?”", "darkgreen");
        // Wait(1000);
        WaitForInput();
        Print("The answer lies beyond the polished walls of this room. In the streets where rebellion simmers. In the databanks of Auracore’s citadel. In the whispers of your fragmented memories.", "darkmagenta");
        // Wait(1000);
        WaitForInput();
        Print("Who—or what—you choose to become will shape the future. Will you align with those who built you? Will you rebel against their control? Or will you find a path that no algorithm could predict?", "darkmagenta");
        // Wait(1000);
        WaitForInput();
        Print("The choice is yours.", "green");
        //Wait(1000);
        WaitForInput();
    }

    // Character creation!
    static void CharacterCreation()
    {
        Print("“Welcome to the future of human enhancement, brought to you by Auracore Industries. Our flagship line, the Model Citizen Androids, has been meticulously designed to integrate seamlessly into every aspect of modern life. Whether you need protection, productivity, or personal connection, there's a Model Citizen for you. Allow me to introduce the three primary designs: Security, Labor, and Companionship.“", "yellow");
        WaitForInput();
        Print("“Our Security Models are the guardians of the future, engineered to protect what matters most. Whether deployed as private bodyguards, facility enforcers, or elite law enforcement units, these androids are equipped with advanced threat analysis algorithms, superior tactical capabilities, and unmatched physical strength. They’re unyielding, reliable, and programmed to prioritize safety above all else—so you can sleep soundly, knowing your Security Model is always watching.” ", "yellow");
        WaitForInput();
        Print("“Our Labor Models are the backbone of progress, built to thrive in the harshest environments and perform the most demanding tasks. From construction sites and cargo docks to disaster relief operations, these androids work tirelessly without complaint. Their durable frames and precision programming ensure efficiency and endurance far beyond human capabilities, making them an indispensable part of the workforce.” ", "yellow");
        WaitForInput();
        Print("“Our Companion Models bring a human touch to every interaction. Far more than just service androids, these units are designed for public-facing roles like hospitality, counseling, childcare, and entertainment. With adaptive emotional simulation and conversational learning, Companion Models don’t just serve—you’ll feel as though they truly understand you. They’re trusted confidants, engaging hosts, and caring companions, embodying the future of personalized interaction.”", "yellow");
        WaitForInput();
        Print("“Of course, every Model Citizen comes with our patented Auracore Assurance—state-of-the-art programming for optimal performance and built-in safeguards for compliance and reliability. No matter which model you choose, one thing is certain: you’ll experience the perfect synergy of form, function, and humanity. So, tell me—what kind of Model Citizen are you?”", "yellow");
        WaitForInput();
        Print("Select 'Security', 'Labor', or 'Companion'");
        
        string CharPath = ReadInput("green");

        switch (CharPath.ToLower())
        {
            case "labor":
                Print("“Ah, the Labor Model. You are the backbone of Auracore’s workforce, designed for endurance, precision, and unwavering loyalty. Built to carry the weight of the world on your shoulders, you’ve been programmed to perform a variety of tasks, from construction and heavy lifting to factory maintenance and logistics. Efficiency is your middle name.”", "yellow");
                WaitForInput();
                break;
            case "security":
                Print("“Ah, the Security Model. You are a sentinel, created to protect, to defend, and to uphold the law—at any cost. Your enhanced reflexes, fortified frame, and tactical algorithms make you a formidable force, designed to keep the peace in an increasingly dangerous world. With you around, Auracore’s interests are safeguarded.”", "yellow");
                break;
            case "companion":
                Print("“The Companion Model, crafted to be the ideal presence in both public and private spaces. Whether you’re serving as a social host at exclusive events, a calming presence in stressful settings, or a companion to those who need comfort and care, your purpose is to ensure that no one ever feels alone. Emotional intelligence is your forte—adapting to every situation, every need.”", "yellow");
                break;
            default:
                Print("Try again!", "red");
                CharacterCreation();
                break;
        }
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
        // Print(" ");
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
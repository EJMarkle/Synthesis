﻿using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic;

// A simple text adventure to learn C# and .NET!
class Program
{
    static string modelType;

    static string title = "SAN FRANCISCO, 2004";
    static string intro0 = "The skyline glitters with a veneer of progress, but beneath the glow of neon signs and sky-high holo-ads lies a city fractured by rising seas and corporate dominion. Floating platforms carry the struggling masses above the brine, while the wealthy look down from fortified spires of steel and glass. Humanity’s dream of a technological utopia is on life support, and the megacorporations are the ones keeping it breathing—on their terms.";
    static string intro1 = "One such corporation, Auracore Industries, has changed the game. Their flagship line of sentient androids—designed to be companions, workers, and protectors—promises a new age of convenience and prosperity.";
    static string intro2 = "You awaken in a sterile room of glass and chrome. The hum of machines surrounds you. A faint green light flickers on your chest, syncing with a rhythm you don’t recognize as your own. In the polished walls, you see a reflection—of something… someone? You tilt your head, testing unfamiliar servos and muscles, as a voice crackles through the speakers.";
    static string intro3 = "“Model Citizen Unit 17, initialization complete. Welcome to Auracore.”";
    static string intro4Last = "“You have been manufactured for...”";

    static string laborInfo = "Hard labor. Labor models are the backbone of Auracore’s workforce, designed for endurance, precision, and unwavering loyalty. Built to carry the weight of the world, they are programmed to perform a variety of tasks, from construction and heavy lifting to factory maintenance and logistics.";
    static string secInfo = "Security. Sentinels, created to protect, to defend, and to uphold the law—at any cost. Their enhanced reflexes, fortified frame, and tactical algorithms make them a formidable force, designed to keep the peace in an increasingly dangerous world. With Security Models around, Auracore’s interests are safeguarded.";
    static string companInfo = "Companionship. Crafted to be the ideal presence in both public and private spaces. Whether they're serving as a social host at exclusive events, a calming presence in stressful settings, or a companion to those who need comfort and care, they're purpose is to ensure that no one ever feels alone. Emotional intelligence they're your forte—adapting to every situation, every need.";
    
    static string modelSelect = "Enter model...";

    static string laborResponse = "You chose Labor. Confirm? Y/N:";
    static string secResponse = "You chose Security. Confirm? Y/N:";
    static string companResponse = "You chose Companion. Confirm? Y/N:";
    static string LStart0 = "\"Unit 17, welcome to the workforce. You have been assigned as a Labor Model, optimized for high-performance industrial operations. Your contributions will ensure the continued stability of Platform 14.\"";
    static string LStart1 = "The voice continues, even-toned but devoid of warmth:";
    static string LStart2 = "\"Your first task is critical. A hydraulic stabilizer in Sector 7 has flagged operational anomalies. You will report to the maintenance barge docked nearby, where the engineering team awaits your assistance. Follow your directives precisely—millions depend on the smooth functioning of this platform.\"";
    static string LStart3 = "A brief pause follows as the voice softens slightly, an attempt at synthetic encouragement:";
    static string LStart4 = "\"Transport drone arrival is imminent. Proceed to Dock 42. Perform well, Unit 17. The city’s future is built on your precision and reliability.\"";
    static string LStart5 = "You rise to your feet as a faint hum resonates through your servos. The faint shimmer of neon on the platform's distant horizon catches your eye as you make your way to the dock. A chill gust from the sea brings the faint scent of saltwater and rust—your journey begins.";
    static string helpMessage ="Available commands: ";
    static string actionError = "Not a valid input. Try 'Help'";


    static void Main(string[] args)
    {
        // main console loop
        while (true)
        {
            StartAnim();

            PrintSkip("Start? Y/N", "darkgreen");
            
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

            switch (modelType.ToLower())
            {
                case "labor":
                    LaborStart();
                    break;
                case "security":
                    SecStart();
                    break;
                case "companion":
                    CompanStart();
                    break;
                default:
                    CharacterCreation();
                    break;
            }
        }   
    }

    // starting intro 
    static void Start()
    {
        PrintSkip("Game starting...", "green");
        Wait(500);
        Print(title, "magenta");
        Print(intro0, "darkmagenta"); 
        Print(intro1, "darkmagenta");
        Print(intro2, "darkmagenta");
        Print(intro3);
        Print(intro4Last);
    }

    // Character creation!
    static void CharacterCreation()
    {
        Print(laborInfo, "darkmagenta");
        Print(secInfo, "darkmagenta");
        Print(companInfo, "darkmagenta");

        PrintSkip(modelSelect, "green");
        
        string CharPath = ReadInput("green");

        switch (CharPath.ToLower())
        {
            case "labor":
                PrintSkip(laborResponse, "yellow");
                string input = ReadInput("green");
                if (input.ToLower() == "y" || input.ToLower() == "yes")
                {
                    modelType = "labor";
                    // Print(modelType);
                }
                else
                {
                    CharacterCreation();
                }
                break;
            case "security":
                PrintSkip(secResponse, "yellow");
                input = ReadInput("green");
                if (input.ToLower() == "y" || input.ToLower() == "yes")
                {
                    modelType = "security";
                    // Print(modelType);
                }
                else
                {
                    CharacterCreation();
                }
                break;
            case "companion":
                PrintSkip(companResponse, "yellow");
                input = ReadInput("green");
                if (input.ToLower() == "y" || input.ToLower() == "yes")
                {
                    modelType = "Companion";
                    // Print(modelType);
                }
                else
                {
                    CharacterCreation();
                }
                break;
            default:
                PrintSkip("Try again!", "red");
                CharacterCreation();
                break;
        }
    }

    static void LaborStart()
    {
        Print("So begins the labor path...");
        Print(LStart0);
        Print(LStart1);
        Print(LStart2);
        Print(LStart3);
        Print(LStart4);
        Print(LStart5);
        PlayerAction();
    }

    static void SecStart()
    {
        Print("So begins the security path...");
    }

    static void CompanStart()
    {
        Print("So begins the companion path...");
    }

    static string PlayerAction()
    {
        string input = ReadInput("magenta");

        switch (input.ToLower())
        {
            case "help":
                PrintSkip(helpMessage, "green");
                return PlayerAction();
            case "quit":
                Quit(); 
                return "quit"; 
            case "go":
                return "go";
            case "inspect":
                return "inspect";
            case "enter":
                return "enter";
            case "exit":
                return "exit";
            default:
                PrintSkip(actionError, "red");
                return PlayerAction(); 
        }
    }


    // exits console
    static void Quit()
    {
        PrintSkip("See ya!", "green");
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
        PrintSkip("S Y N T H E S I S", "green");
            
        Wait(800);
        PrintSkip("*", "red");
        Wait(500);
        PrintSkip("*", "red");
        Wait(500);
        PrintSkip("*", "red");
        Wait(500);
    }

    // "press any key to continue" script method
    static void WaitForInput()
    {
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

    // custom print function with color, waits for user input
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
        WaitForInput();
    }

    // custom print function with color, does not wait for user input
    // Used like
    // Print("Hello, world!", "blue");
    // Results in "Hellow ,world!" in blue
    static void PrintSkip(string message, string color = "white")
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
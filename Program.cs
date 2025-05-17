using System;
using System.Diagnostics;
using System.Threading;

class StopwatchProgram
{
    static Stopwatch stopwatch = new Stopwatch();
    static
        bool isRunning = false;

    static void Main()
    {
        int choice;

        
        
            Console.WriteLine("Welcome to this Stopwatch minigame!");
            Console.WriteLine("Your first task is to stop the time at 10 seconds but because its your first try you can have a 2 second differentation");
            Console.WriteLine("Good luck!", Console.ForegroundColor = ConsoleColor.DarkRed);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Stopwatch Menu:");
            Console.WriteLine("1. Start");
            Console.WriteLine("2. Stop");
            Console.WriteLine("3. Reset");
            Console.Write("Enter your choice (1-3): ");
        do
        { 
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {   case 1:
                        StartStopwatch();
                        break;
                    case 2:
                        StopStopwatch();
                        break;
                    case 3 :
                        ResetStopwatch();
                        break;                  
                    default:
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 4.", Console.ForegroundColor = ConsoleColor.DarkBlue);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.", Console.ForegroundColor = ConsoleColor.DarkBlue);
                Console.ForegroundColor = ConsoleColor.White;
            }

        } while (true);
        
    }
    
    static void StartStopwatch()
    {
        if (!isRunning)
        {
            stopwatch.Start();
            isRunning = true;
            Console.WriteLine("Stopwatch started.", Console.ForegroundColor = ConsoleColor.Green);
            Console.ForegroundColor= ConsoleColor.White;
        }
        else
        {
            Console.WriteLine("Stopwatch is already running.", Console.ForegroundColor = ConsoleColor.DarkBlue);
            Console.ForegroundColor= ConsoleColor.White;
        }
    }

    static void StopStopwatch()
    {
        if (isRunning)
        {
            stopwatch.Stop();
            isRunning = false;
            Console.WriteLine("Stopwatch stopped. Elapsed time: " + stopwatch.Elapsed, Console.ForegroundColor = ConsoleColor.Green);
            Console.ForegroundColor= ConsoleColor.White;
        }
        else
        {
            Console.WriteLine("Stopwatch is not running.", Console.ForegroundColor = ConsoleColor.DarkBlue);
            Console.ForegroundColor= ConsoleColor.White;
        }
    }

    static void ResetStopwatch()
    {
        stopwatch.Reset();
        isRunning = false;
        Console.WriteLine("Stopwatch reset.", Console.ForegroundColor = ConsoleColor.Green);
        Console.ForegroundColor= ConsoleColor.White;
        
    }
}
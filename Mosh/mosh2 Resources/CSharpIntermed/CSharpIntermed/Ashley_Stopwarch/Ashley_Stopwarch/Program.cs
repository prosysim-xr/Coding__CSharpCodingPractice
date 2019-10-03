using System;

namespace Ashley_Stopwarch
{
    class Program
    {
        static void Main(string[] args)
        {
            bool timerShouldEnd = false;

            Console.Write("Please enter a name for your timer:  ");
            var stopwatch = new Stopwatch(Console.ReadLine());
            stopwatch.Instructions();

            while (timerShouldEnd != true)
            {
                ConsoleKeyInfo currentKey = Console.ReadKey(true);
                switch (currentKey.Key)
                {
                    case ConsoleKey.Enter:
                        try
                        {
                            stopwatch.Start();
                        }
                        catch (Exception alreadyRunning)
                        {
                            Console.WriteLine(alreadyRunning.Message);
                        }
                        break;
                    case ConsoleKey.Spacebar:
                        stopwatch.Toggle();
                        break;
                    case ConsoleKey.Escape:
                        stopwatch.Stop();
                        timerShouldEnd = true;
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}

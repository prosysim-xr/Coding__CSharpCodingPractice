using System;

namespace Marco_Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {

            var stopWatch = new StopWatch();

            while (true)
            {
                Console.WriteLine("Press 'Enter' to start the count, then 'Enter' again to stop it and display the duration of the count.");

                if (Console.ReadKey().Key != ConsoleKey.Enter)
                {
                    Console.WriteLine("The key input is invalid.");
                    continue;
                }
                else
                {
                    stopWatch.Start();
                    Console.WriteLine("Your count started");
                }

                while (Console.ReadKey().Key != ConsoleKey.Enter)
                {
                    Console.WriteLine("The key input is invalid.");
                }
                
                Console.WriteLine($"The duration of you count was: {stopWatch.Stop().ToString()}");
            }

        }

    }

}

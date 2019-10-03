using System;

namespace FilipeStopwatch
{
    class Program
    {
        private static Stopwatch stopwatch;

        static void Main(string[] args)
        {
            int option;
            do
            {
                stopwatch = new Stopwatch();
                Lap.Reset();
                bool answer;
                do
                {
                    Console.WriteLine("1. Start StopWatch");
                    Console.WriteLine("0. Exit");
                    answer = int.TryParse(Console.ReadLine(), out option);
                    if (!answer)
                        Console.WriteLine("Please provide a valid option");
                } while (!answer);

                if (option == 1)
                    StartStopwatch();

            } while (option != 0);
        }

        static void StartStopwatch()
        {
            Console.WriteLine("Stopwatch started");
            Console.WriteLine($"{stopwatch.Start()}");
            int option;
            do
            {

                Console.WriteLine("1. Lap");
                Console.WriteLine("2. Stop stopwatch");
                bool answer = int.TryParse(Console.ReadLine(), out option);
                if (!answer)
                    Console.WriteLine("Please provide a valid option");
                if (option == 1 || option == 2)
                {
                    switch (option)
                    {
                        case 1:
                            stopwatch.MakeLap();
                            break;
                        case 2:
                            stopwatch.Stop();
                            break;
                    }
                }

                stopwatch.DisplayLaps();

            } while (option != 2);
        }
    }
}

using System;

namespace Jacob_Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("----------- Welcome. This is a Stopwatch application!! ------------");
            Console.WriteLine("-------------------------------------------------------------------");

            do
            {
                Console.WriteLine("Please type 'start' and hit enter or return to start the Stopwatch.");
                stopwatch.Start();

                Console.WriteLine("Please type 'stop' and hit enter or return to stop the Stopwatch.");
                stopwatch.Stop();

                stopwatch.DisplayTime(stopwatch.StartTime, stopwatch.StopTime);

            } while (stopwatch.Command == "run");
        }
    }
}

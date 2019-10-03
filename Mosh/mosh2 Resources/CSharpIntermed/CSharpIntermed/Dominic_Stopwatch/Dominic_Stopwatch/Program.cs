using System;

namespace Dominic_Stopwatch
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            while (true)
            {
                Console.Write("Type 'Start' to start the stopwatch or type 'Stop' to stop it: ");

                var input = Console.ReadLine();

                if (input == "Start")
                {
                    stopwatch.Start(DateTime.Now);
                }

                else if (input == "Stop")
                {
                    stopwatch.Stop(DateTime.Now);
                    Console.WriteLine("The duration between Start and Stop was " + stopwatch.Duration);
                }

            }
        }
    }
}
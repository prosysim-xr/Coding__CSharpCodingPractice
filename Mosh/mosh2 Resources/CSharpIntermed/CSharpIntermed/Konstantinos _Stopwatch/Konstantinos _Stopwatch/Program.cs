using System;
using Konstantinos__Stopwatch;
using stopwatch;

namespace stopwatch
{
    class Program
    {

        static void Main(string[] args)
        {

            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("********** StopWatch **************");
            Console.WriteLine("1. START 3.EXIT");
            int Choice = 0;
            Choice = Convert.ToInt32(Console.ReadLine());
            while (Choice != 3)
            {
                if (Choice == 1) stopwatch.Start();
                if (Choice == 2) stopwatch.Stop();
                Choice = Convert.ToInt32(Console.ReadLine());

            }
        }
    }
}

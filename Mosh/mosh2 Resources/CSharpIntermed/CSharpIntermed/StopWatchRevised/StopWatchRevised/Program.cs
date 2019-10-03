using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace StopWatchRevised
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new StopWatch();

            for (var i = 0; i < 2; i++)
            {
                stopwatch.Start();

                
                Thread.Sleep(1000);
                

                //stopwatch.Start();

                stopwatch.Stop();


                Console.WriteLine("Duration :" + stopwatch.GetInterval());
                Console.WriteLine("Press Enter to run the stopwatch one more time.");
                Console.ReadLine();
            }


        }
    }

    public class StopWatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _running;

        public void Start()
        {
            if (_running)
            {
                 throw new InvalidOperationException("Stopwatch is ALREADY running!");
            }
            _startTime = DateTime.Now;
            _running = true;

        }


        public void Stop()
        {
            if (!_running)
            {
                throw new InvalidOperationException("Stopwatch is NOT running!");
            }
            _endTime = DateTime.Now;
            _running = false;

        }

        public TimeSpan GetInterval()
        {
            return _endTime - _startTime;
        }


    }
}

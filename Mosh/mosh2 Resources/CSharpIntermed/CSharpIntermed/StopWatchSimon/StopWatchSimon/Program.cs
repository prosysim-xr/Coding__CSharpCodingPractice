using System;

namespace Stopwatch

{
    class Program
    {
        static void Main(string[] args)

        {
            StopWatch stopWatch = new StopWatch();
            DisplayMenu();

            while (true)
            {
                var cmd = Console.ReadLine();

                try
                {
                    switch (cmd)
                    {
                        case "1":
                            stopWatch.Start();
                            Console.Clear();
                            DisplayMenu();

                            Console.WriteLine("Clock is running.........");

                            break;

                        case "2":
                            stopWatch.Stop();
                            Console.Clear();
                            DisplayMenu();
                            Console.WriteLine("Clock stopped after...");

                            Console.WriteLine(stopWatch._duration.ToString());

                            break;

                        default:
                            return;

                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        }

        private static void DisplayMenu()
        {
            Console.WriteLine("Stop Watch Program");
            Console.WriteLine("1 = Start, 2 = Stop, 3 = Exit");
        }

    }

    class StopWatch
    {
        private  DateTime _startTime;
        private DateTime _stopTime;
        public TimeSpan _duration;

        public StopWatch()
        {
            _startTime = default(DateTime);
            _stopTime = default(DateTime);
        }

        public void Start()
        {
            if (_startTime.Ticks != 0)
            {
                throw new InvalidOperationException("Stopwatch is already running!");
            }

            _startTime = DateTime.Now;
        }

        public void Stop()
        {
            _stopTime = DateTime.Now;

            if (_startTime.Ticks == 0)
            {
                throw new InvalidOperationException("Stopwatch must be started first!");
            }

            _duration = _stopTime - _startTime;
            _startTime = default(DateTime);
            _stopTime = default(DateTime);
        }

    }

}

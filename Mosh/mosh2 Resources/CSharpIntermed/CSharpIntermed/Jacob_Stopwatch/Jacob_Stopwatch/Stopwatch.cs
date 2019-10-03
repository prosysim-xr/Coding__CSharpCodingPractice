using System;
using System.Collections.Generic;
using System.Text;

namespace Jacob_Stopwatch
{
    class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private DateTime _duration;
        private string _command;

        public DateTime StartTime { get; set; }
        public DateTime StopTime { get; set; }
        public DateTime Duration { get; set; }
        public string Command { get; set; }

        public void Start()
        {
            _command = Console.ReadLine();

            while (_command != "start" && _command != "Start" && _command != "START")
            {
                Console.WriteLine("OOPS! Please type 'start' to start the timer.");
                _command = Console.ReadLine();
            }
            _startTime = DateTime.Now;
            StartTime = _startTime;
        }

        public void Stop()
        {
            _command = Console.ReadLine();

            while (_command != "stop" && _command != "Stop" && _command != "STOP")
            {
                Console.WriteLine("OOPS! Please type 'stop' to stop the timer.");
                _command = Console.ReadLine();
            }
            _stopTime = DateTime.Now;
            StopTime = _stopTime;
        }

        public void DisplayTime(DateTime start, DateTime stop)
        {
            TimeSpan _duration = stop - start;
            TimeSpan Duration = _duration;
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("--------------- THE TOTAL DURATION WAS: {0} SECONDS -----------------", Duration.Seconds);
            Console.WriteLine("-------------------------------------------------------------------");

            Console.WriteLine("Please type 'run' and hit enter or return to start the Stopwatch program again.");
            Console.WriteLine("If you're done using the Stopwatch hit enter or return to quit the application.");
            _command = Console.ReadLine();
            Command = _command;
        }
    }
}

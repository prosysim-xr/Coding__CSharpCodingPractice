using System;
using System.Collections.Generic;
using System.Text;

namespace Ashley_Stopwarch
{
    public class Stopwatch
    {
        private string Name { get; set; }
        private DateTime StartTime { get; set; }
        private DateTime EndTime { get; set; }
        private TimeSpan Duration => EndTime - StartTime;
        private bool isRunning = false;

        public Stopwatch(string name)
        {
            Name = name;
        }

        public void Instructions()
        {
            Console.WriteLine("\nPress the ENTER key to begin your timer.");
            Console.WriteLine("Use the SPACEBAR to pause or resume your timer.");
            Console.WriteLine("When finished, press ESC to end your timer.\n");
        }

        public void Start()
        {
            if (isRunning == false)
            {
                StartTime = DateTime.Now;
                Console.WriteLine($"\n{Name} has started.");
            }
            else
            {
                throw new System.InvalidOperationException("You cannot start a timer twice.");
            }
            isRunning = true;
        }

        public void Stop()
        {
            Console.WriteLine($"{Name} is stopped.");
            EndTime = DateTime.Now;
            isRunning = false;
            TimeElapsed();
        }

        public void Toggle()
        {
            if (isRunning == true)
                Stop();
            else
                Start();
        }

        private void TimeElapsed()
        {
            {
                Console.WriteLine($"{Name} has been running for {Math.Round(Duration.TotalSeconds)} seconds.\n");
            }
        }
    }
}

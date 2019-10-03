using System;
using System.Collections.Generic;
using System.Text;

namespace Konstantinos__Stopwatch
{
    public class Stopwatch
    {
        private DateTime _start = new DateTime();
        private DateTime _end = new DateTime();
        private bool _one = false;

        public void Start()
        {

            if (_one)
            {
                throw new InvalidOperationException("Stopwatch already started");
            }

            _start = DateTime.Now;
            Console.Write("Start       {0}", _start.ToString("hh:mm:ss:ml") + " Press 2 to stop the stopwatch...");
            _one = true;

        }

        public void Stop()
        {

            _end = DateTime.Now;
            Console.WriteLine("Stop at     {0} ", _end.ToString("hh:mm:ss:ml"));
            TimeSpan duration = new TimeSpan();
            duration = _end - _start;
            Console.WriteLine("Difference: {0}{1}:{2}:{3}", duration.Hours.ToString(), duration.Minutes.ToString(), duration.Seconds.ToString(), duration.Milliseconds.ToString());
            _one = false;
            Console.WriteLine("1. START  3.EXIT");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Dominic_Stopwatch
{
    class Stopwatch
    {
        private bool _ticking;
        public DateTime StartTime { get; set; }
        public DateTime StopTime { get; set; }
        public TimeSpan Duration

        {
            get
            {
                var span = StopTime - StartTime;
                return span;

            }
        }

        public void Start(DateTime startTime)
        {
            if (_ticking == false)
            {
                StartTime = startTime;
                _ticking = true;
            }
            else
            {
                throw new InvalidOperationException("Stopwatch is already ticking.");
            }
        }
        
        public void Stop(DateTime stopTime)
        {
            if (_ticking == true)
            {
                StopTime = stopTime;
                _ticking = false;
            }
            else
            {
                throw new InvalidOperationException("Stopwatch has not yet started ticking.");
            }
        }
    }
}

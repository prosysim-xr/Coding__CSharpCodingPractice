using System;

namespace Marco_Stopwatch
{
    public class StopWatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private TimeSpan _duration;

        public void Start()
        {
            _startTime = DateTime.Now;
        }

        public TimeSpan Stop()
        {
            _stopTime = DateTime.Now;
            _duration = _stopTime - _startTime;
            return _duration;
        }

    }
}

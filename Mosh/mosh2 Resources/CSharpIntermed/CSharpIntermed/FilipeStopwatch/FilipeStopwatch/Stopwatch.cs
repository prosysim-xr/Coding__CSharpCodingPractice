using System;
using System.Collections.Generic;
using System.Text;

namespace FilipeStopwatch
{
    class Stopwatch
    {
        private bool _isActivated;
        public Lap Lap { get; set; }
        private readonly List<Lap> laps;

        public Stopwatch()
        {
            this.laps = new List<Lap>();

        }

        public TimeSpan Start()
        {
            if (_isActivated)
                throw new InvalidOperationException("The stopwatch has already started");
            _isActivated = true;
            DateTime temp = DateTime.Now;
            Lap = new Lap
            {
                Start = temp,
            };
            return temp.TimeOfDay;
        }

        public void Stop()
        {
            if (!_isActivated)
                throw new InvalidOperationException("The stopwatch has not started yet");
            _isActivated = false;
            Lap.Stop = DateTime.Now;
            Lap.LapDuration();
            laps.Add(Lap);
        }

        public void MakeLap()
        {
            Stop();
            Start();
        }

        public void DisplayLaps()
        {
            foreach (var lap in laps)
            {
                Console.WriteLine(lap);
            }
        }
    }
}

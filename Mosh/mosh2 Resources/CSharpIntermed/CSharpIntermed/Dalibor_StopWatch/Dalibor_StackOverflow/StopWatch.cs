using System;

namespace Dalibor_StopWatch
{
    public class StopWatch
    {
        public DateTime AtStartTime { get; private set; }
        public TimeSpan PassedTimeSpan { get; private set; }
        private bool IsStopWatchRunning { get; set; }
 
        public void Start()
        {
            if (!IsStopWatchRunning)
            {
                AtStartTime = DateTime.Now;
                IsStopWatchRunning = true;
            }
            else
            {
                throw new InvalidOperationException("Stopwatch already started!");
            }
        }
 
        public void Stop()
        {
            PassedTimeSpan = DateTime.Now - AtStartTime;
        }
 
    }
}

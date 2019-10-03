using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh2Asg1_Class_Propertes_exer_StopWatch_Blog
{
    class StopWatch_mosh_wrong_way
    {
        //below 3 lines are for state of stopwatch
        //but consumers in program class should not mess up 
        public DateTime P_startTime { get; set; }
        public DateTime P_endTime { get; set; }
        private bool _running = false;

        public void Start(DateTime start)
        {
            if (!_running)
            {
                P_startTime = start;
                _running = true;
            }
            else
            {
                throw new InvalidOperationException("Stopwatch is already running");
            }
        }
        public void Stop(DateTime stop)
        {
            if (_running)
            {
                P_endTime = stop;
                _running = false;
            }
            else
            {
                throw new InvalidOperationException("Stopwatch is already running");
            }
        }
        public TimeSpan GetInterval()
        {
            var duration = P_endTime - P_startTime;
            return duration;
        }


    }
}

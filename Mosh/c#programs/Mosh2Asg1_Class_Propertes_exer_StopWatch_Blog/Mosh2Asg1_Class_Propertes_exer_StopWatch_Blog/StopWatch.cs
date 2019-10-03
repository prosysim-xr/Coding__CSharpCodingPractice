using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh2Asg1_Class_Propertes_exer_StopWatch_Blog
{
    class StopWatch
    {
        
        public DateTime P_startTime { get; set; }
        private DateTime _stopTime;
        public DateTime P_stopTime
        {
            get { return _stopTime; }
            set { _stopTime = value; }
        }

        public StopWatch() { }
        public StopWatch(DateTime _startTime, DateTime _stopTime)
        {
            this.P_startTime = _startTime;
            this.P_stopTime = _stopTime;
        }

        public void Start()
        {
            P_startTime = DateTime.Now;
        }

        public void Stop()
        {
            P_stopTime = DateTime.Now;

        }

        public int Duration()
        {
            var duration = P_stopTime.Second - P_startTime.Second;
            return duration;
        }
    }
}

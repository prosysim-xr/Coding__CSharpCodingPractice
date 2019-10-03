using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh2Asg1_Class_Propertes_exer_StopWatch_Blog
{
    class StopWatch_mosh_correct_way
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _running = false;

        public void Start(DateTime start)
        {
            //usually validataion should be at the start to easy code resuability
            if (_running)
            {
                throw new InvalidOperationException("Stopwatch is already running");
            }
            //no need of else
            _startTime = start;
            _running = true;

        }
        public void Stop(DateTime stop)
        {
            if (!_running)
            {
                throw new InvalidOperationException("Stopwatch is not running");       
            }
            _endTime = stop;
            _running = false;
        }
        public TimeSpan GetInterval()
        {
            return _endTime - _startTime;
        }


    }
}

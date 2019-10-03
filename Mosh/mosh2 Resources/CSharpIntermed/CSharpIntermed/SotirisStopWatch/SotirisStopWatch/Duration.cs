using System;
using System.Collections.Generic;
using System.Text;

namespace SotirisStopWatch
{
    class Duration

    {

        private DateTime _startingWatch;

        private DateTime _stopingWatch;

        private TimeSpan _timeSpan;

        public DateTime Start

        {

            get

            {

                return _startingWatch;

            }

            set

            {

                _startingWatch = value;

            }

        }

        public DateTime Stop

        {

            get

            {

                return _stopingWatch;

            }

            set

            {

                _stopingWatch = value;

            }

        }

        public void calculateDuration()

        {



            _timeSpan = TimeSpan.Zero;

            _timeSpan = _stopingWatch.Subtract(_startingWatch);

            Console.WriteLine("The duration was: " + _timeSpan.Seconds);



        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosh_1_Asg1_1
{
    class SpeedLimit
    {
        private int speedLimit;
        private int speed;

        public int PspeedLimit
        {
            get { return speedLimit; }
            set { speedLimit = value; }
        }

        public int Pspeed
        {
            get { return speed; }
            set { speed = value; }
        }



        public void AnalyzeSpeed(int speed, int speedLimit)
        {
            if(speed<speedLimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                var point = (speed - speedLimit) / 5;

                if(point>=12)
                {
                    Console.WriteLine("\nthe liscence is suspended");
                }
                else
                {
                    Console.WriteLine($"\ndemerit points is {point}");
                }
            }

        }

    }
}

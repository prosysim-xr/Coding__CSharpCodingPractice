using System;
using System.Collections.Generic;
using System.Text;

namespace FilipeStopwatch
{
    class Lap
    {
        public static int InstanceId { get; set; }
        public int LapNumber { get; set; }
        public DateTime Start { get; set; }
        public DateTime Stop { get; set; }
        public TimeSpan Duration;

        public Lap()
        {
            InstanceId++;
            LapNumber = InstanceId;
        }

        public void LapDuration()
        {
            Duration = Stop - Start;

        }

        public override string ToString()
        {
            return String.Format($"Lap {LapNumber}: {Start.TimeOfDay} - {Stop.TimeOfDay} - {Duration}");
        }

        public static void Reset()
        {
            InstanceId = 0;
        }
    }
}

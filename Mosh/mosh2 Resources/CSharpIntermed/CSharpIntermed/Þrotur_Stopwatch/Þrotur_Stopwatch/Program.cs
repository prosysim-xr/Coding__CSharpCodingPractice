using System;

namespace Þrotur_Stopwatch
{
    class Program
    {
        private static void Main(string[] args)
        {
            var Stopwatch = new Stopwatch();
            Stopwatch.Start();
            Stopwatch.Stop();
            Console.WriteLine(Stopwatch.GetDurationTimeSpan());
        }
    }

    public class Stopwatch
    {
        private TimeSpan timespan;
        private DateTime start;
        private DateTime stop;
        private Boolean isActivated;

        public Stopwatch()
        {
            isActivated = false;
        }

        public DateTime Stop()
        {
            isActivated = false;
            return stop = DateTime.Now;
        }

        public DateTime Start()
        {
            if (isActivated == false)
            {
                isActivated = true;
                return start = DateTime.Now;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public TimeSpan GetDurationTimeSpan()
        {
            return timespan = stop - start;
        }
    }
}

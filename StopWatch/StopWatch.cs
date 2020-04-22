using System;

namespace StopWatch
{
    public class StopWatch
    {
        public DateTime StartTime { get; set; }

        public DateTime StopTime { get; set; }
        //public DateTime TimeSpan { get; private set; }
        public bool MeasurementStarted { get; set; } = false;


        public void Start()
        {
            if (this.MeasurementStarted == true) 
                throw new InvalidOperationException();

            StartTime = DateTime.Now;
            this.MeasurementStarted = true;
            Console.WriteLine("Start:\t\t{0}",DateTime.Now);
        }
        public void Stop()
        {
            this.MeasurementStarted = false;
            StopTime = DateTime.Now;
            Console.WriteLine("Stop:\t\t{0}", DateTime.Now);
            Console.WriteLine(" Duration:\t{0:N3} seconds",CalculateTimeSpan(StartTime, StopTime));
            Console.WriteLine();
        }

        private double CalculateTimeSpan(DateTime start, DateTime stop)
        {
            TimeSpan duration = stop.Subtract(start);
            return duration.TotalSeconds;
        }
    }
}

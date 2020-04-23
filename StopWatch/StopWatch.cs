using System;

namespace StopWatch
{
    public class StopWatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        public bool MeasurementStarted { get; private set; }


        public void Start()
        {
            if (this.MeasurementStarted == true) 
                throw new InvalidOperationException();

            _startTime = DateTime.Now;
            this.MeasurementStarted = true;
            Console.WriteLine("Start:\t\t{0}",DateTime.Now);
        }
        public void Stop()
        {
            this.MeasurementStarted = false;
            _stopTime = DateTime.Now;
            Console.WriteLine("Stop:\t\t{0}", DateTime.Now);
            Console.WriteLine(" Duration:\t{0:N3} seconds",CalculateTimeSpan(_startTime, _stopTime));
            Console.WriteLine();
        }

        private double CalculateTimeSpan(DateTime start, DateTime stop)
        {
            return stop.Subtract(start).TotalSeconds;
        }
    }
}

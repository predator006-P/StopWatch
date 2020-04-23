using System;

namespace StopWatch
{

    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new StopWatch();

            Console.WriteLine("This is a StopWatch application");
            Console.WriteLine("Press 'space' to start and stop, 'ESC to quit'");
            Console.WriteLine();

            while ((Console.ReadKey().Key != ConsoleKey.Escape) || (Console.ReadKey().Key == ConsoleKey.Spacebar))
            {
                if (stopwatch.MeasurementStarted == false)
                    stopwatch.Start();
                else
                    stopwatch.Stop();
            }
        }
    }
}

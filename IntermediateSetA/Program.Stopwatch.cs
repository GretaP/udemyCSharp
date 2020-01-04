using System;

namespace IntermediateSet1
{
    partial class Program
    {
        public class Stopwatch
        {
            private DateTime _begin = default;
            private DateTime _end = default;

            public void Start()
            {
                //Checks if user has already started the stopwatch, otherwise starts
                try
                {
                    if ((_begin) != default) throw new InvalidOperationException("Stopwatch already running: Please stop the stopwatch or type reset to reset it");
                    _begin = DateTime.Now;
                    Console.WriteLine("Stopwatch is starting");
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            public void Stop()
            {
                try
                {
                    //Checks if user has already started the stopwatch, if not does not stop.  Otherwise stops and prints duration
                    //Duration is type TimeSpan
                    if ((_begin) == default) throw new InvalidOperationException("Stopwatch not running: Please start the stopwatch");
                    _end = DateTime.Now;
                    Console.WriteLine("Stopwatch stopped.");
                    var duration = _end - _begin;
                    Console.WriteLine($"Stopwatch was on for {duration}. \n(Note: duration is of type: {duration.GetType()})");
                    _begin = default;
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            public void Reset()
            {
                _begin = default;
                Console.WriteLine("Stopwatch reset");
            }
        }
    }
}
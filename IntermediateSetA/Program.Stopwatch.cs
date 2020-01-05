/*Design a class called Stopwatch.The job of this class is to simulate a stopwatch.It should
provide two methods: Start and Stop.We call the start method first, and the stop method next.
Then we ask the stopwatch about the duration between start and stop. Duration should be a
value in TimeSpan.Display the duration on the console.
We should also be able to use a stopwatch multiple times.So we may start and stop it and then
start and stop it again. Make sure the duration value each time is calculated properly.
We should not be able to start a stopwatch twice in a row (because that may overwrite the initial
start time). So the class should throw an InvalidOperationException if its started twice.

Educational tip: The aim of this exercise is to make you understand that a class should be
always in a valid state.We use encapsulation and information hiding to achieve that.The class
should not reveal its implementation detail.It only reveals a little bit, like a blackbox.From the
outside, you should not be able to misuse a class because you shouldn’t be able to see the
implementation detail.*/

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
using System;

namespace IntermediateSet1
{
    partial class Program
    {
        public static void Main(string[] args)
        {
            //starts a stopwatch program
            var stopwatch = new Stopwatch();
            Console.WriteLine("Welcome to this simple stopwatch. \nType start to start or stop to stop the stopwatch. \nCheers\n");
            while (true)
            {
                var input = Console.ReadLine()?.ToLower();
                switch (input)
                {
                    case "start": 
                        stopwatch.Start();
                        break;
                    case "stop": 
                        stopwatch.Stop();
                        break;
                    case "reset":
                        stopwatch.Reset();
                        break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Your input was invalid.  type start or stop to use the stopwatch");
                        break;
                }
            }
            //end of stopwatch program

        }
    }
}

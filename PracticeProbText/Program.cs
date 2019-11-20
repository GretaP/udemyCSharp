using System;

namespace PracticeProbText
{
    class Program
    {
        static void Main(string[] args)
        {
            // WORKING WITH TEXT

            //1 - Write a program and ask the user to enter a few numbers separated by a hyphen.
            //Work out if the numbers are consecutive.
            //example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

            Console.WriteLine("Input numbers in the format x-x-x-x, and the program will tell you if they are consecutive (increasing/decreasing by 1 at a time) or not");
            var input = Console.ReadLine();
            //const string input = "5-6-5-8-9";
            Console.WriteLine($"Your input is a set of {(ConsecutiveCheck(input) ? "consecutive" : "non-consecutive")} numbers");

            //2 - Write a program and ask the user to enter a few numbers separated by a hyphen.
            //If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates.
            //If so, display "Duplicate" on the console.


        }

        public static int[] HyphenStringtoIntArray(string x)
        {
            return Array.ConvertAll(x.Split("-"), int.Parse);
        }

        public static bool ConsecutiveCheck(string input)
        { 
            //returns true if string input in format #-#-#-# is consecutive
            var num = Array.ConvertAll(input.Split("-"), int.Parse);
            var increment = (num[0] < num[1]) ? 1 : -1;
            for (var i = 0; i < num.Length-1; i++)
            {
                if (num[i] + increment != num[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

    }
}

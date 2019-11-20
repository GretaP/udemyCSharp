using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Practice_problems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Input a # between 1 and 10: ");
            //var answer = Convert.ToInt64(Console.ReadLine());
            //Console.WriteLine("Your input was: {0}", answer);
            //if (0 < answer && answer <11) { Console.WriteLine("Bingo"); }
            //else Console.WriteLine("You don't follow instructions");

            //< summary >
            //Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
            //Display the result on the console.
            //</ summary >
            //int count = 0;
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 3 == 0) count++;
            //}
            //Console.WriteLine(count);

            /*2- Write a program and continuously ask the user to enter a number or "ok" to exit. 
             * Calculate the sum of all the previously entered numbers and display it on the console.*/

            //var sums = 0;
            //while (true) {
            //    Console.WriteLine("ok to exit, or enter a number to be added");
            //    var entry = Console.ReadLine();
            //    if (entry == "ok") break;
            //    sums += int.Parse(entry);
            //}
            //Console.WriteLine(sums);


            /*2- Write a program and ask the user to enter their name. 
             * Use an array to reverse the name and then store the result in a new string. 
             * Display the reversed name on the console.*/

            //Console.WriteLine("Enter your name");
            //var name = Console.ReadLine().ToCharArray();
            //Array.Reverse(name);
            //string answer = new string(name);
            //Console.WriteLine(answer);


            // WORKING WITH TEXT

            //1 - Write a program and ask the user to enter a few numbers separated by a hyphen.
            //Work out if the numbers are consecutive.
            //example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

            const string input = "5-6-5-8-9";
            var num = Array.ConvertAll(input.Split("-"), int.Parse);
            foreach (var n in num)
            {
                Console.WriteLine(n);
                Console.WriteLine(n.GetType());
            }

            var increment = (num[0] < num[1]) ? 1 : -1;
            var consecutive = true;

            Console.WriteLine(num.Length);
            for (var i = 0; i < num.Length-2; i++)
            {
                if (num[i]+increment != num[i+1])
                {
                    consecutive = false;
                    break;
                }
            }
            Console.Write(consecutive);


        }
    }
}

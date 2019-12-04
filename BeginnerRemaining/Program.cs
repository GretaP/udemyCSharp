using System;
using System.IO;
using System.Linq; //<-- for OrderBy Descending, which uses Linq

namespace BeginnerRemaining
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1- Write a program that reads a text file and displays the number of words.*/
            var readText = File.ReadAllText(@"C:\Users\greta\Desktop\stepsCW.txt");
            string[] words = readText.Split(' '); 
            Console.WriteLine(words.Length);

            //2- Write a program that reads a text file and displays the longest word in the file.
            //a: with counter
            var counter = 0;
            foreach (var word in words)
            {
                if (word.Length > counter) counter = word.Length;
            }
            Console.WriteLine(counter);

            //Linq version:     var counter = words.Select(word => word.Length).Concat(new[] {0}).Max();


            //b with ordering
            var answer = words.OrderByDescending(n =>n.Length).First().Length;
            Console.WriteLine("The longest word using Linq/Order: " +answer);
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace PracticeProbText
{
    class Program
    {
        /// <summary>
        /// Working with Text: Udemy Exercises.  Inputs do not need to be validated
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Exercise1();
            //Exercise2();
            Exercise3();
            //Exercise4();
            //Exercise5();
        }

        //1 - Write a program and ask the user to enter a few numbers separated by a hyphen.
        //Work out if the numbers are consecutive.
        //example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
        /// <summary>
        /// Input numbers in the format x-x-x-x, and the program will tell you if they are consecutive (increasing/decreasing by 1 at a time) or not
        /// </summary>
        public static void Exercise1()
        {
            Console.WriteLine("Input numbers in the format x-x-x-x, and the program will tell you if they are consecutive (increasing/decreasing by 1 at a time) or not");
            var input = Console.ReadLine();
            //const string input = "5-6-5-8-9";
            Console.WriteLine($"Your input is a set of {(ConsecutiveCheck(input) ? "consecutive" : "non-consecutive")} numbers");
        }


        /* 2 - Write a program and ask the user to enter a few numbers separated by a hyphen.
        If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates
        If so, display "Duplicate" on the console. */
        /// <summary>
        /// Input numbers in the format x-x-x-x, and program will check to see if there are duplicates.
        /// </summary>
        public static void Exercise2()
        {

            Console.WriteLine("Input numbers in the format x-x-x-x, and program will check to see if there are duplicates");
            var duplicateInput = Console.ReadLine();
            if (string.IsNullOrEmpty(duplicateInput)) Environment.Exit(-1);
            DuplicateCheck(duplicateInput);
        }

        /* 3. Write a program and ask the user to enter a time value in the 24 - hour time format(e.g. 19:00).
        A valid time should be between 00:00 and 23:59.
        If the time is valid, display "Ok"; otherwise, display "Invalid Time".
        If the user doesn't provide any values, consider it as invalid time.*/
        public static void Exercise3()
        {
            Console.WriteLine("Enter a valid time between 00:00 and 23:59.  This will tell you if it is formatted properly or not");
            var input = Console.ReadLine();
            Console.WriteLine(TimeValidation(input) ? "Ok" : "Invalid Time");

        }

        /// <summary>
        /// Takes an entered string and returns true if it is a time in ##:## format between 00:00 and 23:59
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool TimeValidation(string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            var parts = s.Split(":");
            if (parts.Length != 2) return false;
            if (parts.Any(p => p.Length != 2)) return false;
            //foreach (var p in parts)
            //{
            //    if (p.Length != 2) return false;
            //}

            try
            {
                var hours = int.Parse(parts[0]);
                var minutes = int.Parse(parts[1]);
                if (minutes < 0 || minutes > 59) return false ;
                if (hours <0 || hours >24) return false;
            }
            catch
            {
                return false;
            }
            return true;
        }


        // Write a program and ask the user to enter a few words separated by a space. Use the words to 
        // create a variable name with PascalCase convention. For example, if the user types:
        // "number of students", display "NumberOfStudents". Make sure the program is not dependent on 
        // the casing of the input. So if the input is "NUMBER OF STUDENTS", it should still display 
        // "NumberOfStudents". If the user doesn't supply any words, display "Error".
        public static void Exercise4()
        {
            Console.WriteLine("enter a string, and I will pascal case it");
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Error - you didn't type anything");
                return;
            }
            var pascalCase = "";
            var words = input.Split(' ');
            foreach (var w in words)
            {
                var pascalWord = Char.ToUpper(w[0]) + w.ToLower().Substring(1);
                pascalCase += pascalWord;

            }
            //To learn for later:
            //var pascalCase = words.Select(w => Char.ToUpper(w[0]) + w.ToLower().Substring(1)).Aggregate("", (current, pascalWord) => current + pascalWord);
            Console.WriteLine(pascalCase);
        }


        //5 - Write a program and ask the user to enter an English word.
        //Count the number of vowels(a, e, o, u, i) in the word.
        //So, if the user enters "inadequate", the program should display 6 on the console.
        public static void Exercise5()
        {
            Console.WriteLine("Enter and English word");
            var input = Console.ReadLine();
            var vowelCount = 0;
            if (string.IsNullOrEmpty(input)) Environment.Exit(-1);
            //next time take the input and put it to lower, rather than writing out all the vowels >.>
            List<string> vowels = new List<string> {"a", "e", "i", "o", "u", "A","E","I","O","U"};
            foreach (var n in input)
            {
                if (vowels.Contains(n.ToString())) vowelCount++; ;
                
            }
            Console.WriteLine("There are {0} vowels in {1}", vowelCount, input);
        }

        /// <summary>
        /// Takes string format #-#-#-# and turns it into an array of numbers
        /// </summary>
        /// <param name="x">this is moot</param>
        /// <returns></returns>
        public static int[] HyphenStringtoIntArray(string x)
        {
            return Array.ConvertAll(x.Split("-"), int.Parse);
        }

        /// <summary>
        /// Returns true if there are duplicates in a string of #-#-#-# format
        /// </summary>
        /// <param name="input"></param>
        public static void DuplicateCheck(string input)
        {
            var num = HyphenStringtoIntArray(input);
            Array.Sort(num);
            for (var i=0; i<num.Length-1; i++)
            {
                if (num[i] == num[i + 1])
                {
                    Console.WriteLine("Duplicate");
                    break;
                };
            }
        }

        /// <summary>
        /// returns true if string input in format #-#-#-# is consecutive
        /// </summary>
        /// <param name="input">String should be in format #-#-#-#</param>
        /// <returns></returns>
        public static bool ConsecutiveCheck(string input)
        { 
            var num = HyphenStringtoIntArray(input);
            var increment = (num[0] < num[1]) ? 1 : -1;
            for (var i = 0; i < num.Length-1; i++)
            {
                if (num[i] + increment != num[i + 1]) return false;
            }
            return true;
        }

    }
}
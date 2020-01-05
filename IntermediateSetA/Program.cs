/*Design a class called Post.This class models a StackOverflow post.It should have properties
for title, description and the date/time it was created.We should be able to up-vote or down-vote
a post.We should also be able to see the current vote value.In the main method, create a post,
up-vote and down-vote it a few times and then display the the current vote value.

In this exercise, you will learn that a StackOverflow post should provide methods for up-voting
and down-voting.You should not give the ability to set the Vote property from the outside,
because otherwise, you may accidentally change the votes of a class to 0 or to a random
number.And this is how we create bugs in our programs. The class should always protect its
state and hide its implementation detail. 

 Educational tip: The aim of this exercise is to help you understand that classes should
encapsulate data AND behaviour around that data. Many developers (even those with years of
experience) tend to create classes that are purely data containers, and other classes that are
purely behaviour (methods) providers. This is not object-oriented programming. This is
procedural programming. Such programs are very fragile. Making a change breaks many parts
of the code*/
using System;

namespace IntermediateSet1
{
    partial class Program
    {
        public class Post
        {
            //note: vars below are private by default, so the private keyword is not necessary
            private readonly string _title = string.Empty;
            private readonly string _description = string.Empty;
            private readonly DateTime _datetime = DateTime.Now;
            private int _voteValue = 0;

            public Post(string title)
            {
                _title = title;
            }

            public Post(string title, string description): this(title)
            {
                _description = description;
            }

/*            public void UpVote()
            {

            }

            public void DownVote()
            {

            }*/

            public int SeeVote()
            {
                Console.WriteLine(_voteValue);
                return _voteValue;
            }

            public void SeePost()
            {
                Console.WriteLine($"Title: {_title} \nDescription: {_description}\nDate/Time: {_datetime}\nVote Value: {_voteValue}");
            }
        }

        public static void Main(string[] args)
        {
            var newPost = new Post("hello", "of worlds.");
            newPost.SeePost();

            //starts a stopwatch program
//            var stopwatch = new Stopwatch();
//            Console.WriteLine("Welcome to this simple stopwatch. \nType start to start or stop to stop the stopwatch. \nCheers\n");
//            while (true)
//            {
//                var input = Console.ReadLine()?.ToLower();
//                switch (input)
//                {
//                    case "start": 
//                        stopwatch.Start();
//                        break;
//                    case "stop": 
//                        stopwatch.Stop();
//                        break;
//                    case "reset":
//                        stopwatch.Reset();
//                        break;
//                    case "exit":
//                        return;
//                    default:
//                        Console.WriteLine("Your input was invalid.  type start or stop to use the stopwatch");
//                        break;
//                }
//            }
            //end of stopwatch program

        }
    }
}

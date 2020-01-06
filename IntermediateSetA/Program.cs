namespace IntermediateSet1
{
    partial class Program
    {
        public static void Main(string[] args)
        {
            //Follows directions for Post program
            var newPost = new Post("hello", "of worlds.");
            newPost.SeePost();
            newPost.UpVote(3);
            newPost.SeeVote();
            newPost.DownVote();
            newPost.SeeVote();
            //End of Post section

            //Starts a stopwatch program
//            var stopwatch = new Stopwatch();
//            Console.WriteLine("Welcome to this simple stopwatch. \nType start to start or stop to stop the stopwatch. \nCheers\n");
//            while (true)
//            {
            //note: add .Trim(char to remove) to remove white spaces :) Best practice
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

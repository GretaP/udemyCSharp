using System;

namespace IntermediateInterfaces
{
    public interface IActivity
    {
        void Execute();
    }
    
    public class VideoUpload : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("We have uploaded the video");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var testing = new VideoUpload();
            testing.Execute();
        }
    }
}

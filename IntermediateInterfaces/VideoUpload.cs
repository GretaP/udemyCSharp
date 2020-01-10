using System;

namespace IntermediateInterfaces
{
    public class VideoUpload : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("We have uploaded the video");
        }
    }
}
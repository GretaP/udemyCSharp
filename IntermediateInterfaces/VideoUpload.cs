using System;

namespace IntermediateInterfaces
{

    /// <summary>
    /// mock Activity VideoUpload
    /// </summary>
    public class VideoUpload : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("We have uploaded the video");
        }
    }
}
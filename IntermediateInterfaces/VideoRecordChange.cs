using System;

namespace IntermediateInterfaces
{
    public class VideoRecordChange : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Status of video changed in Database to Processing");
        }
    }
}
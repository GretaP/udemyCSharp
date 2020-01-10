using System;

namespace IntermediateInterfaces
{
    /// <summary>
    /// Mock activitiy VideoRecordChange
    /// </summary>
    public class VideoRecordChange : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Status of video changed in Database to Processing");
        }
    }
}
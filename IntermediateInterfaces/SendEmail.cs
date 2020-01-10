using System;

namespace IntermediateInterfaces
{

    /// <summary>
    /// Mock activity SendEmail
    /// </summary>
    public class SendEmail : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sent an email");
        }
    }
}
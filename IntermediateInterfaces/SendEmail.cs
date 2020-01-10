using System;

namespace IntermediateInterfaces
{
    public class SendEmail : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sent an email");
        }
    }
}
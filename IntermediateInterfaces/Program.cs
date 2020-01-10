using System;
using System.Linq;

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

    public class SendEmail : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sent an email");
        }
    }

    public class VideoRecordChange : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Status of video changed in Database to Processing");
        }
    }

    /// <summary>
    /// Takes at least 1 parameter (activities).  Use Run() to iterate through the activities and Execute them in order.
    /// </summary>
    public class WorkflowEngine
    {
        private readonly IActivity[] _activityList;

        public WorkflowEngine(params IActivity[] list)
        {
            /*Refactored this using Linq Any.
            if (list.Length == 0) throw new InvalidOperationException();*/
            if (!list.Any()) throw new InvalidOperationException("You can not run a workload that is empty");
            _activityList = list; 
        }

        public void Run()
        {
            foreach (var activity in _activityList)
            {
                //Console.WriteLine(activity);
                activity.Execute();
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            var testing = new VideoUpload();

            try
            {
                var workflow1 = new WorkflowEngine(testing, new SendEmail(), new VideoRecordChange());
                workflow1.Run();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Operation aborted");
            }
        }
    }
}


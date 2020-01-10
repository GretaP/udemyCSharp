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

    public class WorkflowEngine
    {
        private readonly IActivity[] _activityList;

        public WorkflowEngine(params IActivity[] list)
        {
            if (list.Length == 0) throw new InvalidOperationException();
            _activityList = list; 
            //_activityList = list ?? throw new InvalidOperationException();
        }

        public void Run()
        {
            foreach (var activity in _activityList)
            {
                Console.WriteLine(activity);
                activity.Execute();
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            var testing = new VideoUpload();
            //testing.Execute();

            try
            {
                var workflow1 = new WorkflowEngine(testing);
                workflow1.Run();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e);
                throw;


            }
        }
    }
}


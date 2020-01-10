using System;
using System.Linq;

namespace IntermediateInterfaces
{
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
}
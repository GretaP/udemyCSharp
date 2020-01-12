using System;
using System.Collections.Generic;

namespace IntermediateInterfaces
{
    /// <summary>
    /// Adds activities to a Workflow list
    /// </summary>
    public class WorkFlowList
    {
        private readonly List<IActivity> _activityList = new List<IActivity>();

        public void Add(IActivity activity)
        {
            _activityList.Add(activity);
        }

/*        //for old implementation
        public void Add(params IActivity[] activity)
        {
            foreach (var activity1 in activity)
            {
                _activityList.Add(activity1);
            }
        }*/

        public IActivity[] GetWorkflow()
        {
            if (_activityList.Count == 0) throw new InvalidOperationException("Your workflow is empty.  Please add something to your workflow.");
            var array =_activityList.ToArray();
            return array;
        }
    }
}
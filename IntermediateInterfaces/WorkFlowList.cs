using System;
using System.Collections;
using System.Collections.Generic;

namespace IntermediateInterfaces
{
    /// <summary>
    /// Adds activities of type IActivity to an ArrayList, and GetWorkflow returns this ArrayList
    /// </summary>
    public class WorkFlowList
    {
/*        private readonly ArrayList _activityList = new ArrayList();

        public void Add(IActivity activity)
        {
            _activityList.Add(activity);
        }

        public IActivity[] GetWorkflow()
        {
            if (_activityList.Count == 0) throw new InvalidOperationException("You can not get a workflow that is empty");
            private IActivity[] _activities = new IActivity[_activityList.Count];
            foreach (var VARIABLE in _activityList)
            {
                
            }
            return _activities;*/
        private readonly List<IActivity> _activityList = new List<IActivity>();

        public void Add(IActivity activity)
        {
            _activityList.Add(activity);
        }

        public IActivity[] GetWorkflow()
        {
            var array =_activityList.ToArray();
            return array;
        }
    }

}
using System.Collections.Generic;

namespace InterfaceOOP
{
    public class WorkflowEngine
    {
        private List<IActivity> Activities { get; set; }

        public WorkflowEngine()
        {
            Activities = new List<IActivity>();
        }

        public void AddActivity(IActivity activity)
        {
            Activities.Add(activity);
        }

        public void ExecuteAll()
        {
            foreach (var activity in Activities)
            {
                activity.Execute();
            }
        }
    }
}

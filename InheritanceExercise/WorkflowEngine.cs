using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExercise
{
    public class WorkflowEngine
    {
        private List<Activity> Activities { get; set; }

        public WorkflowEngine()
        {
            Activities = new List<Activity>();
        }

        public void AddActivity(Activity activity)
        {
            Activities.Add(activity);
        }

        public void ExecuteAll()
        {
            foreach(var activity in Activities)
            {
                activity.Execute();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListApp
{
    public class TaskManager
    {
        private List<Task> Tasks { get; set; }

        public TaskManager()
        {
            Tasks = new List<Task>();
        }

        public void Add(string name, string description)
        {
            var task = new Task(name, description);
            Tasks.Add(task);
        }

        public void Edit(int index, string name, string description)
        {
            var task = Tasks[index];

            if (task == null)
            {
                throw new Exception("Task not found");
            }

            task.Name = name;
            task.Description = description;
        }

        public void Remove(int index)
        {
            var task = Tasks[index];

            if (task == null)
            {
                throw new Exception("Task not found");
            }

            Tasks.RemoveAt(index);
        }

        public void RemoveAll()
        {
            Tasks.Clear();
        }

        public IReadOnlyList<Task> GetCurrentTasks()
        {
            return Tasks.ToList();
        }
    }
}

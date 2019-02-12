using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListApp
{
    class Program
    {
        private static TaskManager TaskManager { get; set; }

        static void Main(string[] args)
        {
            TaskManager = new TaskManager();

            var keyboardInput = string.Empty;
            
            while(keyboardInput != "0")
            {
                Console.WriteLine("Pick an option:");
                Console.WriteLine("1 - Add task");
                Console.WriteLine("2 - Edit task");
                Console.WriteLine("3 - Remove specific task");
                Console.WriteLine("4 - Remove all tasks");
                Console.WriteLine("5 - List all tasks");
                Console.WriteLine("0 - Exit");

                keyboardInput = Console.ReadLine();

                if (keyboardInput == "1")
                {
                    Console.WriteLine("Type the name of the task:");
                    var taskName = Console.ReadLine();

                    Console.WriteLine("Type the description of the task");
                    var taskDescription = Console.ReadLine();

                    TaskManager.Add(taskName, taskDescription);
                }
                else if (keyboardInput == "2")
                {
                    Console.WriteLine("Choose a task to edit:");

                    PrintTaskList();

                    var userInput = Console.ReadLine();

                    var userInputInt = Convert.ToInt32(userInput);

                    var taskIndex = userInputInt - 1;

                    Console.WriteLine("Type the new name");
                    var taskName = Console.ReadLine();

                    Console.WriteLine("Type the new description");
                    var taskDescription = Console.ReadLine();

                    TaskManager.Edit(taskIndex, taskName, taskDescription);
                }
                else if (keyboardInput == "3")
                {
                    Console.WriteLine("Choose a task to remove:");

                    PrintTaskList();

                    var taskIndex = Convert.ToInt32(Console.ReadLine()) - 1;

                    TaskManager.Remove(taskIndex);
                }
                else if (keyboardInput == "4")
                {
                    TaskManager.RemoveAll();
                }
                else if (keyboardInput == "5")
                {
                    Console.WriteLine("Here are all your tasks:");

                    PrintTaskList();
                }
            }
        }

        private static void PrintTaskList()
        {
            var tasks = TaskManager.GetCurrentTasks();

            for (var i = 0; i < tasks.Count(); i++)
            {
                Console.WriteLine($"{i + 1} - {tasks[i].Name} " +
                    $"- {tasks[i].Description}");
            }
        }
    }
}

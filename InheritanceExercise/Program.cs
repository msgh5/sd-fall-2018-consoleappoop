using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new WorkflowEngine();

            engine.AddActivity(new BackupActivity());
            engine.AddActivity(new UploadActivity());
            engine.AddActivity(new SendEmailActivity());
            engine.AddActivity(new DoWork());

            engine.ExecuteAll();

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;

namespace InterfaceOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new WorkflowEngine();

            engine.AddActivity(new BackupActivity());
            engine.AddActivity(new UploadActivity());
            engine.AddActivity(new SendEmailActivity());

            engine.ExecuteAll();

            Console.ReadLine();
        }
    }
}


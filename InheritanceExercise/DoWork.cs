using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExercise
{
    public class DoWork : Activity
    {
        public override void Execute()
        {
            Console.WriteLine("Doing some ilegal work");
        }
    }
}

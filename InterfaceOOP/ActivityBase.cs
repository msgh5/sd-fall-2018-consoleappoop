using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOOP
{
    public abstract class ActivityBase : IActivity
    {
        public void Cleanup()
        {
            Console.WriteLine("Cleaning up");
        }

        public virtual void Execute()
        {
            throw new NotImplementedException();
        }
    }
}

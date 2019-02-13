using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOOP
{
    public interface IActivity
    {
        void Cleanup();
        void Execute();
    }
}

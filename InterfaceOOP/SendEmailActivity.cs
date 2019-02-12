using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOOP
{
    public class SendEmailActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending email");
        }
    }
}

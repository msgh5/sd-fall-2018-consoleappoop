using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOOP
{
    public class BackupActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Making backup");
        }

        public void UploadFile()
        {
            throw new NotImplementedException();
        }
    }
}

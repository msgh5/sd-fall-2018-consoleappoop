using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOOP
{
    public class UploadActivity : ActivityBase
    {
        public override void Execute()
        {
            Console.WriteLine("Uploading file");
        }
    }
}

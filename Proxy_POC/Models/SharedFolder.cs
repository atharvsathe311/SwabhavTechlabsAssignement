using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_POC.Models
{
    public class SharedFolder : ISharedFolder
    {
        public void ReadWriteOperation()
        {
            Console.WriteLine("This is Original Folder");
            Console.WriteLine("Performed Read Write Operation");
        }
    }
}
